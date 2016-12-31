using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

	public Slider volumerSlider, diffSlider;
	public LevelManager levelManager;
	private MusicManager musicManager;

	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		volumerSlider.value = PlayerPrefsManager.GetMasterVolume();
		diffSlider.value = PlayerPrefsManager.GetDifficulty();
	}

	void Update(){
		musicManager.ChangeVolume(volumerSlider.value);
	}
	

	public void SaveAndExit(){
		PlayerPrefsManager.SetMasterVolum(volumerSlider.value);
		levelManager.LoadLevel("01a Start");
		PlayerPrefsManager.SetDifficulty(diffSlider.value);
	}

	public void SetDefaults(){
		volumerSlider.value = 0.8f;
		diffSlider.value = 2f;
	}
}
