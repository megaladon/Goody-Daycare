using UnityEngine;
using System.Collections;

public class Radio : MonoBehaviour
{

	public delegate void ClickAction ();

	public static event ClickAction MusicPlaying;

	public static string currentSong;

	// Use this for initialization
	void Start ()
	{

		currentSong = "GoodyMash";

	}

	public void playRadio ()
	{
		if (MusicPlaying != null) {
			MusicPlaying ();
		} else {
			Debug.Log ("NO Subscribers");
		}
	}

	/*
	void onClick ()
	{

		Debug.Log ("click");
	}
	*/


	void OnMouseDown ()
	{
		playRadio ();

	}

	// Update is called once per frame
	void Update ()
	{
		
	}
}
