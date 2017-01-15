using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script is attached to each puzzle piece 
 */


public class PuzzlePiece : MonoBehaviour
{
	public PuzzleGame puzzleGame;
	public int positionNumber;
	private Vector3 correctPosition = new Vector3 (0, 0, 0);

	// Use this for initialization
	void Start ()
	{
		correctPosition = gameObject.GetComponent<Transform> ().position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnMouseDown ()
	{
		puzzleGame.startDrag (gameObject);
	}

	void OnMouseUp ()
	{
		puzzleGame.stopDrag ();
	}

	public void SnapCorrect ()
	{
		gameObject.GetComponent<Transform> ().position = correctPosition;
	}


}
