#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Animator
struct Animator_t69676727;
// UnityEngine.Sprite
struct Sprite_t309593783;
// BubblesGame
struct BubblesGame_t770340633;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// BubbleBehavior
struct  BubbleBehavior_t2953284492  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Animator BubbleBehavior::anim
	Animator_t69676727 * ___anim_2;
	// UnityEngine.Sprite BubbleBehavior::animSprite
	Sprite_t309593783 * ___animSprite_3;
	// UnityEngine.Sprite BubbleBehavior::updateSprite
	Sprite_t309593783 * ___updateSprite_4;
	// System.Boolean BubbleBehavior::isCurrentCAShape
	bool ___isCurrentCAShape_5;
	// BubblesGame BubbleBehavior::bubblesGame
	BubblesGame_t770340633 * ___bubblesGame_6;

public:
	inline static int32_t get_offset_of_anim_2() { return static_cast<int32_t>(offsetof(BubbleBehavior_t2953284492, ___anim_2)); }
	inline Animator_t69676727 * get_anim_2() const { return ___anim_2; }
	inline Animator_t69676727 ** get_address_of_anim_2() { return &___anim_2; }
	inline void set_anim_2(Animator_t69676727 * value)
	{
		___anim_2 = value;
		Il2CppCodeGenWriteBarrier(&___anim_2, value);
	}

	inline static int32_t get_offset_of_animSprite_3() { return static_cast<int32_t>(offsetof(BubbleBehavior_t2953284492, ___animSprite_3)); }
	inline Sprite_t309593783 * get_animSprite_3() const { return ___animSprite_3; }
	inline Sprite_t309593783 ** get_address_of_animSprite_3() { return &___animSprite_3; }
	inline void set_animSprite_3(Sprite_t309593783 * value)
	{
		___animSprite_3 = value;
		Il2CppCodeGenWriteBarrier(&___animSprite_3, value);
	}

	inline static int32_t get_offset_of_updateSprite_4() { return static_cast<int32_t>(offsetof(BubbleBehavior_t2953284492, ___updateSprite_4)); }
	inline Sprite_t309593783 * get_updateSprite_4() const { return ___updateSprite_4; }
	inline Sprite_t309593783 ** get_address_of_updateSprite_4() { return &___updateSprite_4; }
	inline void set_updateSprite_4(Sprite_t309593783 * value)
	{
		___updateSprite_4 = value;
		Il2CppCodeGenWriteBarrier(&___updateSprite_4, value);
	}

	inline static int32_t get_offset_of_isCurrentCAShape_5() { return static_cast<int32_t>(offsetof(BubbleBehavior_t2953284492, ___isCurrentCAShape_5)); }
	inline bool get_isCurrentCAShape_5() const { return ___isCurrentCAShape_5; }
	inline bool* get_address_of_isCurrentCAShape_5() { return &___isCurrentCAShape_5; }
	inline void set_isCurrentCAShape_5(bool value)
	{
		___isCurrentCAShape_5 = value;
	}

	inline static int32_t get_offset_of_bubblesGame_6() { return static_cast<int32_t>(offsetof(BubbleBehavior_t2953284492, ___bubblesGame_6)); }
	inline BubblesGame_t770340633 * get_bubblesGame_6() const { return ___bubblesGame_6; }
	inline BubblesGame_t770340633 ** get_address_of_bubblesGame_6() { return &___bubblesGame_6; }
	inline void set_bubblesGame_6(BubblesGame_t770340633 * value)
	{
		___bubblesGame_6 = value;
		Il2CppCodeGenWriteBarrier(&___bubblesGame_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
