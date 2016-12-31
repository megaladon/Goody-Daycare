/*
 * File:			GAFCustomStaticResourceLoader.cs
 * Version:			2.0
 * Last changed:	2015/2/2 14:43
 * Author:			Niktin.Nikolay
 * Copyright:		© GAFMedia
 * Project:			GAF Unity plugin
 */

using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif // UNITY_EDITOR

using GAFInternal.Assets;

namespace GAF.Demo
{
	public static class GAFCustomStaticResourceLoader
	{
		public static GAFTexturesResourceInternal getResource(string _ResourceName)
		{
			GAFTexturesResourceInternal resource = null;

#if UNITY_EDITOR
			resource = AssetDatabase.LoadAssetAtPath("Assets/GAF/Examples/Cache/" + _ResourceName + ".asset", typeof(GAFTexturesResourceInternal)) as GAFTexturesResourceInternal;
#else
			GAFInternal.Utils.GAFUtils.Assert(false, "[GAF] GAFCustomStaticResourceLoader::getResource - is supposed to work only in editor and as example.\n Extend it if you want it to work in final builds!");
#endif // UNITY_EDITOR

			return resource;
		}
	}
}
