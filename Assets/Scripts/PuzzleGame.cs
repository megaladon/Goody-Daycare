using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGame : MonoBehaviour
{
	public GameObject fullPuzzle;
	public GameObject puzzleOutLine;
	public float puzzleOpacity;
	public GameObject[] hotSpots;

	bool isDragging = false;
	GameObject currentPuzzlePiece;
	float currentPuzzlePieceStart = -2;
	float draggingZ = 2f;

	// Use this for initialization
	void Start ()
	{
		// Dim the fullPuzzle background
		Renderer fullPuzzleRenderer = fullPuzzle.GetComponent<Renderer> ();
		fullPuzzleRenderer.material.color = new Color (1.0f, 1.0f, 1.0f, puzzleOpacity);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (isDragging) {
			Vector3 pos = Input.mousePosition;
			pos.z = draggingZ;//currentPuzzlePiece.GetComponent<Transform> ().position.z - Camera.main.transform.position.z;
			currentPuzzlePiece.GetComponent<Transform> ().position = Camera.main.ScreenToWorldPoint (pos);
		}
	}

	public void startDrag (GameObject puzzlePiece)
	{
		isDragging = true;
		currentPuzzlePiece = puzzlePiece;
		currentPuzzlePieceStart = currentPuzzlePiece.GetComponent<Transform> ().position.z;
	}

	public void stopDrag ()
	{
		isDragging = false;
		// Reset puzzle piece to default z
		Vector3 pos = currentPuzzlePiece.GetComponent<Transform> ().position;
		pos.z = currentPuzzlePieceStart;
		currentPuzzlePiece.GetComponent<Transform> ().position = pos;
		drop ();

		currentPuzzlePiece = null;
	}

	private void drop ()
	{


		GameObject hotSpot = null;
		// Find the hot spot for this puzzle piece
		for (int i = 0; i < hotSpots.Length; i++) {
			GameObject tempHotSpot = hotSpots [i];
			if (tempHotSpot.GetComponent<PuzzleHotSpot> ().positionNumber == currentPuzzlePiece.GetComponent<PuzzlePiece> ().positionNumber) {
				hotSpot = hotSpots [i];	
			}
		}

		Debug.Log ("drop " + hotSpot.GetComponent<PuzzleHotSpot> ().positionNumber + " " + currentPuzzlePiece.GetComponent<PuzzlePiece> ().positionNumber);

		// Check the distance between puzzle piece and hotspot
		if (hotSpot.GetComponent<PuzzleHotSpot> ().positionNumber == currentPuzzlePiece.GetComponent<PuzzlePiece> ().positionNumber) {
			float distance = Vector2.Distance (hotSpot.GetComponent<Transform> ().position, currentPuzzlePiece.GetComponent<Transform> ().position);

			if (distance <= 0.767) {
				currentPuzzlePiece.GetComponent<PuzzlePiece> ().SnapCorrect ();
			}

			Debug.Log ("Check Distance " + distance + " hotSpot=" + hotSpot.GetComponent<Transform> ().position + " puzzlePiece=" + currentPuzzlePiece.GetComponent<Transform> ().position);
		}

	}

	private void placePuzzlePiece ()
	{
		
	}

	private void resetWrongPiece ()
	{
		
	}

	/*
	public void Drag (GameObject puzzlePiece)
	{
		//if (puzzlePiece){}

		Vector3 newVec = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, -3.6f);
		puzzlePiece.GetComponent<Transform> ().position = newVec;
		Debug.Log ("Dragging " + newVec);
	}
	*/
}
