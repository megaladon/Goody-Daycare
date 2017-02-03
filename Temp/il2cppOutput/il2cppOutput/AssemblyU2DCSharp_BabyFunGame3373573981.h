#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.AudioSource[]
struct AudioSourceU5BU5D_t1873220070;
// UnityEngine.GameObject
struct GameObject_t1756533147;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// BabyFunGame
struct  BabyFunGame_t3373573981  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.AudioSource[] BabyFunGame::audioSource
	AudioSourceU5BU5D_t1873220070* ___audioSource_2;
	// UnityEngine.GameObject BabyFunGame::titleHolder
	GameObject_t1756533147 * ___titleHolder_3;
	// UnityEngine.GameObject BabyFunGame::mainAnimation
	GameObject_t1756533147 * ___mainAnimation_4;

public:
	inline static int32_t get_offset_of_audioSource_2() { return static_cast<int32_t>(offsetof(BabyFunGame_t3373573981, ___audioSource_2)); }
	inline AudioSourceU5BU5D_t1873220070* get_audioSource_2() const { return ___audioSource_2; }
	inline AudioSourceU5BU5D_t1873220070** get_address_of_audioSource_2() { return &___audioSource_2; }
	inline void set_audioSource_2(AudioSourceU5BU5D_t1873220070* value)
	{
		___audioSource_2 = value;
		Il2CppCodeGenWriteBarrier(&___audioSource_2, value);
	}

	inline static int32_t get_offset_of_titleHolder_3() { return static_cast<int32_t>(offsetof(BabyFunGame_t3373573981, ___titleHolder_3)); }
	inline GameObject_t1756533147 * get_titleHolder_3() const { return ___titleHolder_3; }
	inline GameObject_t1756533147 ** get_address_of_titleHolder_3() { return &___titleHolder_3; }
	inline void set_titleHolder_3(GameObject_t1756533147 * value)
	{
		___titleHolder_3 = value;
		Il2CppCodeGenWriteBarrier(&___titleHolder_3, value);
	}

	inline static int32_t get_offset_of_mainAnimation_4() { return static_cast<int32_t>(offsetof(BabyFunGame_t3373573981, ___mainAnimation_4)); }
	inline GameObject_t1756533147 * get_mainAnimation_4() const { return ___mainAnimation_4; }
	inline GameObject_t1756533147 ** get_address_of_mainAnimation_4() { return &___mainAnimation_4; }
	inline void set_mainAnimation_4(GameObject_t1756533147 * value)
	{
		___mainAnimation_4 = value;
		Il2CppCodeGenWriteBarrier(&___mainAnimation_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
