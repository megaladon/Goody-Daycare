using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScreenResolution : MonoBehaviour
{

	public bool maintainWidth = true;

	[Range (-1, 1)]
	public int adaptPosition;

	float defaultWidth;
	float defaulHeight;
	Vector3 CameraPos;

	// Use this for initialization
	void Start ()
	{
		CameraPos = Camera.main.transform.position;
		defaulHeight = Camera.main.orthographicSize;
		defaultWidth = Camera.main.orthographicSize * Camera.main.aspect;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (maintainWidth) {
			Camera.main.orthographicSize = defaultWidth / Camera.main.aspect;
			Camera.main.transform.position = new Vector3 (CameraPos.x, adaptPosition * (defaulHeight - Camera.main.orthographicSize), CameraPos.z);
		} else {
			Camera.main.transform.position = new Vector3 (adaptPosition * (defaultWidth - Camera.main.orthographicSize * Camera.main.aspect), CameraPos.y, CameraPos.z);
		}
	}
}
