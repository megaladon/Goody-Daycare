// ***********************************************************************
// Assembly         : GAF
// Author           : Niktin.Nikolay
// Created          : 02-13-2015
//
// Last Modified By : Niktin.Nikolay
// Last Modified On : 02-17-2015
// ***********************************************************************
// <copyright file="GAFObjectsManagerInternal.cs" company="Catalyst apps">
//     Copyright © GAF Media 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

using UnityEngine;

using System.Collections.Generic;
using System.Linq;

using GAFInternal.Core;
using GAFInternal.Utils;
using System;
using GAFInternal.Data;

namespace GAFInternal.Objects
{
	[System.Serializable]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(GAFSortingManager))]
	public class GAFObjectsManagerInternal<TypeOfObject> : GAFBaseObjectsManager
		where TypeOfObject : GAFObjectInternal
	{
		#region Members

		[HideInInspector][SerializeField] private GAFBaseClip			m_MovieClip			= null;
		[HideInInspector][SerializeField] private GAFSortingManager		m_SortingManager	= null;
		[HideInInspector][SerializeField] private List<TypeOfObject>	m_Objects			= new List<TypeOfObject>();
		//[HideInInspector][SerializeField] private List<GAFTransform>	m_Timelines			= new List<GAFTransform>();

		[HideInInspector]
		[System.NonSerialized]
		private Dictionary<uint, IGAFObject> m_ObjectsDict = new Dictionary<uint, IGAFObject>();

		#endregion // Members

		#region Properties

		/// <summary>
		/// Reference to a clip
		/// </summary>
		/// <value>The clip.</value>
		public override GAFBaseClip clip 
		{
			get
			{
				return m_MovieClip;
			}
		}

		/// <summary>
		/// All objects list. Serialized data
		/// </summary>
		/// <value>The objects.</value>
		public override IEnumerable<IGAFObject> objects
		{
			get
			{
				return m_Objects.Cast<IGAFObject>();
			}
		}


		/// <summary>
		/// Objects list organized as dictionary. Non serialized data.
		/// </summary>
		/// <value>The objects dictionary.</value>
		public override Dictionary<uint, IGAFObject> objectsDict
		{
			get
			{
				if (m_ObjectsDict == null || m_ObjectsDict.Count == 0)
				{
					m_ObjectsDict = new Dictionary<uint, IGAFObject>();
					foreach (var _object in m_Objects)
					{
						m_ObjectsDict[_object.serializedProperties.objectID] = _object;
					}
				}

				return m_ObjectsDict;
			}
		}

		//public override List<GAFTransform> timelines
		//{
		//	get
		//	{
		//		return m_Timelines;
		//	}
		//}



		#endregion // Properties

		#region Interface

		/// <summary>
		/// Initialize object manager parameters.
		/// <para />Animation subobjects are created here.
		/// </summary>
		public override void initialize()
		{
			//cachedRenderer.hideFlags 	= HideFlags.NotEditable;
			//cachedFilter.hideFlags 		= HideFlags.NotEditable;

			m_MovieClip = GetComponent<GAFBaseClip>();

			m_SortingManager = GetComponent<GAFSortingManager>();
			m_SortingManager.initialize();

			createObjects();
		}

		/// <summary>
		/// Reload object manager.
		/// <para />Non serialized subojects data reloads here.
		/// </summary>
		public override void reload()
		{
			//cachedRenderer.hideFlags 	= HideFlags.NotEditable;
			//cachedFilter.hideFlags 		= HideFlags.NotEditable;

			if (m_SortingManager == null)
			{
				m_SortingManager = GetComponent<GAFSortingManager>();
				if (m_SortingManager == null)
					m_SortingManager = gameObject.AddComponent<GAFSortingManager>();
			}

			m_SortingManager.reload();

			foreach (var obj in m_Objects)
			{
				obj.reload();
			}
		}

		/// <summary>
		/// Reset clip view.
		/// <para />Clean up non serialized objects data.
		/// </summary>
		public override void cleanView()
		{
			if (cachedFilter.sharedMesh != null)
				cachedFilter.sharedMesh.Clear();
			
			cachedFilter.sharedMesh			= null;
			cachedRenderer.sharedMaterials 	= new Material[0];
			cachedRenderer.enabled 			= false;
			
			foreach (var obj in m_Objects)
				obj.cleanUp();
		}

		/// <summary>
		/// Clear serialized and non serialized information about objects.
		/// <para />Don't destroy children.
		/// </summary>
		public override void clear()
		{
			cleanView();

			if (m_ObjectsDict != null)
			{
				m_ObjectsDict.Clear();
				m_ObjectsDict = null;
			}

			foreach (var obj in m_Objects)
			{
				if (Application.isPlaying)
					Destroy(obj);
				else
					DestroyImmediate(obj, true);
			}

			m_Objects.Clear();
		}

		/// <summary>
		/// Clear serialized and non serialized information about objects.
		/// <para />Destroy children.
		/// </summary>
		public override void deepClear ()
		{
			clear();

			List<GameObject> children = new List<GameObject>();
			foreach (Transform child in cachedTransform)
				children.Add(child.gameObject);
			
			children.ForEach((GameObject child) =>
			{
				if (Application.isPlaying)
					Destroy(child);
				else
					DestroyImmediate(child, true);
			});
		}

		/// <summary>
		/// Updates all objects presented in states list.
		/// </summary>
		/// <param name="_States">The _ states.</param>
		/// <param name="_Refresh">if set to <c>true</c> [_ refresh].</param>
		public sealed override void updateToFrame(Dictionary<uint, Data.GAFObjectStateData> _States, bool _Refresh)
		{
			if (_Refresh)
			{
				for (int i = 0; i < m_Objects.Count; i++)
				{
					var obj = m_Objects[i];

					if (_States.ContainsKey(obj.objectID))
					{
						obj.updateToState(_States[obj.objectID], _Refresh);
					}
					else
					{
						obj.updateToState(GAFObjectStateData.defaultState, _Refresh);
					}
				}
			}
			else
			{
				foreach (var state in _States)
				{
					if (objectsDict.ContainsKey(state.Key))
					{
						objectsDict[state.Key].updateToState(state.Value, _Refresh);
					}
				}
			}

			m_SortingManager.updateToState();
		}

		public sealed override void updateToKeyFrame(List<GAFObjectStateData> _States)
		{
			var tempObjectsDict = new Dictionary<uint, IGAFObject>(objectsDict);

			for (int i = 0; i < _States.Count; i++)
			{
				var state = _States[i];
				tempObjectsDict[state.id].updateToState(state, true);
				tempObjectsDict.Remove(state.id);
			}

			foreach (var item in tempObjectsDict)
			{
				item.Value.updateToState(GAFObjectStateData.defaultState, true);
			}

			m_SortingManager.updateToState();
		}

		#endregion // Interface

		#region Implementation

		protected sealed override void createObjects()
		{
			var objects = clip.asset.getObjects(clip.timelineID);
			var masks = clip.asset.getMasks(clip.timelineID);

			for (int i = 0; i < objects.Count; ++i)
			{
				var _objectData = objects[i];
				string _name = string.Empty;

				if (_objectData.type == GAFObjectType.Timeline)
				{
					_name = clip.asset.getTimeline((int)_objectData.atlasElementID).linkageName;
				}
				if (string.IsNullOrEmpty(_name))
				{
					_name = getObjectName(_objectData);
				}
				var _type = clip.asset.getExternalData(clip.timelineID).objectTypeFlags[i];

				m_Objects.Add(createObject(_name, _type, _objectData));
			}

			if (masks != null)
			{
				for (int i = 0; i < masks.Count; ++i)
				{
					var _maskData = masks[i];
					var _name = getObjectName(_maskData) + "_mask";

					m_Objects.Add(createObject(_name, ObjectBehaviourType.Mask, _maskData));
				}
			}
		}

		private TypeOfObject createObject(string _Name, ObjectBehaviourType _Type, GAFInternal.Data.GAFObjectData _Data)
		{
			var gameObj = new GameObject { name = _Name };
			gameObj.transform.parent		= this.transform;
			gameObj.transform.localScale	= Vector3.one;
			gameObj.transform.localPosition	= Vector3.zero;

			var component = gameObj.AddComponent<TypeOfObject>();
			var gafTransform = component.GetComponent<GAFTransform>();
			gafTransform.gafParent = clip.gafTransform;
			component.initialize(_Name, _Type, clip, this, _Data);

			//if (_Data.type == Data.GAFObjectType.Timeline)
			//{
			//	m_Timelines.Add(gafTransform);
			//}
			return component;
		}

		#endregion // Implementation
	}
}