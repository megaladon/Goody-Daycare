using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script is attached to each puzzle piece 
 */


public class PuzzlePiece : MonoBehaviour
{
	public PuzzleGame puzzleGame;

	// Use this for initialization
	void Start ()
	{
		
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


}
