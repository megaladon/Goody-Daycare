/*
 * File:			GAFCustomResourceLoader.cs
 * Version:			2.0
 * Last changed:	2015/2/2 14:43
 * Author:			Niktin.Nikolay
 * Copyright:		© GAFMedia
 * Project:			GAF Unity plugin
 */

using UnityEngine;

using System.Collections.Generic;

using GAFInternal.Assets;

namespace GAF.Demo
{
	[AddComponentMenu("GAF/Demo/GAFCustomResourceLoader")]
	public class GAFCustomResourceLoader : MonoBehaviour 
	{
		#region Members

		[SerializeField] private List<GAFTexturesResourceInternal> PreloadedResources = new List<GAFTexturesResourceInternal>();

		#endregion // Members

		#region Interface

		public GAFTexturesResourceInternal getResource(string _ResourceName)
		{
			return PreloadedResources.Find (resource => resource.name == _ResourceName);
		}

		#endregion // Interface
	}
}
