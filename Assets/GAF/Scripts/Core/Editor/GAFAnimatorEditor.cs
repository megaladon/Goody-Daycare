/*
 * File:			GAFAnimatorEditor.cs
 * Version:			2.0
 * Last changed:	2015/2/2 14:44
 * Author:			Niktin.Nikolay
 * Copyright:		© GAFMedia
 * Project:			GAF Unity plugin
 */

using UnityEditor;
using UnityEngine;

using GAF.Core;
using GAF.Assets;
using GAF.Objects;

using GAFEditorInternal.Core;

namespace GAFEditor.Core
{
    [CustomEditor(typeof(GAFAnimator))]
    [CanEditMultipleObjects]
    public class GAFAnimatorEditor : GAFAnimatorInternalEditor<GAFObjectsManager, GAFTexturesResource>
    {
    }
}
