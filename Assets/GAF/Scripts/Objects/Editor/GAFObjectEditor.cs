/*
 * File:			GAFObjectEditor.cs
 * Version:			2.0
 * Last changed:	2015/2/2 14:33
 * Author:			Niktin.Nikolay
 * Copyright:		© GAFMedia
 * Project:			GAF Unity plugin
 */

using UnityEngine;
using UnityEditor;

using GAF.Objects;

using GAFEditorInternal.Objects;

namespace GAFEditor.Objects
{
	[CanEditMultipleObjects]
	[CustomEditor(typeof(GAFObject))]
	public class GAFObjectEditor : GAFObjectInternalEditor
	{
	}
}