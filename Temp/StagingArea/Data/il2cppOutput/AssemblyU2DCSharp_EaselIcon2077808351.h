#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// System.String
struct String_t;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// EaselIcon
struct  EaselIcon_t2077808351  : public MonoBehaviour_t1158329972
{
public:
	// System.String EaselIcon::sceneToLoad
	String_t* ___sceneToLoad_2;

public:
	inline static int32_t get_offset_of_sceneToLoad_2() { return static_cast<int32_t>(offsetof(EaselIcon_t2077808351, ___sceneToLoad_2)); }
	inline String_t* get_sceneToLoad_2() const { return ___sceneToLoad_2; }
	inline String_t** get_address_of_sceneToLoad_2() { return &___sceneToLoad_2; }
	inline void set_sceneToLoad_2(String_t* value)
	{
		___sceneToLoad_2 = value;
		Il2CppCodeGenWriteBarrier(&___sceneToLoad_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
