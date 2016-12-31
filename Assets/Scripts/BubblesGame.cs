using UnityEngine;
using System.Collections;

public class BubblesGame : MonoBehaviour
{
	public GameObject bubbleAnimation;
	public GameObject[] letters;
	public int gameLenghtInSeconds;

	private int groupCount;
	private Sprite caSprite;
	private float startTime;
	private bool isTimeUp;
	private bool hasEndGamestarted;

	// Use this for initialization
	void Start ()
	{
		InitLevel ();
	}

	void Update ()
	{
		float currTime = Time.time - startTime;
		//float minutes = Mathf.Ceil (currTime / 60);
		float seconds = Mathf.Ceil (currTime % 60);

		if (seconds == gameLenghtInSeconds) {
			isTimeUp = true;

			// destroy bubbles currently on screen?
			// or let them float off?
		}

		//GameObject.FindObjectOfType<BubbleBehavior>
		//Debug.Log (minutes + ":" + seconds);

	}

	public void checkLastBubbleDestroyed ()
	{
		Invoke ("doCheck", 1);
	}

	void doCheck ()
	{
		if (isTimeUp) {
			BubbleBehavior[] remainingBubbles = GameObject.FindObjectsOfType (typeof(BubbleBehavior)) as BubbleBehavior[];
			Debug.Log ("remainingBubbles " + remainingBubbles.Length);
			if (remainingBubbles.Length == 0) {
				endGame ();
			}	
		}
	}

	void endGame ()
	{
		if (!hasEndGamestarted) {
			hasEndGamestarted = true;
			Debug.Log ("endGame");
		}

	}

	void InitLevel ()
	{
		int ranNum = Random.Range (0, letters.Length);
		caSprite = letters [ranNum].GetComponent<SpriteRenderer> ().sprite;
		GameObject caGameObject = Instantiate (letters [ranNum], new Vector3 (-4.87f, 1.99f, 0f), Quaternion.identity) as GameObject;

		Debug.Log ("caSprite=" + caSprite);

		Invoke ("StartBubbles", 1.0f);
		groupCount = 0;
	}

	void StartBubbles ()
	{
		startTime = Time.time - startTime;
		Invoke ("PlaceGameBubble", 1.0f);
	}

	void PlaceGameBubble ()
	{

		if (!isTimeUp) {
			// place a small blank bubble before each gameplay bubble
			//Instantiate (small_bubble, new Vector3 (3.73f, -0.34f, 0), Quaternion.identity);

			groupCount++;
			float delay;

			if (groupCount < 3) {
				delay = 1.0f;
			} else {
				delay = 2.0f;
				groupCount = 0;
			}

			int ranNum = Random.Range (0, letters.Length);
			Sprite newSprite = letters [ranNum].GetComponent<SpriteRenderer> ().sprite;
			GameObject newBubble = Instantiate (bubbleAnimation, new Vector3 (-4.85f, -0.56f, 0), Quaternion.identity) as GameObject;
			BubbleBehavior bubbleBehavior = newBubble.GetComponentInChildren<BubbleBehavior> ();
			bubbleBehavior.SwitchSprite (newSprite);

			Invoke ("PlaceGameBubble", delay);

		}



	}

	public Sprite getCASprite ()
	{
		return caSprite;
	}
}
