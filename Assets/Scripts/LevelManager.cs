using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;
using Random = UnityEngine.Random;
using System.Runtime.CompilerServices;
using System.Collections.Generic;


public class LevelManager : MonoBehaviour
{

	public float autoLoadNextLevelAfter;
	public levelNames level;

	// Globals
	private int shapeGameEnterCount;
	private int bubblesGameEnterCount;



	// Shared Game vars
	private int roundNum = 0;

	public LevelManager ()
	{
		Debug.Log ("LevelManager!!");
	}

	public enum levelNames
	{
		Default = 0,
		Shapes,
		Bubbles,
		Puzzles
	}


	void Start ()
	{
		
		if (autoLoadNextLevelAfter == 0) {
			Debug.Log ("Levelauto load disabled level= ");
		} else {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
		
	}

	public void LoadLevel (string name)
	{
		Debug.Log ("level load requested for: " + name);
		SceneManager.LoadScene (name);
	}

	public void QuitRequest ()
	{
		Debug.Log ("I Want to quit!");
		Application.Quit ();
	}

	public void LoadNextLevel ()
	{
		//SceneManager.LoadScene(Application.loadedLevel+1);

		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}



		

}
