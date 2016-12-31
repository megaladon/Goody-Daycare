using UnityEngine;
using System.Collections;

public class BubbleBehavior : MonoBehaviour
{
	private Animator anim;
	private Sprite animSprite;
	private Sprite updateSprite;
	private bool isCurrentCAShape;
	private BubblesGame bubblesGame;

	// Use this for initialization
	void Start ()
	{
		anim = this.GetComponent<Animator> ();
		animSprite = this.GetComponent<SpriteRenderer> ().sprite;
		bubblesGame = GameObject.FindObjectOfType<BubblesGame> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnMouseDown ()
	{
		if (!isCurrentCAShape) {
			
			Sprite caSprite = bubblesGame.getCASprite ();

			Sprite clickSprite = this.GetComponent<SpriteRenderer> ().sprite;

			if (caSprite == clickSprite) {
				Debug.Log ("\n MATCH!!!!!!! " + caSprite + " " + clickSprite);
			}

			Destroy (gameObject);
			bubblesGame.checkLastBubbleDestroyed ();
		}

	}

	void OnIntroDone ()
	{
		//Animator anim = this.GetComponent<Animator> ();

		// 1. find a random path
		string str = "activatePath" + Random.Range (1, 4);
		anim.SetTrigger (str);
	}

	void OnReachedEndOfPath ()
	{
		Destroy (gameObject);
		bubblesGame.checkLastBubbleDestroyed ();
	}

	void OnPopBubble (bool isCorrect)
	{
		
	}

	public void SwitchSprite (Sprite newSprite)
	{
		//Debug.Log ("SwitchSprite!!! " + gameObject.GetComponent<SpriteRenderer> ().sprite + " switchto: " + newSprite);

		updateSprite = newSprite;
	}

	void LateUpdate ()
	{
		if (updateSprite) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = updateSprite;
		}
	}

	public void SetCurrentCAShape ()
	{
		isCurrentCAShape = true;
	}
}
