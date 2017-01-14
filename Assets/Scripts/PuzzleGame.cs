using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGame : MonoBehaviour
{
	bool isDragging = false;
	GameObject currentPuzzlePiece;
	float currentPuzzlePieceStart = -2;
	float draggingZ = 2f;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (isDragging) {
			Debug.Log ("Dragging start " + currentPuzzlePiece.GetComponent<Transform> ().position.z + " " + Camera.main.transform.position.z);


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
		Vector3 pos = currentPuzzlePiece.GetComponent<Transform> ().position;
		pos.z = currentPuzzlePieceStart;
		currentPuzzlePiece.GetComponent<Transform> ().position = pos;
		currentPuzzlePiece = null;
	}

	public void Drag (GameObject puzzlePiece)
	{
		//if (puzzlePiece){}

		Vector3 newVec = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, -3.6f);
		puzzlePiece.GetComponent<Transform> ().position = newVec;
		Debug.Log ("Dragging " + newVec);
	}
}
