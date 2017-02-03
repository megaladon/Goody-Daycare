#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.UI.Slider
struct Slider_t297367283;
// LevelManager
struct LevelManager_t3355282079;
// MusicManager
struct MusicManager_t104156498;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// OptionsController
struct  OptionsController_t1206666438  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Slider OptionsController::volumerSlider
	Slider_t297367283 * ___volumerSlider_2;
	// UnityEngine.UI.Slider OptionsController::diffSlider
	Slider_t297367283 * ___diffSlider_3;
	// LevelManager OptionsController::levelManager
	LevelManager_t3355282079 * ___levelManager_4;
	// MusicManager OptionsController::musicManager
	MusicManager_t104156498 * ___musicManager_5;

public:
	inline static int32_t get_offset_of_volumerSlider_2() { return static_cast<int32_t>(offsetof(OptionsController_t1206666438, ___volumerSlider_2)); }
	inline Slider_t297367283 * get_volumerSlider_2() const { return ___volumerSlider_2; }
	inline Slider_t297367283 ** get_address_of_volumerSlider_2() { return &___volumerSlider_2; }
	inline void set_volumerSlider_2(Slider_t297367283 * value)
	{
		___volumerSlider_2 = value;
		Il2CppCodeGenWriteBarrier(&___volumerSlider_2, value);
	}

	inline static int32_t get_offset_of_diffSlider_3() { return static_cast<int32_t>(offsetof(OptionsController_t1206666438, ___diffSlider_3)); }
	inline Slider_t297367283 * get_diffSlider_3() const { return ___diffSlider_3; }
	inline Slider_t297367283 ** get_address_of_diffSlider_3() { return &___diffSlider_3; }
	inline void set_diffSlider_3(Slider_t297367283 * value)
	{
		___diffSlider_3 = value;
		Il2CppCodeGenWriteBarrier(&___diffSlider_3, value);
	}

	inline static int32_t get_offset_of_levelManager_4() { return static_cast<int32_t>(offsetof(OptionsController_t1206666438, ___levelManager_4)); }
	inline LevelManager_t3355282079 * get_levelManager_4() const { return ___levelManager_4; }
	inline LevelManager_t3355282079 ** get_address_of_levelManager_4() { return &___levelManager_4; }
	inline void set_levelManager_4(LevelManager_t3355282079 * value)
	{
		___levelManager_4 = value;
		Il2CppCodeGenWriteBarrier(&___levelManager_4, value);
	}

	inline static int32_t get_offset_of_musicManager_5() { return static_cast<int32_t>(offsetof(OptionsController_t1206666438, ___musicManager_5)); }
	inline MusicManager_t104156498 * get_musicManager_5() const { return ___musicManager_5; }
	inline MusicManager_t104156498 ** get_address_of_musicManager_5() { return &___musicManager_5; }
	inline void set_musicManager_5(MusicManager_t104156498 * value)
	{
		___musicManager_5 = value;
		Il2CppCodeGenWriteBarrier(&___musicManager_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
