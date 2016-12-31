using UnityEngine;
using System.Collections;

public class AnimationEvents : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void OnOutroDone ()
	{
		ShapeBehavior shapeBehavior = this.GetComponentInParent<ShapeBehavior> ();
		shapeBehavior.OutroDone ();
	}
}
