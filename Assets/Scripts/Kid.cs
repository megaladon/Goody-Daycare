using UnityEngine;
using System.Collections;

public class Kid : MonoBehaviour
{

	public string levelToLoad;
	public string myFavoriteSong;
	public kidsNames myName;

	public enum kidsNames
	{
		Kaycee = 0,
		Kaydin,
		Yancy,
		Baby1,
		Baby2,
		Baby3
	}

	void OnEnable ()
	{
		Radio.MusicPlaying += Dance;
	}

	void OnDisable ()
	{
		Radio.MusicPlaying -= Dance;
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	void OnMouseDown ()
	{
		LevelManager LevelManager = GameObject.FindObjectOfType<LevelManager> ();

		PlayerPrefs.SetString ("currentScene", levelToLoad);

		LevelManager.LoadLevel (levelToLoad);
	}

	void Dance ()
	{
		Debug.Log ("My Name is: " + myName + " I LIKE TO DANCE TO: " + myFavoriteSong + " The current song playing is: " + Radio.currentSong);

		if (myFavoriteSong == Radio.currentSong) {
			Debug.Log ("Time for me to dance!!");
		} else {
			Debug.Log ("I don't like this song!");
		}
	}

}
