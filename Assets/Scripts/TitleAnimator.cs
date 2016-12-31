using UnityEngine;
using System.Collections;

public class TitleAnimator : MonoBehaviour
{

	public Sprite newSprite;
	public AudioClip clip;
	public float titleInDoneDelay = .5f;
	public float titleOutDoneDelay = .1f;

	private AudioSource[] audioSource;
	private BabyFunGame babyFunGame;
	// Use this for initialization
	void Start ()
	{
		
		audioSource = GetComponents<AudioSource> ();
		this.gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = newSprite;
		babyFunGame = GameObject.FindObjectOfType<BabyFunGame> ();

	}

	// Title animation calls this when 2 different events end: titleIn titleOut
	void OnAnimationDone (string whichAni)
	{
		Debug.Log ("OnAnimationDone - titleAnimator: " + whichAni);
		float delay;
		if (whichAni == "titleIn") {
			delay = titleInDoneDelay;
		} else {
			delay = titleOutDoneDelay;
		}

		babyFunGame.OnAnimationDone (whichAni, delay);
	}

	void playTitle ()
	{
		Debug.Log ("PlayTitle " + clip);

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



}
