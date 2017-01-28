using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
	public LevelManager levelManager;

	// Use this for initialization
	void Start ()
	{
		
	}

	void OnMouseDown ()
	{
		
	}

	void OnMouseUp ()
	{
		if (levelManager) {
			levelManager.LoadLevel ("02 Home");
		}	
	}
}
