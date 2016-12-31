/*
 * File:			GAFAnimationAssetEditor.cs
 * Version:			2.0
 * Last changed:	2015/2/2 14:34
 * Author:			Niktin.Nikolay
 * Copyright:		© GAFMedia
 * Project:			GAF Unity plugin
 */

using UnityEditor;

using GAF.Assets;
using GAF.Core;

using GAFEditorInternal.Assets;
using UnityEngine;

using System.Linq;

#if UNITY_5
using UnityEditor.Animations;
#else
using UnityEditorInternal;
#endif

namespace GAFEditor.Assets
{
	[CanEditMultipleObjects]
	[CustomEditor(typeof(GAFAnimationAsset))]
	public class GAFAnimationAssetEditor : GAFAnimationAssetInternalEditor<GAFTexturesResource>
	{
		#region Implementation

		protected override void drawCreationMenu(int _TimelineID, ClipCreationOptions _Option)
		{
			switch(_Option)
			{
				case ClipCreationOptions.NotBakedMovieClip:
					drawCreateClip<GAFMovieClip>(_TimelineID, false, false);
					break;

				case ClipCreationOptions.NotBakedAnimator:
					drawCreateClip<GAFAnimator>(_TimelineID, false, true);
					break;

				case ClipCreationOptions.BakedMovieClip:
					drawCreateClip<GAFBakedMovieClip>(_TimelineID, true, false);
					break;

				case ClipCreationOptions.BakedAnimator:
					drawCreateClip<GAFBakedAnimator>(_TimelineID, true, true);
					break;
			}
		}

		protected override void drawMecanimResourcesData()
		{
			EditorGUILayout.BeginHorizontal();
			{
				GUILayout.Space(15f);
				m_MecanimResourcesFoldout = EditorGUILayout.Foldout(m_MecanimResourcesFoldout, "Mecanim resources: ");
			}
			EditorGUILayout.EndHorizontal();

			if (m_MecanimResourcesFoldout)
			{
				GUILayout.Space(5f);
				EditorGUILayout.BeginVertical(EditorStyles.textField);
				{
					var timelines = target.getTimelines();
					var sequencesCount = timelines.Select(_timeline => _timeline.sequences.Count).Sum();
					var clipsCount = target.animatorControllers.Select(_controller =>
					{
						var count = 0;
						if (_controller != null)
#if !UNITY_5
							count = (_controller as AnimatorController).GetLayer(0).stateMachine.stateCount;
#else
						count = (_controller as AnimatorController).layers[0].stateMachine.states.Length;
#endif // !UNITY_5
						return count;
					}).Sum();

					if (!target.animatorControllers.Any() ||
						 target.animatorControllers.Count != timelines.Count ||
						 clipsCount != sequencesCount)
					{
						EditorGUILayout.HelpBox("Animator controller links are broken - please press \"Rebuild mecanim resources\" button!", MessageType.Error);
					}
					else
					{
						var controllerName = "[" + target.name + "]_Timeline_" + currentTimeline.linkageName;
						var controller = target.animatorControllers.Find(_controller => _controller.name == controllerName) as AnimatorController;

						EditorGUILayout.BeginHorizontal();
						{
							GUILayout.Space(15f);
							if (controller != null)
							{
								var textWidth = GUIStyle.none.CalcSize(new GUIContent("Animator controller. Timeline - " + currentTimeline.linkageName + ": ")).x + 3f;
								EditorGUILayout.LabelField("Animator controller. Timeline - " + currentTimeline.linkageName + ": ", GUILayout.MaxWidth(textWidth));
								EditorGUILayout.ObjectField(controller, typeof(AnimatorController), false);
							}
							else
							{
								EditorGUILayout.HelpBox("Animator controller. Timeline - " + currentTimeline.linkageName + ": Missing. Please press \"Rebuild mecanim resources\" button", MessageType.Error);
							}
						}
						EditorGUILayout.EndHorizontal();

						if (controller != null)
						{
							foreach (var _sequence in currentTimeline.sequences)
							{
#if !UNITY_5
								var mainLayer = controller.GetLayer(0);

								var stateMachine = mainLayer.stateMachine;
								AnimationClip animation = null;
								for (int i = 0; i < stateMachine.stateCount; ++i)
								{
									var animatorState = stateMachine.GetState(i);
									var motion = animatorState.GetMotion();
									if (motion != null && motion.name.Contains(_sequence.name))
										animation = motion as AnimationClip;
								}

								EditorGUILayout.BeginHorizontal();
								{
									GUILayout.Space(30f);
									if (animation != null)
									{
										var textWidth = GUIStyle.none.CalcSize(new GUIContent("Animation clip. Sequence name - " + _sequence.name + ": ")).x + 3f;
										EditorGUILayout.LabelField("Animation clip. Sequence name - " + _sequence.name + ": ", GUILayout.MaxWidth(textWidth));
										EditorGUILayout.ObjectField(animation, typeof(AnimationClip), false);
									}
									else
									{
										EditorGUILayout.HelpBox("Animation clip. Sequence name - " + _sequence.name + ": Missing. Please press \"Rebuild mecanim resources\" button", MessageType.Error);
									}
								}
								EditorGUILayout.EndHorizontal();
#else
								var mainLayer = controller.layers[0];

								var stateMachine = mainLayer.stateMachine;
								AnimationClip animation = null;
								for (int i = 0; i < stateMachine.states.Length; ++i)
								{
									var animatorState	= stateMachine.states[i].state;
									var motion			= animatorState.motion;
									if (motion != null && motion.name.Contains(_sequence.name))
										animation = motion as AnimationClip;
								}

								EditorGUILayout.BeginHorizontal();
								{
									GUILayout.Space(30f);
									if (animation != null)
									{
										var textWidth = GUIStyle.none.CalcSize(new GUIContent("Animation clip. Sequence name - " + _sequence.name + ": ")).x + 3f;
										EditorGUILayout.LabelField("Animation clip. Sequence name - " + _sequence.name + ": ", GUILayout.MaxWidth(textWidth));
										EditorGUILayout.ObjectField(animation, typeof(AnimationClip), false);
									}
									else
									{
										EditorGUILayout.HelpBox("Animation clip. Sequence name - " + _sequence.name + ": Missing. Please press \"Rebuild mecanim resources\" button", MessageType.Error);
									}
								}
								EditorGUILayout.EndHorizontal();
#endif // !UNITY_5
							}
						}

						GUILayout.Space(5f);
					}
				}
				EditorGUILayout.EndVertical();

				var previousEnabled = GUI.enabled;
				GUI.enabled = previousEnabled && (state == AssetState.SingleLoaded || state == AssetState.MultipleLoaded);
				if (GUILayout.Button("Rebuild mecanim resources"))
				{
					GAFResourceManagerInternal.instance.createMecanimResources(target);
				}
				GUI.enabled = previousEnabled;
			}
		}
		#endregion // Implementation
	}
}