/*
 * File:			GAFTexturesResourceEditor.cs
 * Version:			2.0
 * Last changed:	2015/2/2 14:34
 * Author:			Niktin.Nikolay
 * Copyright:		© GAFMedia
 * Project:			GAF Unity plugin
 */

using UnityEngine;
using UnityEditor;

using GAF.Assets;

using GAFEditorInternal.Assets;

namespace GAFEditor.Assets
{
	[CustomEditor(typeof(GAFTexturesResource))]
	public class GAFTexturesResourceEditor : GAFTexturesResourceInternalEditor
	{
	}
}