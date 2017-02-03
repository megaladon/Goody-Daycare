#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// PuzzleGame
struct PuzzleGame_t1068893802;
// UnityEngine.GameObject
struct GameObject_t1756533147;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PuzzlePiece
struct  PuzzlePiece_t1912707670  : public MonoBehaviour_t1158329972
{
public:
	// PuzzleGame PuzzlePiece::puzzleGame
	PuzzleGame_t1068893802 * ___puzzleGame_2;
	// System.Int32 PuzzlePiece::positionNumber
	int32_t ___positionNumber_3;
	// UnityEngine.GameObject PuzzlePiece::puzzlePiece
	GameObject_t1756533147 * ___puzzlePiece_4;
	// UnityEngine.Vector3 PuzzlePiece::correctPosition
	Vector3_t2243707580  ___correctPosition_5;
	// UnityEngine.Vector3 PuzzlePiece::offPosition
	Vector3_t2243707580  ___offPosition_6;
	// System.Boolean PuzzlePiece::isResetting
	bool ___isResetting_7;
	// System.Boolean PuzzlePiece::isLocked
	bool ___isLocked_8;

public:
	inline static int32_t get_offset_of_puzzleGame_2() { return static_cast<int32_t>(offsetof(PuzzlePiece_t1912707670, ___puzzleGame_2)); }
	inline PuzzleGame_t1068893802 * get_puzzleGame_2() const { return ___puzzleGame_2; }
	inline PuzzleGame_t1068893802 ** get_address_of_puzzleGame_2() { return &___puzzleGame_2; }
	inline void set_puzzleGame_2(PuzzleGame_t1068893802 * value)
	{
		___puzzleGame_2 = value;
		Il2CppCodeGenWriteBarrier(&___puzzleGame_2, value);
	}

	inline static int32_t get_offset_of_positionNumber_3() { return static_cast<int32_t>(offsetof(PuzzlePiece_t1912707670, ___positionNumber_3)); }
	inline int32_t get_positionNumber_3() const { return ___positionNumber_3; }
	inline int32_t* get_address_of_positionNumber_3() { return &___positionNumber_3; }
	inline void set_positionNumber_3(int32_t value)
	{
		___positionNumber_3 = value;
	}

	inline static int32_t get_offset_of_puzzlePiece_4() { return static_cast<int32_t>(offsetof(PuzzlePiece_t1912707670, ___puzzlePiece_4)); }
	inline GameObject_t1756533147 * get_puzzlePiece_4() const { return ___puzzlePiece_4; }
	inline GameObject_t1756533147 ** get_address_of_puzzlePiece_4() { return &___puzzlePiece_4; }
	inline void set_puzzlePiece_4(GameObject_t1756533147 * value)
	{
		___puzzlePiece_4 = value;
		Il2CppCodeGenWriteBarrier(&___puzzlePiece_4, value);
	}

	inline static int32_t get_offset_of_correctPosition_5() { return static_cast<int32_t>(offsetof(PuzzlePiece_t1912707670, ___correctPosition_5)); }
	inline Vector3_t2243707580  get_correctPosition_5() const { return ___correctPosition_5; }
	inline Vector3_t2243707580 * get_address_of_correctPosition_5() { return &___correctPosition_5; }
	inline void set_correctPosition_5(Vector3_t2243707580  value)
	{
		___correctPosition_5 = value;
	}

	inline static int32_t get_offset_of_offPosition_6() { return static_cast<int32_t>(offsetof(PuzzlePiece_t1912707670, ___offPosition_6)); }
	inline Vector3_t2243707580  get_offPosition_6() const { return ___offPosition_6; }
	inline Vector3_t2243707580 * get_address_of_offPosition_6() { return &___offPosition_6; }
	inline void set_offPosition_6(Vector3_t2243707580  value)
	{
		___offPosition_6 = value;
	}

	inline static int32_t get_offset_of_isResetting_7() { return static_cast<int32_t>(offsetof(PuzzlePiece_t1912707670, ___isResetting_7)); }
	inline bool get_isResetting_7() const { return ___isResetting_7; }
	inline bool* get_address_of_isResetting_7() { return &___isResetting_7; }
	inline void set_isResetting_7(bool value)
	{
		___isResetting_7 = value;
	}

	inline static int32_t get_offset_of_isLocked_8() { return static_cast<int32_t>(offsetof(PuzzlePiece_t1912707670, ___isLocked_8)); }
	inline bool get_isLocked_8() const { return ___isLocked_8; }
	inline bool* get_address_of_isLocked_8() { return &___isLocked_8; }
	inline void set_isLocked_8(bool value)
	{
		___isLocked_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
