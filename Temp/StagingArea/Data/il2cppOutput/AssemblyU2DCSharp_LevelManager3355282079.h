#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "AssemblyU2DCSharp_LevelManager_levelNames883600344.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// LevelManager
struct  LevelManager_t3355282079  : public MonoBehaviour_t1158329972
{
public:
	// System.Single LevelManager::autoLoadNextLevelAfter
	float ___autoLoadNextLevelAfter_2;
	// LevelManager/levelNames LevelManager::level
	int32_t ___level_3;
	// System.Int32 LevelManager::shapeGameEnterCount
	int32_t ___shapeGameEnterCount_4;
	// System.Int32 LevelManager::bubblesGameEnterCount
	int32_t ___bubblesGameEnterCount_5;
	// System.Int32 LevelManager::roundNum
	int32_t ___roundNum_6;

public:
	inline static int32_t get_offset_of_autoLoadNextLevelAfter_2() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___autoLoadNextLevelAfter_2)); }
	inline float get_autoLoadNextLevelAfter_2() const { return ___autoLoadNextLevelAfter_2; }
	inline float* get_address_of_autoLoadNextLevelAfter_2() { return &___autoLoadNextLevelAfter_2; }
	inline void set_autoLoadNextLevelAfter_2(float value)
	{
		___autoLoadNextLevelAfter_2 = value;
	}

	inline static int32_t get_offset_of_level_3() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___level_3)); }
	inline int32_t get_level_3() const { return ___level_3; }
	inline int32_t* get_address_of_level_3() { return &___level_3; }
	inline void set_level_3(int32_t value)
	{
		___level_3 = value;
	}

	inline static int32_t get_offset_of_shapeGameEnterCount_4() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___shapeGameEnterCount_4)); }
	inline int32_t get_shapeGameEnterCount_4() const { return ___shapeGameEnterCount_4; }
	inline int32_t* get_address_of_shapeGameEnterCount_4() { return &___shapeGameEnterCount_4; }
	inline void set_shapeGameEnterCount_4(int32_t value)
	{
		___shapeGameEnterCount_4 = value;
	}

	inline static int32_t get_offset_of_bubblesGameEnterCount_5() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___bubblesGameEnterCount_5)); }
	inline int32_t get_bubblesGameEnterCount_5() const { return ___bubblesGameEnterCount_5; }
	inline int32_t* get_address_of_bubblesGameEnterCount_5() { return &___bubblesGameEnterCount_5; }
	inline void set_bubblesGameEnterCount_5(int32_t value)
	{
		___bubblesGameEnterCount_5 = value;
	}

	inline static int32_t get_offset_of_roundNum_6() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___roundNum_6)); }
	inline int32_t get_roundNum_6() const { return ___roundNum_6; }
	inline int32_t* get_address_of_roundNum_6() { return &___roundNum_6; }
	inline void set_roundNum_6(int32_t value)
	{
		___roundNum_6 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
