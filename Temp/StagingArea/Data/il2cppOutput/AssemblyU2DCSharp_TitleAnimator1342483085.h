#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Sprite
struct Sprite_t309593783;
// UnityEngine.AudioClip
struct AudioClip_t1932558630;
// UnityEngine.AudioSource[]
struct AudioSourceU5BU5D_t1873220070;
// BabyFunGame
struct BabyFunGame_t3373573981;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// TitleAnimator
struct  TitleAnimator_t1342483085  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Sprite TitleAnimator::newSprite
	Sprite_t309593783 * ___newSprite_2;
	// UnityEngine.AudioClip TitleAnimator::clip
	AudioClip_t1932558630 * ___clip_3;
	// System.Single TitleAnimator::titleInDoneDelay
	float ___titleInDoneDelay_4;
	// System.Single TitleAnimator::titleOutDoneDelay
	float ___titleOutDoneDelay_5;
	// UnityEngine.AudioSource[] TitleAnimator::audioSource
	AudioSourceU5BU5D_t1873220070* ___audioSource_6;
	// BabyFunGame TitleAnimator::babyFunGame
	BabyFunGame_t3373573981 * ___babyFunGame_7;

public:
	inline static int32_t get_offset_of_newSprite_2() { return static_cast<int32_t>(offsetof(TitleAnimator_t1342483085, ___newSprite_2)); }
	inline Sprite_t309593783 * get_newSprite_2() const { return ___newSprite_2; }
	inline Sprite_t309593783 ** get_address_of_newSprite_2() { return &___newSprite_2; }
	inline void set_newSprite_2(Sprite_t309593783 * value)
	{
		___newSprite_2 = value;
		Il2CppCodeGenWriteBarrier(&___newSprite_2, value);
	}

	inline static int32_t get_offset_of_clip_3() { return static_cast<int32_t>(offsetof(TitleAnimator_t1342483085, ___clip_3)); }
	inline AudioClip_t1932558630 * get_clip_3() const { return ___clip_3; }
	inline AudioClip_t1932558630 ** get_address_of_clip_3() { return &___clip_3; }
	inline void set_clip_3(AudioClip_t1932558630 * value)
	{
		___clip_3 = value;
		Il2CppCodeGenWriteBarrier(&___clip_3, value);
	}

	inline static int32_t get_offset_of_titleInDoneDelay_4() { return static_cast<int32_t>(offsetof(TitleAnimator_t1342483085, ___titleInDoneDelay_4)); }
	inline float get_titleInDoneDelay_4() const { return ___titleInDoneDelay_4; }
	inline float* get_address_of_titleInDoneDelay_4() { return &___titleInDoneDelay_4; }
	inline void set_titleInDoneDelay_4(float value)
	{
		___titleInDoneDelay_4 = value;
	}

	inline static int32_t get_offset_of_titleOutDoneDelay_5() { return static_cast<int32_t>(offsetof(TitleAnimator_t1342483085, ___titleOutDoneDelay_5)); }
	inline float get_titleOutDoneDelay_5() const { return ___titleOutDoneDelay_5; }
	inline float* get_address_of_titleOutDoneDelay_5() { return &___titleOutDoneDelay_5; }
	inline void set_titleOutDoneDelay_5(float value)
	{
		___titleOutDoneDelay_5 = value;
	}

	inline static int32_t get_offset_of_audioSource_6() { return static_cast<int32_t>(offsetof(TitleAnimator_t1342483085, ___audioSource_6)); }
	inline AudioSourceU5BU5D_t1873220070* get_audioSource_6() const { return ___audioSource_6; }
	inline AudioSourceU5BU5D_t1873220070** get_address_of_audioSource_6() { return &___audioSource_6; }
	inline void set_audioSource_6(AudioSourceU5BU5D_t1873220070* value)
	{
		___audioSource_6 = value;
		Il2CppCodeGenWriteBarrier(&___audioSource_6, value);
	}

	inline static int32_t get_offset_of_babyFunGame_7() { return static_cast<int32_t>(offsetof(TitleAnimator_t1342483085, ___babyFunGame_7)); }
	inline BabyFunGame_t3373573981 * get_babyFunGame_7() const { return ___babyFunGame_7; }
	inline BabyFunGame_t3373573981 ** get_address_of_babyFunGame_7() { return &___babyFunGame_7; }
	inline void set_babyFunGame_7(BabyFunGame_t3373573981 * value)
	{
		___babyFunGame_7 = value;
		Il2CppCodeGenWriteBarrier(&___babyFunGame_7, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
