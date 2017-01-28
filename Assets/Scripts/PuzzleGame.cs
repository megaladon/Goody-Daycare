using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGame : MonoBehaviour
{
	public GameObject yancy;
	private GameObject completedPuzzle;
	//public GameObject[] puzzles;
	private GameObject puzzleOutLine;
	//public GameObject puzzleOutlineHolder;
	public float puzzleOpacity;
	public GameObject[] fullPuzzles;

	public GameObject[] hotSpots;
	private GameObject[] puzzlePieces;
	public GameObject[] offPositions;

	public GameObject[] beachPieces;
	public GameObject[] underwaterPieces;
	public GameObject[] safariPieces;
	public GameObject[] firefighterPieces;

	private int puzzleNumber = 3;
	private List<GameObject> currentPuzzlePieces;



	private bool isDragging = false;
	private GameObject currentPuzzlePiece;
	private float currentPuzzlePieceStart = -2;
	private float draggingZ = 2f;
	private int puzzlesPlaced = 0;

	// Use this for initialization
	void Start ()
	{
		GameObject thisPuzzle = Instantiate (fullPuzzles [puzzleNumber], new Vector3 (6.25f, 2.82f, -2), Quaternion.identity) as GameObject;

		puzzlePieces = GameObject.FindGameObjectsWithTag ("PuzzlePiece");
		completedPuzzle = GameObject.FindGameObjectWithTag ("CompletedPuzzle");
		puzzleOutLine = GameObject.FindGameObjectWithTag ("PuzzleOutline");

		//completedPuzzle.GetComponent<SpriteRenderer> ().sprite = puzzles [puzzleNumber].GetComponent<SpriteRenderer> ().sprite;

		//puzzleOutlineHolder.GetComponent<SpriteRenderer> ().sprite = puzzleOutLines [puzzleNumber].GetComponent<SpriteRenderer> ().sprite;

		// Dim the completedPuzzle background
		Renderer completedPuzzleRenderer = completedPuzzle.GetComponent<Renderer> ();
		completedPuzzleRenderer.material.color = new Color (1.0f, 1.0f, 1.0f, puzzleOpacity);

		GameObject[] pieceSet;// = beachPieces;


		switch (puzzleNumber) {
		case 0:
			pieceSet = beachPieces;
			break;
		case 1:
			pieceSet = underwaterPieces;
			break;
		case 2:
			pieceSet = safariPieces;
			break;
		case 3:
			pieceSet = firefighterPieces;
			break;
		default:
			pieceSet = beachPieces;
			break;
		}


		currentPuzzlePieces = new List<GameObject> ();
		for (int j = 0; j < puzzlePieces.Length; j++) {
			currentPuzzlePieces.Add (puzzlePieces [j]);
		}


		for (int i = 0; i < 6; i++) {
			int positionNumber = puzzlePieces [i].GetComponent<PuzzlePiece> ().positionNumber;
			puzzlePieces [i].GetComponent<PuzzlePiece> ().InitPiece (pieceSet [positionNumber]);
		}

		Invoke ("BreakUpPuzzle", 2f);
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

	void BreakUpPuzzle ()
	{
		for (int i = 0; i < offPositions.Length; i++) {
			puzzlePieces [i].GetComponent<PuzzlePiece> ().SetOffPosition (offPositions [i].GetComponent<Transform> ().position);
			puzzlePieces [i].GetComponent<PuzzlePiece> ().ResetPiece ();
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
		//resetPuzzlePieceZ (currentPuzzlePiece, currentPuzzlePieceStart);
		drop ();

		currentPuzzlePiece = null;
	}


	void resetPuzzlePieceZ (GameObject puzzlePiece, float zPos)
	{
		Vector3 pos = puzzlePiece.GetComponent<Transform> ().position;
		pos.z = zPos;
		puzzlePiece.GetComponent<Transform> ().position = pos;
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
				placePuzzlePiece ();
			} else {
				resetWrongPiece ();
			}

			Debug.Log ("Check Distance " + distance + " hotSpot=" + hotSpot.GetComponent<Transform> ().position + " puzzlePiece=" + currentPuzzlePiece.GetComponent<Transform> ().position);
		}

	}

	private void placePuzzlePiece ()
	{
		puzzlesPlaced++;
		Animator anim = yancy.GetComponentInChildren<Animator> ();
		if (anim) {
			if (puzzlesPlaced < puzzlePieces.Length) {
				anim.SetTrigger ("caAnimation");	
			} else {
				anim.SetTrigger ("puzzleCompleteAnimation");
			}

		}
		currentPuzzlePiece.GetComponent<PuzzlePiece> ().SnapCorrect ();
		resetPuzzlePieceZ (currentPuzzlePiece, currentPuzzlePieceStart);
	}

	private void resetWrongPiece ()
	{
		Animator anim = yancy.GetComponentInChildren<Animator> ();
		if (anim) {
			anim.SetTrigger ("waAnimation");
		}
			
		currentPuzzlePiece.GetComponent<PuzzlePiece> ().ResetPiece ();
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
