#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// System.Random
struct Random_t1044426839;
// UnityEngine.Sprite
struct Sprite_t309593783;
// ShapeBehavior[]
struct ShapeBehaviorU5BU5D_t3707816624;
// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3057952154;
// System.Collections.Generic.List`1<UnityEngine.Vector3>
struct List_1_t1612828712;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// LevelManager
struct LevelManager_t3355282079;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ShapesGame
struct  ShapesGame_t1482718964  : public MonoBehaviour_t1158329972
{
public:
	// System.Random ShapesGame::ran
	Random_t1044426839 * ___ran_2;
	// System.Int32 ShapesGame::MAX_ROUNDS
	int32_t ___MAX_ROUNDS_3;
	// System.Int32 ShapesGame::MAX_CORRECT_ANSWERS
	int32_t ___MAX_CORRECT_ANSWERS_4;
	// UnityEngine.Vector3 ShapesGame::CURRENT_CA_SHAPE_POSITION
	Vector3_t2243707580  ___CURRENT_CA_SHAPE_POSITION_5;
	// System.Int32 ShapesGame::numberOfCorrectShapes
	int32_t ___numberOfCorrectShapes_6;
	// System.Int32 ShapesGame::correctShapeCount
	int32_t ___correctShapeCount_7;
	// System.Int32 ShapesGame::caShapeIndex
	int32_t ___caShapeIndex_8;
	// System.Boolean ShapesGame::isRoundOver
	bool ___isRoundOver_9;
	// UnityEngine.Sprite ShapesGame::caSprite
	Sprite_t309593783 * ___caSprite_10;
	// ShapeBehavior[] ShapesGame::shapeSprites
	ShapeBehaviorU5BU5D_t3707816624* ___shapeSprites_11;
	// ShapeBehavior[] ShapesGame::shapeSpriteTypes
	ShapeBehaviorU5BU5D_t3707816624* ___shapeSpriteTypes_12;
	// UnityEngine.GameObject[] ShapesGame::shapes
	GameObjectU5BU5D_t3057952154* ___shapes_13;
	// System.Collections.Generic.List`1<UnityEngine.Vector3> ShapesGame::shapePositions
	List_1_t1612828712 * ___shapePositions_14;
	// UnityEngine.GameObject ShapesGame::kaycee
	GameObject_t1756533147 * ___kaycee_15;
	// LevelManager ShapesGame::levelManager
	LevelManager_t3355282079 * ___levelManager_16;
	// System.Int32 ShapesGame::roundNum
	int32_t ___roundNum_17;

public:
	inline static int32_t get_offset_of_ran_2() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___ran_2)); }
	inline Random_t1044426839 * get_ran_2() const { return ___ran_2; }
	inline Random_t1044426839 ** get_address_of_ran_2() { return &___ran_2; }
	inline void set_ran_2(Random_t1044426839 * value)
	{
		___ran_2 = value;
		Il2CppCodeGenWriteBarrier(&___ran_2, value);
	}

	inline static int32_t get_offset_of_MAX_ROUNDS_3() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___MAX_ROUNDS_3)); }
	inline int32_t get_MAX_ROUNDS_3() const { return ___MAX_ROUNDS_3; }
	inline int32_t* get_address_of_MAX_ROUNDS_3() { return &___MAX_ROUNDS_3; }
	inline void set_MAX_ROUNDS_3(int32_t value)
	{
		___MAX_ROUNDS_3 = value;
	}

	inline static int32_t get_offset_of_MAX_CORRECT_ANSWERS_4() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___MAX_CORRECT_ANSWERS_4)); }
	inline int32_t get_MAX_CORRECT_ANSWERS_4() const { return ___MAX_CORRECT_ANSWERS_4; }
	inline int32_t* get_address_of_MAX_CORRECT_ANSWERS_4() { return &___MAX_CORRECT_ANSWERS_4; }
	inline void set_MAX_CORRECT_ANSWERS_4(int32_t value)
	{
		___MAX_CORRECT_ANSWERS_4 = value;
	}

	inline static int32_t get_offset_of_CURRENT_CA_SHAPE_POSITION_5() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___CURRENT_CA_SHAPE_POSITION_5)); }
	inline Vector3_t2243707580  get_CURRENT_CA_SHAPE_POSITION_5() const { return ___CURRENT_CA_SHAPE_POSITION_5; }
	inline Vector3_t2243707580 * get_address_of_CURRENT_CA_SHAPE_POSITION_5() { return &___CURRENT_CA_SHAPE_POSITION_5; }
	inline void set_CURRENT_CA_SHAPE_POSITION_5(Vector3_t2243707580  value)
	{
		___CURRENT_CA_SHAPE_POSITION_5 = value;
	}

	inline static int32_t get_offset_of_numberOfCorrectShapes_6() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___numberOfCorrectShapes_6)); }
	inline int32_t get_numberOfCorrectShapes_6() const { return ___numberOfCorrectShapes_6; }
	inline int32_t* get_address_of_numberOfCorrectShapes_6() { return &___numberOfCorrectShapes_6; }
	inline void set_numberOfCorrectShapes_6(int32_t value)
	{
		___numberOfCorrectShapes_6 = value;
	}

	inline static int32_t get_offset_of_correctShapeCount_7() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___correctShapeCount_7)); }
	inline int32_t get_correctShapeCount_7() const { return ___correctShapeCount_7; }
	inline int32_t* get_address_of_correctShapeCount_7() { return &___correctShapeCount_7; }
	inline void set_correctShapeCount_7(int32_t value)
	{
		___correctShapeCount_7 = value;
	}

	inline static int32_t get_offset_of_caShapeIndex_8() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___caShapeIndex_8)); }
	inline int32_t get_caShapeIndex_8() const { return ___caShapeIndex_8; }
	inline int32_t* get_address_of_caShapeIndex_8() { return &___caShapeIndex_8; }
	inline void set_caShapeIndex_8(int32_t value)
	{
		___caShapeIndex_8 = value;
	}

	inline static int32_t get_offset_of_isRoundOver_9() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___isRoundOver_9)); }
	inline bool get_isRoundOver_9() const { return ___isRoundOver_9; }
	inline bool* get_address_of_isRoundOver_9() { return &___isRoundOver_9; }
	inline void set_isRoundOver_9(bool value)
	{
		___isRoundOver_9 = value;
	}

	inline static int32_t get_offset_of_caSprite_10() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___caSprite_10)); }
	inline Sprite_t309593783 * get_caSprite_10() const { return ___caSprite_10; }
	inline Sprite_t309593783 ** get_address_of_caSprite_10() { return &___caSprite_10; }
	inline void set_caSprite_10(Sprite_t309593783 * value)
	{
		___caSprite_10 = value;
		Il2CppCodeGenWriteBarrier(&___caSprite_10, value);
	}

	inline static int32_t get_offset_of_shapeSprites_11() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___shapeSprites_11)); }
	inline ShapeBehaviorU5BU5D_t3707816624* get_shapeSprites_11() const { return ___shapeSprites_11; }
	inline ShapeBehaviorU5BU5D_t3707816624** get_address_of_shapeSprites_11() { return &___shapeSprites_11; }
	inline void set_shapeSprites_11(ShapeBehaviorU5BU5D_t3707816624* value)
	{
		___shapeSprites_11 = value;
		Il2CppCodeGenWriteBarrier(&___shapeSprites_11, value);
	}

	inline static int32_t get_offset_of_shapeSpriteTypes_12() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___shapeSpriteTypes_12)); }
	inline ShapeBehaviorU5BU5D_t3707816624* get_shapeSpriteTypes_12() const { return ___shapeSpriteTypes_12; }
	inline ShapeBehaviorU5BU5D_t3707816624** get_address_of_shapeSpriteTypes_12() { return &___shapeSpriteTypes_12; }
	inline void set_shapeSpriteTypes_12(ShapeBehaviorU5BU5D_t3707816624* value)
	{
		___shapeSpriteTypes_12 = value;
		Il2CppCodeGenWriteBarrier(&___shapeSpriteTypes_12, value);
	}

	inline static int32_t get_offset_of_shapes_13() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___shapes_13)); }
	inline GameObjectU5BU5D_t3057952154* get_shapes_13() const { return ___shapes_13; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_shapes_13() { return &___shapes_13; }
	inline void set_shapes_13(GameObjectU5BU5D_t3057952154* value)
	{
		___shapes_13 = value;
		Il2CppCodeGenWriteBarrier(&___shapes_13, value);
	}

	inline static int32_t get_offset_of_shapePositions_14() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___shapePositions_14)); }
	inline List_1_t1612828712 * get_shapePositions_14() const { return ___shapePositions_14; }
	inline List_1_t1612828712 ** get_address_of_shapePositions_14() { return &___shapePositions_14; }
	inline void set_shapePositions_14(List_1_t1612828712 * value)
	{
		___shapePositions_14 = value;
		Il2CppCodeGenWriteBarrier(&___shapePositions_14, value);
	}

	inline static int32_t get_offset_of_kaycee_15() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___kaycee_15)); }
	inline GameObject_t1756533147 * get_kaycee_15() const { return ___kaycee_15; }
	inline GameObject_t1756533147 ** get_address_of_kaycee_15() { return &___kaycee_15; }
	inline void set_kaycee_15(GameObject_t1756533147 * value)
	{
		___kaycee_15 = value;
		Il2CppCodeGenWriteBarrier(&___kaycee_15, value);
	}

	inline static int32_t get_offset_of_levelManager_16() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___levelManager_16)); }
	inline LevelManager_t3355282079 * get_levelManager_16() const { return ___levelManager_16; }
	inline LevelManager_t3355282079 ** get_address_of_levelManager_16() { return &___levelManager_16; }
	inline void set_levelManager_16(LevelManager_t3355282079 * value)
	{
		___levelManager_16 = value;
		Il2CppCodeGenWriteBarrier(&___levelManager_16, value);
	}

	inline static int32_t get_offset_of_roundNum_17() { return static_cast<int32_t>(offsetof(ShapesGame_t1482718964, ___roundNum_17)); }
	inline int32_t get_roundNum_17() const { return ___roundNum_17; }
	inline int32_t* get_address_of_roundNum_17() { return &___roundNum_17; }
	inline void set_roundNum_17(int32_t value)
	{
		___roundNum_17 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
