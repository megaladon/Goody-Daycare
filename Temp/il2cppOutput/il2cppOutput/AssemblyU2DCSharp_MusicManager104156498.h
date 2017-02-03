#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.AudioClip[]
struct AudioClipU5BU5D_t2203355011;
// UnityEngine.AudioSource
struct AudioSource_t1135106623;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MusicManager
struct  MusicManager_t104156498  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.AudioClip[] MusicManager::levelMusicChangeArray
	AudioClipU5BU5D_t2203355011* ___levelMusicChangeArray_2;
	// UnityEngine.AudioSource MusicManager::audioSource
	AudioSource_t1135106623 * ___audioSource_3;

public:
	inline static int32_t get_offset_of_levelMusicChangeArray_2() { return static_cast<int32_t>(offsetof(MusicManager_t104156498, ___levelMusicChangeArray_2)); }
	inline AudioClipU5BU5D_t2203355011* get_levelMusicChangeArray_2() const { return ___levelMusicChangeArray_2; }
	inline AudioClipU5BU5D_t2203355011** get_address_of_levelMusicChangeArray_2() { return &___levelMusicChangeArray_2; }
	inline void set_levelMusicChangeArray_2(AudioClipU5BU5D_t2203355011* value)
	{
		___levelMusicChangeArray_2 = value;
		Il2CppCodeGenWriteBarrier(&___levelMusicChangeArray_2, value);
	}

	inline static int32_t get_offset_of_audioSource_3() { return static_cast<int32_t>(offsetof(MusicManager_t104156498, ___audioSource_3)); }
	inline AudioSource_t1135106623 * get_audioSource_3() const { return ___audioSource_3; }
	inline AudioSource_t1135106623 ** get_address_of_audioSource_3() { return &___audioSource_3; }
	inline void set_audioSource_3(AudioSource_t1135106623 * value)
	{
		___audioSource_3 = value;
		Il2CppCodeGenWriteBarrier(&___audioSource_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
