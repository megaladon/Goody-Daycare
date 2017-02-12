using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;
using Random = UnityEngine.Random;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

public class ShapesGame : MonoBehaviour
{
	public System.Random ran = new System.Random ();

	private int MAX_ROUNDS = 5;
	private int MAX_CORRECT_ANSWERS = 3;
	private Vector3 CURRENT_CA_SHAPE_POSITION = new Vector3 (1.6f, 3.88f, 0);

	private int numberOfCorrectShapes;
	private int correctShapeCount;
	private int caShapeIndex;
	private bool isRoundOver;
	private Sprite caSprite;
	private ShapeBehavior[] shapeSprites;
	private ShapeBehavior[] shapeSpriteTypes;

	//public GameObject[] shapes;
	public GameObject[] blueShapes;
	public GameObject[] greenShapes;
	public GameObject[] redShapes;
	public GameObject[] orangeShapes;
	public GameObject[] yellowShapes;
	List<Vector3> shapePositions;

	public GameObject kaycee;
	public LevelManager levelManager;

	private int roundNum = 0;
	private int numberOfShapeTypes = 8;
	List<GameObject[]> shapeColorSets;
	//private GameObject[][] shapeColorSets;

	public enum gameType
	{
		randomShapes = 0,
		numberShapes
	}

	void Start ()
	{

		shapeColorSets = new List<GameObject[]> ();
		shapeColorSets.Add (blueShapes);
		shapeColorSets.Add (greenShapes);
		shapeColorSets.Add (redShapes);
		shapeColorSets.Add (yellowShapes);
		shapeColorSets.Add (orangeShapes);
		for (int i = 0; i < 8; i++) {
			//shapeColorSets[]
		}
		initLevel ();	
	}

	void initLevel ()
	{
		initShapesGame ();	
	}

	void initShapesGame ()
	{
		roundNum = 0;
		numberOfCorrectShapes = Random.Range (1, MAX_CORRECT_ANSWERS);

		//ShapeBehavior[] shapeSprites = GameObject.FindObjectsOfType<ShapeBehavior> ();
		//ShuffleArray (shapeSprites);

		shapePositions = new List<Vector3> ();
		shapePositions.Add (new Vector3 (3.74f, 4.5f, 0));
		shapePositions.Add (new Vector3 (4.86f, 4.5f, 0));
		shapePositions.Add (new Vector3 (6.04f, 4.5f, 0));
		shapePositions.Add (new Vector3 (7.27f, 4.5f, 0));
		shapePositions.Add (new Vector3 (3.74f, 3.34f, 0));
		shapePositions.Add (new Vector3 (4.86f, 3.34f, 0));
		shapePositions.Add (new Vector3 (6.04f, 3.34f, 0));
		shapePositions.Add (new Vector3 (7.27f, 3.34f, 0));

		initRound ();
	}

	void initRound ()
	{
		// The number of correct shapes the user needs this round
		numberOfCorrectShapes = 3; //Random.Range (0, MAX_CORRECT_ANSWERS);
		correctShapeCount = 0;
		isRoundOver = false;

		//GameObject[] tempShapes = shapes;

		//	gameType gt = gameType.randomShapes;
		//Debug.Log ("what is this?" + typeof(gameType));
		GameObject[] tempShapes = getShapeSet (gameType.randomShapes);//  yellowShapes;


		ShuffleArray (tempShapes);
		int caShapeNum = 0;
		GameObject gameObj = tempShapes [caShapeNum];
		caSprite = gameObj.GetComponentInChildren<SpriteRenderer> ().sprite;
		List<GameObject> newShapes = new List<GameObject> ();

		// Add the correct number of correct shapes
		for (int a = 0; a < numberOfCorrectShapes; a++) {
			newShapes.Add (tempShapes [caShapeNum]); // this number should be 0
		}

		// Add the correct number of incorrect shapes
		int s = tempShapes.Length - numberOfCorrectShapes;
		for (int i = 1; i <= s; i++) {
			newShapes.Add (tempShapes [i]);
		}

		// Randomize and place the shapes
		shapePositions = ShuffleList (shapePositions);
		for (int j = 0; j < newShapes.Count; j++) {
			StartCoroutine (OnPlaceShape (newShapes, j, Random.Range (0.4f, 1.2f)));
		}

		// Show the current CA Shape CURRENT_CA_SHAPE_POSITION
		GameObject CA = Instantiate (tempShapes [caShapeNum], CURRENT_CA_SHAPE_POSITION, Quaternion.identity) as GameObject;
		CA.GetComponent<ShapeBehavior> ().InitShape (tempShapes [caShapeNum]);
		ShapeBehavior nShape = CA.GetComponent<ShapeBehavior> ();
		nShape.SetCurrentCAShape (true);
	}

	IEnumerator OnPlaceShape (List<GameObject> newShapes, int num, float delayTime)
	{
		yield return new WaitForSeconds (delayTime);
		GameObject obj = Instantiate (newShapes [0], shapePositions [num], Quaternion.identity);
		obj.GetComponent<ShapeBehavior> ().InitShape (newShapes [num]);

	}

	public void OnShapeClicked (SpriteRenderer clickSprite, GameObject obj)
	{
		Animator anim = obj.GetComponentInChildren<Animator> ();
		if (clickSprite.sprite == caSprite) {
			
			//anim.SetTrigger ("incorrect");
			HandleCorrectShape (anim);
			KayceeCA ();
		} else {
			HandleIncorrectShape (anim);
			KayceeWA ();

		}
	}

	// Called from (shape animation->ShapeBehavior) happens when a shap animates off the stage
	public void OutroDone (GameObject obj)
	{

		ShapeBehavior nShape = obj.GetComponent<ShapeBehavior> ();
		bool isCurrent = nShape.GetCurrentCAShape ();

		if (isCurrent) {
			Debug.Log ("THIS IS THE CURRENT!!");
		}

		if (correctShapeCount == numberOfCorrectShapes && !isRoundOver) {
			Debug.Log ("\n YOU GOT ALL THE SHAPES");
			isRoundOver = true;
			// figure out how many shapes are left and get rid of them
			Invoke ("RemoveRemainingShapes", 1.0f);
		}  
		Destroy (obj);
		if (isRoundOver)
			Invoke ("checkLastShapeGone", .2f);
	}

	private void RemoveRemainingShapes ()
	{
		GameObject[] shapesLeftOnStage = GameObject.FindGameObjectsWithTag ("Shape");
		Debug.Log ("\n shapes left " + shapesLeftOnStage.Length);

		for (int i = 0; i < shapesLeftOnStage.Length; i++) {
			Animator anim = shapesLeftOnStage [i].GetComponentInChildren<Animator> ();
			anim.SetTrigger ("startOutro");
		}
	}

	private void checkLastShapeGone ()
	{
		if (isRoundOver) {
			GameObject[] shapesLeftOnStage = GameObject.FindGameObjectsWithTag ("Shape");
			if (shapesLeftOnStage.Length == 0) {
				// All wrong answers/shapes have been removed from the stage
				Debug.Log ("\n START A NEW ROUND!!!!");
				roundNum++;

				if (roundNum < MAX_ROUNDS) {
					initRound ();
				} else {
					Debug.Log ("\n GAME OVER GO BACK HOME"); 
					KayceeGameOver ();
					Invoke ("GameOver", 2f);
				}


			} else {
				Debug.Log ("\n Round Over But Shapes remain");
			}
		}
	}

	private void GameOver ()
	{
		levelManager.LoadLevel ("02 Home");
	}

	private void HandleCorrectShape (Animator anim)
	{
		correctShapeCount++;
		anim.SetTrigger ("startOutro");
	}

	private void HandleIncorrectShape (Animator anim)
	{
		anim.SetTrigger ("incorrect");
	}

	// Displays correct answer play off.
	private void KayceeCA ()
	{
		Animator anim = kaycee.GetComponentInChildren<Animator> ();
		anim.SetTrigger ("startCA");
	}
	// Displays correct answer play off.
	private void KayceeWA ()
	{
		Animator anim = kaycee.GetComponentInChildren<Animator> ();
		anim.SetTrigger ("startWA");
	}

	private void KayceeGameOver ()
	{
		Animator anim = kaycee.GetComponentInChildren<Animator> ();
		anim.SetTrigger ("startGameComplete");
	}



	/*
	 * *******************************************************************************************
	 * 
	 *  							Shape Sorting section
	 * 
	 * *******************************************************************************************
	 */

	private GameObject[] getShapeSet (gameType typeOfGame)
	{
		GameObject[] shapeSet;
		/*
		if (typeOfGame == gameType.numberShapes) {
			shapeSet = getRandomShapes ();
		}
*/
		Debug.Log ("\n ******************** getShapeSet " + typeOfGame);
		switch (typeOfGame) {
		case gameType.randomShapes:
			shapeSet = getRandomShapes ();
			break;
		default:
			shapeSet = getRandomShapes ();
			break;
		}
		return shapeSet;
	}

	private GameObject[] getRandomShapes ()
	{
		List<GameObject> randomShapes = new List<GameObject> ();
		for (int i = 0; i < numberOfShapeTypes; i++) {
			int ranNum = Random.Range (0, shapeColorSets.Count);
			randomShapes.Add (shapeColorSets [ranNum] [i]);
		}
		GameObject[] r = new GameObject[numberOfShapeTypes];
		for (int j = 0; j < numberOfShapeTypes; j++) {
			r [j] = randomShapes [j];
		}
		Debug.Log ("HOW MANY SHAPES " + randomShapes.Count);
		return r;
	}

	public static void ShuffleArray<T> (T[] arr)
	{
		for (int i = arr.Length - 1; i > 0; i--) {
			int r = Random.Range (0, i);
			T tmp = arr [i];
			arr [i] = arr [r];
			arr [r] = tmp;
		}
	}

	private List<E> ShuffleList<E> (List<E> inputList)
	{
		List<E> randomList = new List<E> ();
		int randomIndex = 0;
		while (inputList.Count > 0) {
			randomIndex = ran.Next (0, inputList.Count); //Choose a random object in the list
			randomList.Add (inputList [randomIndex]); //add it to the new, random list
			inputList.RemoveAt (randomIndex); //remove to avoid duplicates
		}
		return randomList; //return the new random list
	}




}
