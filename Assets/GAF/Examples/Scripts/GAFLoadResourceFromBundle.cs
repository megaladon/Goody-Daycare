/*
 * File:			GAFLoadResourceFromBundle.cs
 * Version:			2.0
 * Last changed:	2015/2/2 14:43
 * Author:			Niktin.Nikolay
 * Copyright:		© GAFMedia
 * Project:			GAF Unity plugin
 */

using UnityEngine;

using System.Collections;

using GAF.Core;
using GAF.Assets;
using GAFInternal.Assets;

namespace GAF.Demo
{
	[AddComponentMenu("GAF/Demo/GAFLoadResourceFromBundle")]
	[RequireComponent(typeof(GAFMovieClip))]
	public class GAFLoadResourceFromBundle : MonoBehaviour
	{
		#region Members

		[SerializeField]
		private string BundleUrl = string.Empty;
		[SerializeField]
		private string AssetName = string.Empty;
		[Range(0, 5000)]
		[SerializeField]
		private int TimelineID = 0;

		private AssetBundle m_Bundle = null;

		#endregion // Members

		#region Interface

		public GAFTexturesResourceInternal getResource(string _ResourceName)
		{
			GAFTexturesResourceInternal resource = null;

			if (m_Bundle != null)
			{
#if UNITY_5
				resource = m_Bundle.LoadAsset(_ResourceName, typeof(GAFTexturesResourceInternal)) as GAFTexturesResourceInternal;
#else
				resource = m_Bundle.Load(_ResourceName, typeof(GAFTexturesResourceInternal)) as GAFTexturesResourceInternal;
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
			var www = WWW.LoadFromCacheOrDownload(BundleUrl, 0);

			yield return www;

			m_Bundle = www.assetBundle;

			setUpClip();

			m_Bundle.Unload(false);
		}

		private void setUpClip()
		{
			if (m_Bundle != null)
			{
				GAFAnimationAsset asset = null;
				if (string.IsNullOrEmpty(AssetName))
				{
					asset = m_Bundle.mainAsset as GAFAnimationAsset;
				}
				else
				{
#if UNITY_5
					asset = m_Bundle.LoadAsset(AssetName, typeof(GAFAnimationAsset)) as GAFAnimationAsset;
#else
					asset = m_Bundle.Load(AssetName, typeof(GAFAnimationAsset)) as GAFAnimationAsset;
#endif
				}

				var clip = GetComponent<GAFMovieClip>();

				clip.initialize(asset, TimelineID);
				clip.usePlaceholder = false;

				
				clip.reload();

				clip.setDefaultSequence(true);
			}
		}

		#endregion // Implementation
	}
}
