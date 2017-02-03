#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// ShapesGame
struct ShapesGame_t1482718964;
// System.Collections.IEnumerator
struct IEnumerator_t1466026749;
// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_t1125654279;
// UnityEngine.SpriteRenderer
struct SpriteRenderer_t1209076198;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.Animator
struct Animator_t69676727;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_SpriteRenderer1209076198.h"
#include "UnityEngine_UnityEngine_GameObject1756533147.h"
#include "UnityEngine_UnityEngine_Animator69676727.h"

// System.Void ShapesGame::.ctor()
extern "C"  void ShapesGame__ctor_m4268891329 (ShapesGame_t1482718964 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::Start()
extern "C"  void ShapesGame_Start_m1737701825 (ShapesGame_t1482718964 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::initLevel()
extern "C"  void ShapesGame_initLevel_m3145213517 (ShapesGame_t1482718964 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::initShapesGame()
extern "C"  void ShapesGame_initShapesGame_m3219898853 (ShapesGame_t1482718964 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::initRound()
extern "C"  void ShapesGame_initRound_m4286415781 (ShapesGame_t1482718964 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.IEnumerator ShapesGame::OnPlaceShape(System.Collections.Generic.List`1<UnityEngine.GameObject>,System.Int32,System.Single)
extern "C"  Il2CppObject * ShapesGame_OnPlaceShape_m3733777026 (ShapesGame_t1482718964 * __this, List_1_t1125654279 * ___newShapes0, int32_t ___num1, float ___delayTime2, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::OnShapeClicked(UnityEngine.SpriteRenderer,UnityEngine.GameObject)
extern "C"  void ShapesGame_OnShapeClicked_m268326147 (ShapesGame_t1482718964 * __this, SpriteRenderer_t1209076198 * ___clickSprite0, GameObject_t1756533147 * ___obj1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::OutroDone(UnityEngine.GameObject)
extern "C"  void ShapesGame_OutroDone_m2946563302 (ShapesGame_t1482718964 * __this, GameObject_t1756533147 * ___obj0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::RemoveRemainingShapes()
extern "C"  void ShapesGame_RemoveRemainingShapes_m1698928735 (ShapesGame_t1482718964 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::checkLastShapeGone()
extern "C"  void ShapesGame_checkLastShapeGone_m1547410069 (ShapesGame_t1482718964 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::GameOver()
extern "C"  void ShapesGame_GameOver_m4017576457 (ShapesGame_t1482718964 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::test()
extern "C"  void ShapesGame_test_m1136387119 (ShapesGame_t1482718964 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::HandleCorrectShape(UnityEngine.Animator)
extern "C"  void ShapesGame_HandleCorrectShape_m901854356 (ShapesGame_t1482718964 * __this, Animator_t69676727 * ___anim0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::HandleIncorrectShape(UnityEngine.Animator)
extern "C"  void ShapesGame_HandleIncorrectShape_m2389808261 (ShapesGame_t1482718964 * __this, Animator_t69676727 * ___anim0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::KayceeCA()
extern "C"  void ShapesGame_KayceeCA_m2140294167 (ShapesGame_t1482718964 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::KayceeWA()
extern "C"  void ShapesGame_KayceeWA_m2140294827 (ShapesGame_t1482718964 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void ShapesGame::KayceeGameOver()
extern "C"  void ShapesGame_KayceeGameOver_m4139533201 (ShapesGame_t1482718964 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
