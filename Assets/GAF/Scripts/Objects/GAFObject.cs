/*
 * File:			GAFObject.cs
 * Version:			2.0
 * Last changed:	2015/2/2 14:32
 * Author:			Niktin.Nikolay
 * Copyright:		© GAFMedia
 * Project:			GAF Unity plugin
 */

using UnityEngine;

namespace GAF.Objects
{
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class GAFObject : GAFInternal.Objects.GAFObjectInternal
	{
		#region /////// GAFObject ////////

		//---------------------Initialize--------------------------//
		// <summary>
		// Create and initialize serialized object data.
		// </summary>
		// <param name="_Name">Object name.</param>
		// <param name="_BehaviourType">Object type.</param>
		// <param name="_Clip">Clip associated with current object.</param>
		// <param name="_Manager">Objects manager associated with current object.</param>
		// <param name="_GAFData">Data loaded from .gaf file for current object.</param>

		//public void initialize(string _Name , ObjectBehaviourType _BehaviourType, GAFBaseClip _Clip, GAFBaseObjectsManager _Manager , GAFInternal.Data.GAFObjectData _GAFData)

		//-------------------------------------------------------//

		#endregion /////// GAFObject ////////

		#region /////// IGAFObject /////////

		//---------------------Reload--------------------------//
		/// <summary>
		/// Reset object state and create non-serialized data.
		/// </summary>

		public override void reload()
		{
#if UNITY_5
			cachedRenderer.useLightProbes = false;
			cachedRenderer.reflectionProbeUsage = UnityEngine.Rendering.ReflectionProbeUsage.Off;
			cachedRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
#else
			cachedRenderer.castShadows = false;
#endif
			cachedRenderer.receiveShadows = false;
			base.reload();
		}

		//-------------------------------------------------------//

		//---------------------Update to state--------------------------//
		// <summary>
		// Update object to desired state.
		// </summary>
		// <param name="_State">State data.</param>
		// <param name="_Refresh">Force refresh state.</param>

		//public void updateToState(GAFObjectStateData _State, bool _Refresh);)

		//-------------------------------------------------------//

		//---------------------Cleanup--------------------------//
		// <summary>
		// Clean non-serialized data.
		// </summary>

		//public void cleanUp()

		//-------------------------------------------------------//

		#endregion /////// IGAFObject /////////

		#region ////// BASE PROPERTIES ////////

		//-----------------------Object ID----------------------------//
		// <summary>
		// Get the object identifier.
		// </summary>

		//public uint objectID { get; }

		//-------------------------------------------------------//

		//-----------------------Name-------------------------------//
		// <summary>
		// Get the name.
		// </summary>

		//public string name { get; }

		//-------------------------------------------------------//

		//-----------------------Type--------------------------------//
		// <summary>
		// Get the GAF type of object.
		// </summary>
		// <value>The type.</value>

		//public GAFObjectType type { get; }

		//-------------------------------------------------------//

		#endregion ////// BASE PROPERTIES ////////

		#region /////// PROPERTIES ////////

		//-----------------------GAF transform----------------------------//
		// <summary>
		// GAF transformation component.
		// <para />Contains redundant data for nested clips transforms.
		// </summary>

		//public GAFTransform gafTransform { get; }

		//-------------------------------------------------------//

		//-----------------------Current state----------------------------//
		// <summary>
		// Information about current state of this object.
		// </summary>

		//public GAFObjectStateData currentState { get; }

		//-------------------------------------------------------//

		//-----------------------Previous state----------------------------//
		// <summary>
		// Information about previous state of this object.
		// </summary>

		//public GAFObjectStateData previousState { get; }

		//-------------------------------------------------------//

		//-----------------------Current material----------------------------//
		// <summary>
		// Material of this object.
		// </summary>

		//public Material currentMaterial { get; }

		//-------------------------------------------------------//

		//-----------------------Current mesh----------------------------//
		// <summary>
		// Mesh of this object.
		// </summary>

		//public Mesh currentMesh { get; }

		//-------------------------------------------------------//

		//-----------------------Serialized properties----------------------------//
		// <summary>
		// Serialized data of this object.
		// </summary>

		//public GAFObjectData serializedProperties { get; }

		//-------------------------------------------------------//

		#endregion /////// PROPERTIES ////////
	}
}