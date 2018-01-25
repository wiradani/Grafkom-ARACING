using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class RaceFinish : MonoBehaviour {

	public GameObject MyCar;
	public GameObject FinishCam;
	public GameObject ViewModes;
	public GameObject LevelMusic;
	public GameObject CompleteTrig;
	public AudioSource FinishMusic;
	public GameObject TimeTrig;
	public GameObject StatusRace;
	public GameObject FinishPanel;

	void OnTriggerEnter () {
		this.GetComponent<BoxCollider> ().enabled = false;
		MyCar.SetActive (false);
		CompleteTrig.SetActive (false);
		CarController.m_Topspeed = 0.0f;
		MyCar.GetComponent<CarController> ().enabled = false;
		MyCar.GetComponent<CarUserControl> ().enabled = false;
		MyCar.SetActive (true);
		FinishCam.SetActive (true);
		LevelMusic.SetActive (false);
		ViewModes.SetActive (false);
		FinishMusic.Play ();
		TimeTrig.SetActive (false);
		//FinishPanel.SetActive(true);

			
	}


}
