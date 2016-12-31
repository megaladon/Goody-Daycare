/*
 * File:			GAFCustomDelegateCreator.cs
 * Version:			2.0
 * Last changed:	2015/2/2 14:33
 * Author:			Niktin.Nikolay
 * Copyright:		© GAFMedia
 * Project:			GAF Unity plugin
 */

using UnityEngine;

namespace GAF.Core
{
	public static class GAFCustomDelegateCreator
	{
		public static void Init()
		{
			GAFInternal.Core.GAFCustomResourceDelegate.DelegateCreator			= Creator;
			GAFInternal.Core.GAFCustomResourceDelegate.StaticDelegateCreator	= StaticCreator;
		}

		private static System.Func<string, GAFInternal.Assets.GAFTexturesResourceInternal> Creator(object _Target, string _Method)
		{
			System.Func<string, GAFInternal.Assets.GAFTexturesResourceInternal> result = null;

#if UNITY_WINRT && !UNITY_EDITOR

#if NETFX_CORE
			result = System.Func<string, GAFInternal.Assets.GAFTexturesResourceInternal>.CreateDelegate(
				  typeof(System.Func<string, GAFInternal.Assets.GAFTexturesResourceInternal>)
				, _Target
				, _Target.GetTypeInfo().GetDeclaredMethod(_Method)) as System.Func<string, GAFInternal.Assets.GAFTexturesResourceInternal>;
#else
			result = System.Func<string, GAFInternal.Assets.GAFTexturesResourceInternal>.CreateDelegate(
				  typeof(System.Func<string, GAFInternal.Assets.GAFTexturesResourceInternal>)
				, _Target
				, _Target.GetType().GetMethod(_Method)) as System.Func<string, GAFInternal.Assets.GAFTexturesResourceInternal>;
#endif // NETFX_CORE

#else
			result = System.Delegate.CreateDelegate(
				  typeof(System.Func<string, GAFInternal.Assets.GAFTexturesResourceInternal>)
				, _Target
				, _Target.GetType().GetMethod(_Method)) as System.Func<string, GAFInternal.Assets.GAFTexturesResourceInternal>;
#endif // UNITY_WINRT && !UNITY_EDITOR

			return result;
		}

		private static System.Func<string, GAFInternal.Assets.GAFTexturesResourceInternal> StaticCreator(string _TargetTypeString, string _Method)
		{
			var targetType = System.Type.GetType(_TargetTypeString);
			return System.Delegate.CreateDelegate(
				  typeof(System.Func<string, GAFInternal.Assets.GAFTexturesResourceInternal>)
				, null
				, targetType.GetMethod(_Method)) as System.Func<string, GAFInternal.Assets.GAFTexturesResourceInternal>;
		}
	}
}
