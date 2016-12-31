/*
 * File:			gafconverterwindowlistener.cs
 * Version:			2.0
 * Last changed:	2015/2/2 14:49
 * Author:			Niktin.Nikolay
 * Copyright:		© GAFMedia
 * Project:			GAF Unity plugin
 */

using UnityEditor;
using UnityEngine;

using System.Collections.Generic;
using System.IO;

using GAF.Core;
using GAF.Assets;
using GAFInternal.Utils;

using GAFEditorInternal.Converter.Window;

namespace GAFEditor.Core
{
	[InitializeOnLoad]
	public static class GAFConverterWindowListener
	{
		static GAFConverterWindowListener()
		{
			GAFConverterWindowEventDispatcher.onCreateClipEvent                    += onCreateClip;
			GAFConverterWindowEventDispatcher.onCreateClipPrefabEvent              += onCreateClipPrefab;
			GAFConverterWindowEventDispatcher.onCreateClipPrefabPlusInstanceEvent  += onCreateClipPrefabPlusInstance;
		}

		private static void onCreateClip(string _AssetPath, bool _IsBaked, bool _IsAnimator)
		{
			var assetName = Path.GetFileNameWithoutExtension(_AssetPath).Replace(" ", "_");
			var assetDir = "Assets" + Path.GetDirectoryName(_AssetPath).Replace(Application.dataPath, "") + "/";

			var asset = AssetDatabase.LoadAssetAtPath(assetDir + assetName + ".asset", typeof(GAFAnimationAsset)) as GAFAnimationAsset;
			if (!System.Object.Equals(asset, null))
			{
				var clipObject = createClip(asset, _IsBaked, _IsAnimator);

				var selected = new List<Object>(Selection.gameObjects);
				selected.Add(clipObject);
				Selection.objects = selected.ToArray();
			}
			else
			{
				GAFUtils.Log("Cannot find asset with path - " + _AssetPath, "");
			}
		}

		private static void onCreateClipPrefab(string _AssetPath, bool _IsBaked, bool _IsAnimator)
		{
			var assetName = Path.GetFileNameWithoutExtension(_AssetPath).Replace(" ", "_");
			var assetDir = "Assets" + Path.GetDirectoryName(_AssetPath).Replace(Application.dataPath, "") + "/";

			var asset = AssetDatabase.LoadAssetAtPath(assetDir + assetName + ".asset", typeof(GAFAnimationAsset)) as GAFAnimationAsset;
			if (!System.Object.Equals(asset, null))
			{
				var selected = new List<Object>(Selection.gameObjects);

				var prefabPath = assetDir + assetName;
				if (_IsBaked)
				{
					prefabPath += "_baked";
				}
				if (_IsAnimator)
				{
					prefabPath += "_animator";
				}

				prefabPath += ".prefab";

				var existingPrefab = AssetDatabase.LoadAssetAtPath(prefabPath, typeof(GameObject)) as GameObject;
				if (existingPrefab == null)
				{
					var clipObject = createClip(asset, _IsBaked, _IsAnimator);
					var prefab = PrefabUtility.CreateEmptyPrefab(prefabPath);
					prefab = PrefabUtility.ReplacePrefab(clipObject, prefab, ReplacePrefabOptions.ConnectToPrefab);
					GameObject.DestroyImmediate(clipObject);
					selected.Add(prefab);
				}
				else
				{
					selected.Add(existingPrefab);
				}

				Selection.objects = selected.ToArray();
			}
			else
			{
				GAFUtils.Log("Cannot find asset with path - " + _AssetPath, "");
			}
		}

		private static void onCreateClipPrefabPlusInstance(string _AssetPath, bool _IsBaked, bool _IsAnimator)
		{
			var assetName = Path.GetFileNameWithoutExtension(_AssetPath).Replace(" ", "_");
			var assetDir = "Assets" + Path.GetDirectoryName(_AssetPath).Replace(Application.dataPath, "") + "/";

			var asset = AssetDatabase.LoadAssetAtPath(assetDir + assetName + ".asset", typeof(GAFAnimationAsset)) as GAFAnimationAsset;
			if (!System.Object.Equals(asset, null))
			{
				var selected = new List<Object>(Selection.gameObjects);

				var prefabPath = assetDir + assetName;
				if (_IsBaked)
				{
					prefabPath += "_baked";
				}
				if (_IsAnimator)
				{
					prefabPath += "_animator";
				}

				prefabPath += ".prefab";

				var existingPrefab = AssetDatabase.LoadAssetAtPath(prefabPath, typeof(GameObject)) as GameObject;
				if (existingPrefab == null)
				{
					var clipObject = createClip(asset, _IsBaked, _IsAnimator);
					var prefab = PrefabUtility.CreateEmptyPrefab(prefabPath);
					prefab = PrefabUtility.ReplacePrefab(clipObject, prefab, ReplacePrefabOptions.ConnectToPrefab);

					selected.Add(clipObject);
					selected.Add(prefab);
				}
				else
				{
					var instance = PrefabUtility.InstantiatePrefab(existingPrefab) as GameObject;
					selected.Add(existingPrefab);
					selected.Add(instance);
				}

				Selection.objects = selected.ToArray();
			}
			else
			{
				GAFUtils.Log("Cannot find asset with path - " + _AssetPath, "");
			}
		}

		private static GameObject createClip(GAFAnimationAsset _Asset, bool _IsBaked, bool _IsAnimator)
		{
			var clipObject = new GameObject(_Asset.name);

			GAFInternal.Core.GAFBaseClip clip = null;
			if (_IsBaked)
			{
				if (!_IsAnimator)
					clip = clipObject.AddComponent<GAFBakedMovieClip>();
				else
					clip = clipObject.AddComponent<GAFBakedAnimator>();
			}
			else
			{
				if (!_IsAnimator)
					clip = clipObject.AddComponent<GAFMovieClip>();
				else
					clip = clipObject.AddComponent<GAFAnimator>();
			}

			clip.initialize(_Asset);
			clip.reload();

			return clipObject;
		}
	}
}
