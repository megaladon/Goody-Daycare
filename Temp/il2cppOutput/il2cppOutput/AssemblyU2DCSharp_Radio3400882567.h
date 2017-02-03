#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// Radio/ClickAction
struct ClickAction_t355141910;
// System.String
struct String_t;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Radio
struct  Radio_t3400882567  : public MonoBehaviour_t1158329972
{
public:

public:
};

struct Radio_t3400882567_StaticFields
{
public:
	// Radio/ClickAction Radio::MusicPlaying
	ClickAction_t355141910 * ___MusicPlaying_2;
	// System.String Radio::currentSong
	String_t* ___currentSong_3;

public:
	inline static int32_t get_offset_of_MusicPlaying_2() { return static_cast<int32_t>(offsetof(Radio_t3400882567_StaticFields, ___MusicPlaying_2)); }
	inline ClickAction_t355141910 * get_MusicPlaying_2() const { return ___MusicPlaying_2; }
	inline ClickAction_t355141910 ** get_address_of_MusicPlaying_2() { return &___MusicPlaying_2; }
	inline void set_MusicPlaying_2(ClickAction_t355141910 * value)
	{
		___MusicPlaying_2 = value;
		Il2CppCodeGenWriteBarrier(&___MusicPlaying_2, value);
	}

	inline static int32_t get_offset_of_currentSong_3() { return static_cast<int32_t>(offsetof(Radio_t3400882567_StaticFields, ___currentSong_3)); }
	inline String_t* get_currentSong_3() const { return ___currentSong_3; }
	inline String_t** get_address_of_currentSong_3() { return &___currentSong_3; }
	inline void set_currentSong_3(String_t* value)
	{
		___currentSong_3 = value;
		Il2CppCodeGenWriteBarrier(&___currentSong_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
