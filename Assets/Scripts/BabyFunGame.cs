using UnityEngine;
using System.Collections;

public class BabyFunGame : MonoBehaviour
{

	private AudioSource[] audioSource;
	public GameObject titleHolder;
	public GameObject mainAnimation;

	void Start ()
	{
		audioSource = this.GetComponents<AudioSource> ();
	}

	public void OnAnimationDone (string whichAni, float delay)
	{		
		Debug.Log ("OnAnimationDone " + whichAni);
		switch (whichAni) {
		case "mainAnimation":
			// Main animation is done tell title to leave
			Invoke ("HandleMainAnimationDone", delay);
			break;
		case "titleIn":
			// Tell main animation to play
			Invoke ("HandleTitleInDone", delay);
			break;
		case "titleOut":
			// Title is off the screen go back to baby fun menu
			Invoke ("ReturnToScene", delay);
			break;
		default :
			break;
		}
	}

	void HandleMainAnimationDone ()
	{
		Animator titleAnimator = titleHolder.GetComponent<Animator> ();
		if (titleAnimator) {			
			titleAnimator.SetTrigger ("TitleOut");
		}
	}

	void HandleTitleInDone ()
	{
		if (mainAnimation) {
			Debug.Log ("HandleTitleInDone");
			Animator mainAniAnimator = mainAnimation.GetComponentInChildren<Animator> ();
			mainAniAnimator.SetTrigger ("playMainAnimation");	
		}
	}

	public void OnPlayAudioClip (AudioClip clip)
	{
		if (clip) {
			for (int i = 0; i < audioSource.Length; i++) {
				if (!audioSource [i].isPlaying) {
					audioSource [i].clip = clip;
					audioSource [i].Play ();
					break;
				}
			}
		}
	}

	void ReturnToScene ()
	{
		string currentScene = PlayerPrefs.GetString ("currentScene");
		string returnScene = "";
		switch (currentScene) {
		case "05a Baby Fun 1 Intro":
			returnScene = "05b Baby Fun 1";
			break;
		default:
			break;
		}

		LevelManager levelManager = GameObject.FindObjectOfType<LevelManager> ();

		levelManager.LoadLevel (returnScene);

	}
}
