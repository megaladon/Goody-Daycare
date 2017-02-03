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
// LevelManager
struct LevelManager_t3355282079;
// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3057952154;
// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_t1125654279;
// UnityEngine.Renderer
struct Renderer_t257310565;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Color2020392075.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// PuzzleGame
struct  PuzzleGame_t1068893802  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject PuzzleGame::yancy
	GameObject_t1756533147 * ___yancy_2;
	// System.Boolean PuzzleGame::isPuzzleReady
	bool ___isPuzzleReady_3;
	// UnityEngine.GameObject PuzzleGame::completedPuzzle
	GameObject_t1756533147 * ___completedPuzzle_4;
	// System.Int32 PuzzleGame::puzzlePiecesReady
	int32_t ___puzzlePiecesReady_5;
	// UnityEngine.GameObject PuzzleGame::puzzleOutLine
	GameObject_t1756533147 * ___puzzleOutLine_6;
	// LevelManager PuzzleGame::levelManager
	LevelManager_t3355282079 * ___levelManager_7;
	// System.Single PuzzleGame::puzzleOpacity
	float ___puzzleOpacity_8;
	// UnityEngine.GameObject[] PuzzleGame::fullPuzzles
	GameObjectU5BU5D_t3057952154* ___fullPuzzles_9;
	// UnityEngine.GameObject[] PuzzleGame::hotSpots
	GameObjectU5BU5D_t3057952154* ___hotSpots_10;
	// UnityEngine.GameObject[] PuzzleGame::puzzlePieces
	GameObjectU5BU5D_t3057952154* ___puzzlePieces_11;
	// UnityEngine.GameObject[] PuzzleGame::offPositions
	GameObjectU5BU5D_t3057952154* ___offPositions_12;
	// UnityEngine.GameObject[] PuzzleGame::beachPieces
	GameObjectU5BU5D_t3057952154* ___beachPieces_13;
	// UnityEngine.GameObject[] PuzzleGame::underwaterPieces
	GameObjectU5BU5D_t3057952154* ___underwaterPieces_14;
	// UnityEngine.GameObject[] PuzzleGame::safariPieces
	GameObjectU5BU5D_t3057952154* ___safariPieces_15;
	// UnityEngine.GameObject[] PuzzleGame::firefighterPieces
	GameObjectU5BU5D_t3057952154* ___firefighterPieces_16;
	// System.Int32 PuzzleGame::puzzleNumber
	int32_t ___puzzleNumber_17;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> PuzzleGame::currentPuzzlePieces
	List_1_t1125654279 * ___currentPuzzlePieces_18;
	// System.Boolean PuzzleGame::isDragging
	bool ___isDragging_19;
	// UnityEngine.GameObject PuzzleGame::currentPuzzlePiece
	GameObject_t1756533147 * ___currentPuzzlePiece_20;
	// System.Single PuzzleGame::currentPuzzlePieceStart
	float ___currentPuzzlePieceStart_21;
	// System.Single PuzzleGame::draggingZ
	float ___draggingZ_22;
	// System.Int32 PuzzleGame::puzzlesPlaced
	int32_t ___puzzlesPlaced_23;
	// UnityEngine.Renderer PuzzleGame::outlineRender
	Renderer_t257310565 * ___outlineRender_24;
	// UnityEngine.Renderer PuzzleGame::completedPuzzleRenderer
	Renderer_t257310565 * ___completedPuzzleRenderer_25;
	// System.Boolean PuzzleGame::isFaddingOutline
	bool ___isFaddingOutline_26;
	// UnityEngine.Color PuzzleGame::currentOutlineColor
	Color_t2020392075  ___currentOutlineColor_27;

public:
	inline static int32_t get_offset_of_yancy_2() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___yancy_2)); }
	inline GameObject_t1756533147 * get_yancy_2() const { return ___yancy_2; }
	inline GameObject_t1756533147 ** get_address_of_yancy_2() { return &___yancy_2; }
	inline void set_yancy_2(GameObject_t1756533147 * value)
	{
		___yancy_2 = value;
		Il2CppCodeGenWriteBarrier(&___yancy_2, value);
	}

	inline static int32_t get_offset_of_isPuzzleReady_3() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___isPuzzleReady_3)); }
	inline bool get_isPuzzleReady_3() const { return ___isPuzzleReady_3; }
	inline bool* get_address_of_isPuzzleReady_3() { return &___isPuzzleReady_3; }
	inline void set_isPuzzleReady_3(bool value)
	{
		___isPuzzleReady_3 = value;
	}

	inline static int32_t get_offset_of_completedPuzzle_4() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___completedPuzzle_4)); }
	inline GameObject_t1756533147 * get_completedPuzzle_4() const { return ___completedPuzzle_4; }
	inline GameObject_t1756533147 ** get_address_of_completedPuzzle_4() { return &___completedPuzzle_4; }
	inline void set_completedPuzzle_4(GameObject_t1756533147 * value)
	{
		___completedPuzzle_4 = value;
		Il2CppCodeGenWriteBarrier(&___completedPuzzle_4, value);
	}

	inline static int32_t get_offset_of_puzzlePiecesReady_5() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___puzzlePiecesReady_5)); }
	inline int32_t get_puzzlePiecesReady_5() const { return ___puzzlePiecesReady_5; }
	inline int32_t* get_address_of_puzzlePiecesReady_5() { return &___puzzlePiecesReady_5; }
	inline void set_puzzlePiecesReady_5(int32_t value)
	{
		___puzzlePiecesReady_5 = value;
	}

	inline static int32_t get_offset_of_puzzleOutLine_6() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___puzzleOutLine_6)); }
	inline GameObject_t1756533147 * get_puzzleOutLine_6() const { return ___puzzleOutLine_6; }
	inline GameObject_t1756533147 ** get_address_of_puzzleOutLine_6() { return &___puzzleOutLine_6; }
	inline void set_puzzleOutLine_6(GameObject_t1756533147 * value)
	{
		___puzzleOutLine_6 = value;
		Il2CppCodeGenWriteBarrier(&___puzzleOutLine_6, value);
	}

	inline static int32_t get_offset_of_levelManager_7() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___levelManager_7)); }
	inline LevelManager_t3355282079 * get_levelManager_7() const { return ___levelManager_7; }
	inline LevelManager_t3355282079 ** get_address_of_levelManager_7() { return &___levelManager_7; }
	inline void set_levelManager_7(LevelManager_t3355282079 * value)
	{
		___levelManager_7 = value;
		Il2CppCodeGenWriteBarrier(&___levelManager_7, value);
	}

	inline static int32_t get_offset_of_puzzleOpacity_8() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___puzzleOpacity_8)); }
	inline float get_puzzleOpacity_8() const { return ___puzzleOpacity_8; }
	inline float* get_address_of_puzzleOpacity_8() { return &___puzzleOpacity_8; }
	inline void set_puzzleOpacity_8(float value)
	{
		___puzzleOpacity_8 = value;
	}

	inline static int32_t get_offset_of_fullPuzzles_9() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___fullPuzzles_9)); }
	inline GameObjectU5BU5D_t3057952154* get_fullPuzzles_9() const { return ___fullPuzzles_9; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_fullPuzzles_9() { return &___fullPuzzles_9; }
	inline void set_fullPuzzles_9(GameObjectU5BU5D_t3057952154* value)
	{
		___fullPuzzles_9 = value;
		Il2CppCodeGenWriteBarrier(&___fullPuzzles_9, value);
	}

	inline static int32_t get_offset_of_hotSpots_10() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___hotSpots_10)); }
	inline GameObjectU5BU5D_t3057952154* get_hotSpots_10() const { return ___hotSpots_10; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_hotSpots_10() { return &___hotSpots_10; }
	inline void set_hotSpots_10(GameObjectU5BU5D_t3057952154* value)
	{
		___hotSpots_10 = value;
		Il2CppCodeGenWriteBarrier(&___hotSpots_10, value);
	}

	inline static int32_t get_offset_of_puzzlePieces_11() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___puzzlePieces_11)); }
	inline GameObjectU5BU5D_t3057952154* get_puzzlePieces_11() const { return ___puzzlePieces_11; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_puzzlePieces_11() { return &___puzzlePieces_11; }
	inline void set_puzzlePieces_11(GameObjectU5BU5D_t3057952154* value)
	{
		___puzzlePieces_11 = value;
		Il2CppCodeGenWriteBarrier(&___puzzlePieces_11, value);
	}

	inline static int32_t get_offset_of_offPositions_12() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___offPositions_12)); }
	inline GameObjectU5BU5D_t3057952154* get_offPositions_12() const { return ___offPositions_12; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_offPositions_12() { return &___offPositions_12; }
	inline void set_offPositions_12(GameObjectU5BU5D_t3057952154* value)
	{
		___offPositions_12 = value;
		Il2CppCodeGenWriteBarrier(&___offPositions_12, value);
	}

	inline static int32_t get_offset_of_beachPieces_13() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___beachPieces_13)); }
	inline GameObjectU5BU5D_t3057952154* get_beachPieces_13() const { return ___beachPieces_13; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_beachPieces_13() { return &___beachPieces_13; }
	inline void set_beachPieces_13(GameObjectU5BU5D_t3057952154* value)
	{
		___beachPieces_13 = value;
		Il2CppCodeGenWriteBarrier(&___beachPieces_13, value);
	}

	inline static int32_t get_offset_of_underwaterPieces_14() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___underwaterPieces_14)); }
	inline GameObjectU5BU5D_t3057952154* get_underwaterPieces_14() const { return ___underwaterPieces_14; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_underwaterPieces_14() { return &___underwaterPieces_14; }
	inline void set_underwaterPieces_14(GameObjectU5BU5D_t3057952154* value)
	{
		___underwaterPieces_14 = value;
		Il2CppCodeGenWriteBarrier(&___underwaterPieces_14, value);
	}

	inline static int32_t get_offset_of_safariPieces_15() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___safariPieces_15)); }
	inline GameObjectU5BU5D_t3057952154* get_safariPieces_15() const { return ___safariPieces_15; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_safariPieces_15() { return &___safariPieces_15; }
	inline void set_safariPieces_15(GameObjectU5BU5D_t3057952154* value)
	{
		___safariPieces_15 = value;
		Il2CppCodeGenWriteBarrier(&___safariPieces_15, value);
	}

	inline static int32_t get_offset_of_firefighterPieces_16() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___firefighterPieces_16)); }
	inline GameObjectU5BU5D_t3057952154* get_firefighterPieces_16() const { return ___firefighterPieces_16; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_firefighterPieces_16() { return &___firefighterPieces_16; }
	inline void set_firefighterPieces_16(GameObjectU5BU5D_t3057952154* value)
	{
		___firefighterPieces_16 = value;
		Il2CppCodeGenWriteBarrier(&___firefighterPieces_16, value);
	}

	inline static int32_t get_offset_of_puzzleNumber_17() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___puzzleNumber_17)); }
	inline int32_t get_puzzleNumber_17() const { return ___puzzleNumber_17; }
	inline int32_t* get_address_of_puzzleNumber_17() { return &___puzzleNumber_17; }
	inline void set_puzzleNumber_17(int32_t value)
	{
		___puzzleNumber_17 = value;
	}

	inline static int32_t get_offset_of_currentPuzzlePieces_18() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___currentPuzzlePieces_18)); }
	inline List_1_t1125654279 * get_currentPuzzlePieces_18() const { return ___currentPuzzlePieces_18; }
	inline List_1_t1125654279 ** get_address_of_currentPuzzlePieces_18() { return &___currentPuzzlePieces_18; }
	inline void set_currentPuzzlePieces_18(List_1_t1125654279 * value)
	{
		___currentPuzzlePieces_18 = value;
		Il2CppCodeGenWriteBarrier(&___currentPuzzlePieces_18, value);
	}

	inline static int32_t get_offset_of_isDragging_19() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___isDragging_19)); }
	inline bool get_isDragging_19() const { return ___isDragging_19; }
	inline bool* get_address_of_isDragging_19() { return &___isDragging_19; }
	inline void set_isDragging_19(bool value)
	{
		___isDragging_19 = value;
	}

	inline static int32_t get_offset_of_currentPuzzlePiece_20() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___currentPuzzlePiece_20)); }
	inline GameObject_t1756533147 * get_currentPuzzlePiece_20() const { return ___currentPuzzlePiece_20; }
	inline GameObject_t1756533147 ** get_address_of_currentPuzzlePiece_20() { return &___currentPuzzlePiece_20; }
	inline void set_currentPuzzlePiece_20(GameObject_t1756533147 * value)
	{
		___currentPuzzlePiece_20 = value;
		Il2CppCodeGenWriteBarrier(&___currentPuzzlePiece_20, value);
	}

	inline static int32_t get_offset_of_currentPuzzlePieceStart_21() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___currentPuzzlePieceStart_21)); }
	inline float get_currentPuzzlePieceStart_21() const { return ___currentPuzzlePieceStart_21; }
	inline float* get_address_of_currentPuzzlePieceStart_21() { return &___currentPuzzlePieceStart_21; }
	inline void set_currentPuzzlePieceStart_21(float value)
	{
		___currentPuzzlePieceStart_21 = value;
	}

	inline static int32_t get_offset_of_draggingZ_22() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___draggingZ_22)); }
	inline float get_draggingZ_22() const { return ___draggingZ_22; }
	inline float* get_address_of_draggingZ_22() { return &___draggingZ_22; }
	inline void set_draggingZ_22(float value)
	{
		___draggingZ_22 = value;
	}

	inline static int32_t get_offset_of_puzzlesPlaced_23() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___puzzlesPlaced_23)); }
	inline int32_t get_puzzlesPlaced_23() const { return ___puzzlesPlaced_23; }
	inline int32_t* get_address_of_puzzlesPlaced_23() { return &___puzzlesPlaced_23; }
	inline void set_puzzlesPlaced_23(int32_t value)
	{
		___puzzlesPlaced_23 = value;
	}

	inline static int32_t get_offset_of_outlineRender_24() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___outlineRender_24)); }
	inline Renderer_t257310565 * get_outlineRender_24() const { return ___outlineRender_24; }
	inline Renderer_t257310565 ** get_address_of_outlineRender_24() { return &___outlineRender_24; }
	inline void set_outlineRender_24(Renderer_t257310565 * value)
	{
		___outlineRender_24 = value;
		Il2CppCodeGenWriteBarrier(&___outlineRender_24, value);
	}

	inline static int32_t get_offset_of_completedPuzzleRenderer_25() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___completedPuzzleRenderer_25)); }
	inline Renderer_t257310565 * get_completedPuzzleRenderer_25() const { return ___completedPuzzleRenderer_25; }
	inline Renderer_t257310565 ** get_address_of_completedPuzzleRenderer_25() { return &___completedPuzzleRenderer_25; }
	inline void set_completedPuzzleRenderer_25(Renderer_t257310565 * value)
	{
		___completedPuzzleRenderer_25 = value;
		Il2CppCodeGenWriteBarrier(&___completedPuzzleRenderer_25, value);
	}

	inline static int32_t get_offset_of_isFaddingOutline_26() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___isFaddingOutline_26)); }
	inline bool get_isFaddingOutline_26() const { return ___isFaddingOutline_26; }
	inline bool* get_address_of_isFaddingOutline_26() { return &___isFaddingOutline_26; }
	inline void set_isFaddingOutline_26(bool value)
	{
		___isFaddingOutline_26 = value;
	}

	inline static int32_t get_offset_of_currentOutlineColor_27() { return static_cast<int32_t>(offsetof(PuzzleGame_t1068893802, ___currentOutlineColor_27)); }
	inline Color_t2020392075  get_currentOutlineColor_27() const { return ___currentOutlineColor_27; }
	inline Color_t2020392075 * get_address_of_currentOutlineColor_27() { return &___currentOutlineColor_27; }
	inline void set_currentOutlineColor_27(Color_t2020392075  value)
	{
		___currentOutlineColor_27 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
