using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullPuzzleManager : MonoBehaviour
{
	public GameObject fullPuzzle;
	public GameObject puzzleOutLine;
	public float puzzleOpacity;

	// Use this for initialization
	void Start ()
	{
		Renderer fullPuzzleRenderer = fullPuzzle.GetComponent<Renderer> ();
		fullPuzzleRenderer.material.color = new Color (1.0f, 1.0f, 1.0f, puzzleOpacity);

		Debug.Log ("****************Rendere " + fullPuzzleRenderer);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
