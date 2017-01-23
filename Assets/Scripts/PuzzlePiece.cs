using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script is attached to each puzzle piece 
 */


public class PuzzlePiece : MonoBehaviour
{
	private PuzzleGame puzzleGame;
	public int positionNumber;

	private GameObject puzzlePiece;
	private Vector3 correctPosition = new Vector3 (0, 0, 0);
	private Vector3 offPosition = new Vector3 (0, 0, 0);
	private bool isResetting = false;

	// Use this for initialization
	void Start ()
	{
		GameObject pGameObj = GameObject.FindGameObjectWithTag ("PuzzleGame");
		puzzleGame = pGameObj.GetComponent<PuzzleGame> ();
		correctPosition = gameObject.GetComponent<Transform> ().position;
	}


	public void InitPiece (GameObject piece)
	{
		puzzlePiece = piece;
	}


	void LateUpdate ()
	{
		
		Animator anim = GetComponent<Animator> ();
		if (anim) {
			anim.GetComponent<SpriteRenderer> ().sprite = puzzlePiece.GetComponent<SpriteRenderer> ().sprite;
		}

	}

	// Update is called once per frame
	void Update ()
	{
		if (isResetting) {
			float step = 15 * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, offPosition, step);	
		}

		if (isResetting && transform.position == offPosition) {
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
		Debug.Log ("ResetPiece");
		isResetting = true;
		Animator anim = GetComponentInChildren<Animator> ();
		if (anim) {
			anim.SetTrigger ("ResetPiece");
		}
	}

}
