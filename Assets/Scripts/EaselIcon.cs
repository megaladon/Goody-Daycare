using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EaselIcon : MonoBehaviour
{
	public string sceneToLoad;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnMouseDown ()
	{
		
		if (sceneToLoad != null) {
			SceneManager.LoadScene (sceneToLoad);
		}
			
	}
}
