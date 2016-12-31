using UnityEngine;
using System.Collections;

public class BabyFunAnimation : MonoBehaviour
{
	private BabyFunGame babyFunGame;
	public float animationDoneDelay = .3f;
	// Use this for initialization
	void Start ()
	{
		babyFunGame = GameObject.FindObjectOfType<BabyFunGame> ();
	}

	void OnAnimationDone (string whichAni)
	{
		Debug.Log ("*********** OnAnimationDone - " + whichAni);
		babyFunGame.OnAnimationDone (whichAni, animationDoneDelay);
	}

	void OnPlayAudioClip (AudioClip clip)
	{
		Debug.Log ("OnPlayAudioClip - " + clip);
		babyFunGame.OnPlayAudioClip (clip);
	}
}
