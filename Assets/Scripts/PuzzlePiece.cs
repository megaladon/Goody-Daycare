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
	private Vector3 offPosition = new Vector3 (0, 0, 0);
	private bool isResetting = false;

	// Use this for initialization
	void Start ()
	{
		correctPosition = gameObject.GetComponent<Transform> ().position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (isResetting) {
			float step = 10 * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, offPosition, step);	
		}

		if (isResetting && transform.position == offPosition) {
			Debug.Log ("Done resetting ******* " + offPosition);
			isResetting = false;
		}

	}

	void OnMouseDown ()
	{
		puzzleGame.startDrag (gameObject);
		Animator anim = GetComponentInChildren<Animator> ();
		if (anim)
			anim.SetTrigger ("StartDrag");
	}

	void OnMouseUp ()
	{
		puzzleGame.stopDrag ();
	}

	public void SnapCorrect ()
	{
		gameObject.GetComponent<Transform> ().position = correctPosition;
	}

	public void SetOffPosition (Vector3 pos)
	{
		offPosition = pos;
	}

	public void ResetPiece ()
	{
		isResetting = true;
		Animator anim = GetComponentInChildren<Animator> ();
		if (anim) {
			anim.SetTrigger ("ResetPiece");
		}
	}

}
