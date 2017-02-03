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
// UnityEngine.Animator
struct Animator_t69676727;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ShapeBehavior
struct  ShapeBehavior_t1433886141  : public MonoBehaviour_t1158329972
{
public:
	// System.Boolean ShapeBehavior::isCurrentCAShape
	bool ___isCurrentCAShape_2;
	// UnityEngine.GameObject ShapeBehavior::shape
	GameObject_t1756533147 * ___shape_3;
	// UnityEngine.Animator ShapeBehavior::anim
	Animator_t69676727 * ___anim_4;

public:
	inline static int32_t get_offset_of_isCurrentCAShape_2() { return static_cast<int32_t>(offsetof(ShapeBehavior_t1433886141, ___isCurrentCAShape_2)); }
	inline bool get_isCurrentCAShape_2() const { return ___isCurrentCAShape_2; }
	inline bool* get_address_of_isCurrentCAShape_2() { return &___isCurrentCAShape_2; }
	inline void set_isCurrentCAShape_2(bool value)
	{
		___isCurrentCAShape_2 = value;
	}

	inline static int32_t get_offset_of_shape_3() { return static_cast<int32_t>(offsetof(ShapeBehavior_t1433886141, ___shape_3)); }
	inline GameObject_t1756533147 * get_shape_3() const { return ___shape_3; }
	inline GameObject_t1756533147 ** get_address_of_shape_3() { return &___shape_3; }
	inline void set_shape_3(GameObject_t1756533147 * value)
	{
		___shape_3 = value;
		Il2CppCodeGenWriteBarrier(&___shape_3, value);
	}

	inline static int32_t get_offset_of_anim_4() { return static_cast<int32_t>(offsetof(ShapeBehavior_t1433886141, ___anim_4)); }
	inline Animator_t69676727 * get_anim_4() const { return ___anim_4; }
	inline Animator_t69676727 ** get_address_of_anim_4() { return &___anim_4; }
	inline void set_anim_4(Animator_t69676727 * value)
	{
		___anim_4 = value;
		Il2CppCodeGenWriteBarrier(&___anim_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
