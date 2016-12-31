/*
 * File:			GAFBakedObjectsManager.cs
 * Version:			2.0
 * Last changed:	2015/2/2 14:32
 * Author:			Niktin.Nikolay
 * Copyright:		© GAFMedia
 * Project:			GAF Unity plugin
 */

using UnityEngine;

using System.Collections.Generic;

namespace GAF.Objects
{
	[System.Serializable]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class GAFBakedObjectsManager : GAFInternal.Objects.GAFBakedObjectsManagerInternal<GAFBakedObject>
	{
		#region /////// GAFBaseObjectManager //////////

		//---------------------Initialize--------------------------//
		// <summary>
		// Initialize object manager parameters.
		// <para />Animation subobjects are created here.
		// </summary>

		//public abstract void initialize();

		//-------------------------------------------------------//

		//---------------------Reload--------------------------//
		/// <summary>
		/// Reload object manager.
		/// <para />Non serialized subojects data reloads here.
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

		//----------------------------------------------------//

		//---------------------Clean view--------------------------//
		// <summary>
		// Reset clip view.
		// <para />Clean up non serialized objects data.
		// </summary>

		//public abstract void cleanView();

		//-----------------------------------------------------//

		//---------------------Clear--------------------------//
		// <summary>
		// Clear serialized and non serialized information about objects.
		// <para />Don't destroy children.
		// </summary>

		//public abstract void clear();

		//---------------------------------------------------//

		//---------------------Deep clear--------------------------//
		/// <summary>
		/// Clear serialized and non serialized information about objects.
		/// <para />Destroy children.
		/// </summary>
		public override void deepClear()
		{
			foreach (var obj in m_BakedObjects)
				obj.removeController();

			base.deepClear();
		}

		//------------------------------------------------------//

		//---------------------Update to frame--------------------------//
		// <summary>
		// Updates all objects presented in states list.
		// </summary>
		// <param name="_States">The _ states.</param>
		// <param name="_Refresh">if set to <c>true</c> [_ refresh].</param>

		//public abstract void updateToFrame(List<GAFInternal.Data.GAFObjectStateData> _States, bool _Refresh);

		//------------------------------------------------------------//

		#endregion  /////// GAFBaseObjectManager //////////

		#region ///////// BASE PROPERTIES //////////

		//-------------------------- Clip -------------------------//
		// <summary>
		// Reference to a clip
		// </summary>
		// <value>The clip.</value>

		//public abstract GAFBaseClip clip { get; }

		//-------------------------------------------------------//

		//--------------------------Objects-----------------------------//
		// <summary>
		// All objects list. Serialized data
		// </summary>
		// <value>The objects.</value>

		//public abstract IEnumerable<IGAFObject> objects { get; }

		//-------------------------------------------------------//

		//----------------------------Objects dict---------------------------//
		// <summary>
		// Objects list organized as dictionary. Non serialized data.
		// </summary>
		// <value>The objects dictionary.</value>

		//public abstract Dictionary<uint, IGAFObject> objectsDict { get; }

		//-------------------------------------------------------------//

		#endregion ///////// BASE PROPERTIES //////////

		#region ///////// PROPERTIES ///////////

		//-------------------------- Baked objects -------------------------//
		// <summary>
		// Gets the baked objects.
		// </summary>
		// <value>The baked objects.</value>

		//public List<TypeOfObject> bakedObjects { get; }

		//-------------------------------------------------------//

		#endregion ///////// PROPERTIES ///////////
	}
}