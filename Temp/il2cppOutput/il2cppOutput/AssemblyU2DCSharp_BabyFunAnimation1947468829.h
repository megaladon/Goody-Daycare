#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// BabyFunGame
struct BabyFunGame_t3373573981;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// BabyFunAnimation
struct  BabyFunAnimation_t1947468829  : public MonoBehaviour_t1158329972
{
public:
	// BabyFunGame BabyFunAnimation::babyFunGame
	BabyFunGame_t3373573981 * ___babyFunGame_2;
	// System.Single BabyFunAnimation::animationDoneDelay
	float ___animationDoneDelay_3;

public:
	inline static int32_t get_offset_of_babyFunGame_2() { return static_cast<int32_t>(offsetof(BabyFunAnimation_t1947468829, ___babyFunGame_2)); }
	inline BabyFunGame_t3373573981 * get_babyFunGame_2() const { return ___babyFunGame_2; }
	inline BabyFunGame_t3373573981 ** get_address_of_babyFunGame_2() { return &___babyFunGame_2; }
	inline void set_babyFunGame_2(BabyFunGame_t3373573981 * value)
	{
		___babyFunGame_2 = value;
		Il2CppCodeGenWriteBarrier(&___babyFunGame_2, value);
	}

	inline static int32_t get_offset_of_animationDoneDelay_3() { return static_cast<int32_t>(offsetof(BabyFunAnimation_t1947468829, ___animationDoneDelay_3)); }
	inline float get_animationDoneDelay_3() const { return ___animationDoneDelay_3; }
	inline float* get_address_of_animationDoneDelay_3() { return &___animationDoneDelay_3; }
	inline void set_animationDoneDelay_3(float value)
	{
		___animationDoneDelay_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
