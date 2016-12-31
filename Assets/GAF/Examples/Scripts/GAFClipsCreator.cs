/*
 * File:			gafclipscreator.cs
 * Version:			2.0
 * Last changed:	2015/2/2 14:43
 * Author:			Niktin.Nikolay
 * Copyright:		© GAFMedia
 * Project:			GAF Unity plugin
 */

using UnityEngine;

using System.Collections;

using GAF.Assets;
using GAF.Core;

namespace GAF.Demo
{
	[AddComponentMenu("GAF/Demo/GAFClipsCreator")]
	public class GAFClipsCreator : MonoBehaviour
	{
		#region Members

		[SerializeField]
		private string BundleUrl = string.Empty;
		[SerializeField]
		private string AssetName = string.Empty;
		[Range(0, 5000)]
		[SerializeField]
		private int TimelineID = 0;
		[SerializeField]
		private bool BakeObjects = false;
		[SerializeField]
		private Vector3 Position = Vector3.zero;

		private AssetBundle m_Bundle = null;

		#endregion // Members

		#region Interface

		public GAFTexturesResource getResource(string _ResourceName)
		{
			GAFTexturesResource resource = null;

			if (m_Bundle != null)
			{
#if UNITY_5
				resource = m_Bundle.LoadAsset(_ResourceName, typeof(GAFTexturesResource)) as GAFTexturesResource;
#else
                resource = m_Bundle.Load(_ResourceName, typeof(GAFTexturesResource)) as GAFTexturesResource;
#endif
			}

			return resource;
		}

		#endregion // Interface

		#region Implementation

		private void Awake()
		{
			switch (Application.platform)
			{
				case RuntimePlatform.Android:
					BundleUrl += "_android.unity3d";
					break;

				case RuntimePlatform.IPhonePlayer:
					BundleUrl += "_iphone.unity3d";
					break;

				default:
					BundleUrl += ".unity3d";
					break;
			}
		}

		private IEnumerator Start()
		{
			Caching.CleanCache();

			var www = WWW.LoadFromCacheOrDownload(BundleUrl, 0);

			yield return www;

			m_Bundle = www.assetBundle;

			createClip();

			m_Bundle.Unload(false);
		}

		private void createClip()
		{
			if (m_Bundle != null)
			{
				GAFAnimationAsset asset = null;
				if (string.IsNullOrEmpty(AssetName))
					asset = m_Bundle.mainAsset as GAFAnimationAsset;
				else
#if UNITY_5
					asset = m_Bundle.LoadAsset(AssetName, typeof(GAFAnimationAsset)) as GAFAnimationAsset;
#else
					asset = m_Bundle.Load(AssetName, typeof(GAFAnimationAsset)) as GAFAnimationAsset;
#endif

				var clipObj = new GameObject(asset.name);
				clipObj.transform.position = Position;

				GAFInternal.Core.GAFBaseClip clip = null;
				if (BakeObjects)
					clip = clipObj.AddComponent<GAFBakedMovieClip>();
				else
					clip = clipObj.AddComponent<GAFMovieClip>();

				clip.initialize(asset, TimelineID);

				clip.useCustomDelegate = true;
				clip.customGetResourceDelegate = getResource;
				clip.reload();
			}
		}

		#endregion // Implementation
	}
}
