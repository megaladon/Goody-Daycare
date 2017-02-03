#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3057952154;
// UnityEngine.Sprite
struct Sprite_t309593783;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// BubblesGame
struct  BubblesGame_t770340633  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject BubblesGame::bubbleAnimation
	GameObject_t1756533147 * ___bubbleAnimation_2;
	// UnityEngine.GameObject[] BubblesGame::letters
	GameObjectU5BU5D_t3057952154* ___letters_3;
	// System.Int32 BubblesGame::gameLenghtInSeconds
	int32_t ___gameLenghtInSeconds_4;
	// System.Int32 BubblesGame::groupCount
	int32_t ___groupCount_5;
	// UnityEngine.Sprite BubblesGame::caSprite
	Sprite_t309593783 * ___caSprite_6;
	// System.Single BubblesGame::startTime
	float ___startTime_7;
	// System.Boolean BubblesGame::isTimeUp
	bool ___isTimeUp_8;
	// System.Boolean BubblesGame::hasEndGamestarted
	bool ___hasEndGamestarted_9;

public:
	inline static int32_t get_offset_of_bubbleAnimation_2() { return static_cast<int32_t>(offsetof(BubblesGame_t770340633, ___bubbleAnimation_2)); }
	inline GameObject_t1756533147 * get_bubbleAnimation_2() const { return ___bubbleAnimation_2; }
	inline GameObject_t1756533147 ** get_address_of_bubbleAnimation_2() { return &___bubbleAnimation_2; }
	inline void set_bubbleAnimation_2(GameObject_t1756533147 * value)
	{
		___bubbleAnimation_2 = value;
		Il2CppCodeGenWriteBarrier(&___bubbleAnimation_2, value);
	}

	inline static int32_t get_offset_of_letters_3() { return static_cast<int32_t>(offsetof(BubblesGame_t770340633, ___letters_3)); }
	inline GameObjectU5BU5D_t3057952154* get_letters_3() const { return ___letters_3; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_letters_3() { return &___letters_3; }
	inline void set_letters_3(GameObjectU5BU5D_t3057952154* value)
	{
		___letters_3 = value;
		Il2CppCodeGenWriteBarrier(&___letters_3, value);
	}

	inline static int32_t get_offset_of_gameLenghtInSeconds_4() { return static_cast<int32_t>(offsetof(BubblesGame_t770340633, ___gameLenghtInSeconds_4)); }
	inline int32_t get_gameLenghtInSeconds_4() const { return ___gameLenghtInSeconds_4; }
	inline int32_t* get_address_of_gameLenghtInSeconds_4() { return &___gameLenghtInSeconds_4; }
	inline void set_gameLenghtInSeconds_4(int32_t value)
	{
		___gameLenghtInSeconds_4 = value;
	}

	inline static int32_t get_offset_of_groupCount_5() { return static_cast<int32_t>(offsetof(BubblesGame_t770340633, ___groupCount_5)); }
	inline int32_t get_groupCount_5() const { return ___groupCount_5; }
	inline int32_t* get_address_of_groupCount_5() { return &___groupCount_5; }
	inline void set_groupCount_5(int32_t value)
	{
		___groupCount_5 = value;
	}

	inline static int32_t get_offset_of_caSprite_6() { return static_cast<int32_t>(offsetof(BubblesGame_t770340633, ___caSprite_6)); }
	inline Sprite_t309593783 * get_caSprite_6() const { return ___caSprite_6; }
	inline Sprite_t309593783 ** get_address_of_caSprite_6() { return &___caSprite_6; }
	inline void set_caSprite_6(Sprite_t309593783 * value)
	{
		___caSprite_6 = value;
		Il2CppCodeGenWriteBarrier(&___caSprite_6, value);
	}

	inline static int32_t get_offset_of_startTime_7() { return static_cast<int32_t>(offsetof(BubblesGame_t770340633, ___startTime_7)); }
	inline float get_startTime_7() const { return ___startTime_7; }
	inline float* get_address_of_startTime_7() { return &___startTime_7; }
	inline void set_startTime_7(float value)
	{
		___startTime_7 = value;
	}

	inline static int32_t get_offset_of_isTimeUp_8() { return static_cast<int32_t>(offsetof(BubblesGame_t770340633, ___isTimeUp_8)); }
	inline bool get_isTimeUp_8() const { return ___isTimeUp_8; }
	inline bool* get_address_of_isTimeUp_8() { return &___isTimeUp_8; }
	inline void set_isTimeUp_8(bool value)
	{
		___isTimeUp_8 = value;
	}

	inline static int32_t get_offset_of_hasEndGamestarted_9() { return static_cast<int32_t>(offsetof(BubblesGame_t770340633, ___hasEndGamestarted_9)); }
	inline bool get_hasEndGamestarted_9() const { return ___hasEndGamestarted_9; }
	inline bool* get_address_of_hasEndGamestarted_9() { return &___hasEndGamestarted_9; }
	inline void set_hasEndGamestarted_9(bool value)
	{
		___hasEndGamestarted_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
