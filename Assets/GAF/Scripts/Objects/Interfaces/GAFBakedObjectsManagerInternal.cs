// ***********************************************************************
// Assembly         : GAF
// Author           : Niktin.Nikolay
// Created          : 02-13-2015
//
// Last Modified By : Niktin.Nikolay
// Last Modified On : 02-16-2015
// ***********************************************************************
// <copyright file="GAFBakedObjectsManagerInternal.cs" company="Catalyst apps">
//     Copyright © GAF Media 2015
// </copyright>
// <summary></summary>
// ***********************************************************************
/*
 * File:			GAFBakedObjectsManagerInternal.cs
 * Version:			2.0
 * Last changed:	2015/2/2 10:33
 * Author:			Niktin.Nikolay
 * Copyright:		© GAFMedia
 * Project:			GAF
 */

using UnityEngine;

using System.Collections.Generic;
using System.Linq;

using GAFInternal.Core;
using System;
using GAFInternal.Data;

namespace GAFInternal.Objects
{
	[System.Serializable]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(GAFMeshManager))]
	public class GAFBakedObjectsManagerInternal<TypeOfObject> : GAFBaseObjectsManager
		where TypeOfObject : GAFBakedObjectInternal, new()
	{
		#region Members
		
		[HideInInspector][SerializeField] protected GAFBaseClip				m_MovieClip		= null;
		[HideInInspector][SerializeField] protected GAFMeshManager			m_MeshManager	= null;
		[HideInInspector][SerializeField] protected List<TypeOfObject>		m_BakedObjects	= new List<TypeOfObject>();
		
		private Dictionary<uint, IGAFObject> m_ObjectsDict = null;

		#endregion // Members

		#region Properties

		/// <summary>
		/// Reference to a clip
		/// </summary>
		/// <value>The clip.</value>
		public override GAFBaseClip clip 
		{
			get
			{
				return m_MovieClip;
			}
		}

		/// <summary>
		/// All objects list. Serialized data
		/// </summary>
		/// <value>The objects.</value>
		public override IEnumerable<IGAFObject> objects
		{
			get
			{
				return m_BakedObjects.Cast<IGAFObject>();
			}
		}

		/// <summary>
		/// Gets the baked objects.
		/// </summary>
		/// <value>The baked objects.</value>
		public List<TypeOfObject> bakedObjects
		{
			get
			{
				return m_BakedObjects;
			}
		}

		/// <summary>
		/// Returns dictionary where key is ID of GAF object and value is the object.
		/// </summary>
		/// <value>The objects dictionary.</value>
		public override Dictionary<uint, IGAFObject> objectsDict
		{
			get
			{
				if (m_ObjectsDict == null)
				{
					m_ObjectsDict = new Dictionary<uint, IGAFObject>();
					foreach (var _object in m_BakedObjects)
					{
						m_ObjectsDict[_object.serializedProperties.objectID] = _object;
					}
				}
				
				return m_ObjectsDict;
			}
		}

		//public override List<GAFTransform> timelines
		//{
		//	get
		//	{
		//		throw new NotImplementedException();
		//	}
		//}

		#endregion // Properties

		#region Interface

		/// <summary>
		/// Initialize object manager parameters.
		/// <para />Animation subobjects are created here.
		/// </summary>
		public override void initialize()
		{
			//cachedRenderer.hideFlags 	= HideFlags.NotEditable;
			//cachedFilter.hideFlags 		= HideFlags.NotEditable;

			m_MovieClip = GetComponent<GAFBaseClip>();

            createObjects();

			m_MeshManager = GetComponent<GAFMeshManager>();
			m_MeshManager.initialize ();
		}

		/// <summary>
		/// Reload object manager.
		/// <para />Non serialized subojects data reloads here.
		/// </summary>
		public override void reload()
		{
			//cachedRenderer.hideFlags 	= HideFlags.NotEditable;
			//cachedFilter.hideFlags 		= HideFlags.NotEditable;

			if (m_MeshManager == null)
			{
				m_MeshManager = GetComponent<GAFMeshManager>();
				if (m_MeshManager == null)
					m_MeshManager = gameObject.AddComponent<GAFMeshManager>();
			}

			m_MeshManager.reload();

			foreach (var obj in objectsDict.Values)
			{
				obj.reload();
			}
		}

		/// <summary>
		/// Reset clip view.
		/// <para />Clean up non serialized objects data.
		/// </summary>
		public override void cleanView()
		{
			if (cachedFilter.sharedMesh != null)
				cachedFilter.sharedMesh.Clear();
			
			cachedFilter.sharedMesh			= null;
			cachedRenderer.sharedMaterials 	= new Material[0];

			foreach (var obj in m_BakedObjects)
				obj.cleanUp();
		}

		/// <summary>
		/// Clear serialized and non serialized information about objects.
		/// <para />Don't destroy children.
		/// </summary>
		public override void clear()
		{
			cleanView ();

			if (m_ObjectsDict != null)
			{
				m_ObjectsDict.Clear();
				m_ObjectsDict = null;
			}

			m_BakedObjects.Clear();
		}

		/// <summary>
		/// Clear serialized and non serialized information about objects.
		/// <para />Destroy children.
		/// </summary>
		public override void deepClear()
		{
			clear();
		}

		/// <summary>
		/// Updates all objects presented in states list.
		/// </summary>
		/// <param name="_States">The _ states.</param>
		/// <param name="_Refresh">if set to <c>true</c> [_ refresh].</param>
		public sealed override void updateToFrame(Dictionary<uint, Data.GAFObjectStateData> _States, bool _Refresh)
		{
			if (_Refresh)
			{
				for (int i = 0; i < bakedObjects.Count; i++)
				{
					var obj = bakedObjects[i];

					if (_States.ContainsKey(obj.objectID))
					{
						obj.updateToState(_States[obj.objectID], _Refresh);
					}
					else
					{
						obj.updateToState(Data.GAFObjectStateData.defaultState, _Refresh);
					}
				}

				//foreach (var obj in bakedObjects)
				//{
				//	if (_States.ContainsKey(obj.objectID))
				//	{
				//		obj.updateToState(_States[obj.objectID], _Refresh);
				//	}
				//	else
				//	{
				//		obj.updateToState(Data.GAFObjectStateData.defaultState, _Refresh);
				//	}
				//}
			}
			else
			{
				foreach (var state in _States)
				{
					if (objectsDict.ContainsKey(state.Key))
					{
						objectsDict[state.Key].updateToState(state.Value, _Refresh);
					}
				}
			}


			//foreach (var state in _States)
			//{
			//	if (objectsDict.ContainsKey(state.Key))
			//	{
			//		objectsDict[state.Key].updateToState(state.Value, _Refresh);
			//	}
			//}
			
			m_MeshManager.updateToState();
		}

		public sealed override void updateToKeyFrame(List<GAFObjectStateData> _States)
		{
			var tempObjectsDict = new Dictionary<uint, IGAFObject>(objectsDict);

			for (int i = 0; i < _States.Count; i++)
			{
				var state = _States[i];

				tempObjectsDict[state.id].updateToState(state, true);
				tempObjectsDict.Remove(state.id);
			}

			foreach (var item in tempObjectsDict)
			{
				item.Value.updateToState(GAFObjectStateData.defaultState, true);
			}

			m_MeshManager.updateToState();
		}

		#endregion // Interface

		#region Implementation

		protected sealed override void createObjects()
		{
			m_BakedObjects = new List<TypeOfObject>();
			
			var objects = clip.asset.getObjects(clip.timelineID);
			var masks 	= clip.asset.getMasks(clip.timelineID);
			
			for (int i = 0; i < objects.Count; ++i)
			{
				var _objectData = objects[i];
				var _name		= getObjectName(_objectData);
				var _type		= clip.asset.getExternalData(clip.timelineID).objectTypeFlags[i];
				
				m_BakedObjects.Add(createObject(_name, _type, _objectData));
			}
			
			if (masks != null)
			{
				for (int i = 0; i < masks.Count; i++)
				{
					var _maskData	= masks[i];
					var _name		= getObjectName(_maskData) + "_mask";
					
					m_BakedObjects.Add(createObject(_name, ObjectBehaviourType.Mask, _maskData));
				}
			}
		}
		
		private TypeOfObject createObject(string _Name, ObjectBehaviourType _Type, GAFInternal.Data.GAFObjectData _Data)
		{
			var bakedObject = new TypeOfObject ();
			bakedObject.initialize(_Name, _Type, clip, this, _Data);
			
			return bakedObject;
		}
		
		#endregion // Implementation
	}
}
