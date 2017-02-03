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
#include "AssemblyU2DCSharp_Kid_kidsNames559882320.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Kid
struct  Kid_t3906689168  : public MonoBehaviour_t1158329972
{
public:
	// System.String Kid::levelToLoad
	String_t* ___levelToLoad_2;
	// System.String Kid::myFavoriteSong
	String_t* ___myFavoriteSong_3;
	// Kid/kidsNames Kid::myName
	int32_t ___myName_4;

public:
	inline static int32_t get_offset_of_levelToLoad_2() { return static_cast<int32_t>(offsetof(Kid_t3906689168, ___levelToLoad_2)); }
	inline String_t* get_levelToLoad_2() const { return ___levelToLoad_2; }
	inline String_t** get_address_of_levelToLoad_2() { return &___levelToLoad_2; }
	inline void set_levelToLoad_2(String_t* value)
	{
		___levelToLoad_2 = value;
		Il2CppCodeGenWriteBarrier(&___levelToLoad_2, value);
	}

	inline static int32_t get_offset_of_myFavoriteSong_3() { return static_cast<int32_t>(offsetof(Kid_t3906689168, ___myFavoriteSong_3)); }
	inline String_t* get_myFavoriteSong_3() const { return ___myFavoriteSong_3; }
	inline String_t** get_address_of_myFavoriteSong_3() { return &___myFavoriteSong_3; }
	inline void set_myFavoriteSong_3(String_t* value)
	{
		___myFavoriteSong_3 = value;
		Il2CppCodeGenWriteBarrier(&___myFavoriteSong_3, value);
	}

	inline static int32_t get_offset_of_myName_4() { return static_cast<int32_t>(offsetof(Kid_t3906689168, ___myName_4)); }
	inline int32_t get_myName_4() const { return ___myName_4; }
	inline int32_t* get_address_of_myName_4() { return &___myName_4; }
	inline void set_myName_4(int32_t value)
	{
		___myName_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
