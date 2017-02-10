using UnityEngine;
using System.Collections;

public class ShapeBehavior : MonoBehaviour
{
	///public delegate void ClickAction ();
	//public static event ClickAction mouseUp;

	private bool isCurrentCAShape = false;
	private GameObject shape;
	private Animator anim;

	// Use this for initialization
	void Start ()
	{
		
	}

	public void InitShape (GameObject s)
	{
		anim = GetComponentInChildren<Animator> ();
		shape = s;
	}

	void LateUpdate ()
	{

		 

		if (anim && shape) {
			//GetComponent<SpriteRenderer> ().sprite = shape.GetComponent<SpriteRenderer> ().sprite;
			anim.GetComponent<SpriteRenderer> ().sprite = shape.GetComponent<SpriteRenderer> ().sprite;
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnMouseDown ()
	{

		if (isCurrentCAShape) {
			Debug.Log ("This is The current shape");
		} else {
			ShapesGame shapeGame = GameObject.FindObjectOfType<ShapesGame> ();
			shapeGame.OnShapeClicked (this.GetComponentInChildren<SpriteRenderer> (), gameObject);	
		}
	}

	void OnMouseUp ()
	{



	}

	public void OutroDone ()
	{
		if (isCurrentCAShape) {
			ShapesGame shapesGame = GameObject.FindObjectOfType<ShapesGame> ();
			shapesGame.OutroDone (gameObject);
		} else {
			ShapesGame shapesGame = GameObject.FindObjectOfType<ShapesGame> ();
			shapesGame.OutroDone (gameObject);	
		}

	}

	public void SetCurrentCAShape (bool bol)
	{
		isCurrentCAShape = bol;
	}

	public bool GetCurrentCAShape ()
	{
		return isCurrentCAShape; 
	}


}
