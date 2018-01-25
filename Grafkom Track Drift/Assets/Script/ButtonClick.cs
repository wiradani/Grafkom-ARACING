using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {

	public static bool GameIsPaused=false;
	public GameObject pauseMenuUI;


	public void restart(){
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		SceneManager.LoadScene("test02");
		GameIsPaused = false;

	}

	public void exit(){
	
	}

	public void Resume(){
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	public void Pause(){
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void Quit(){
		Application.Quit ();
	}

	public void BackToMainMenu(){
		SceneManager.LoadScene ("Main Menu");
	}

	public void GoToTrack1(){
		SceneManager.LoadScene("test02");
	}

	public void GoToLevelSelect(){
		SceneManager.LoadScene ("Level Select");
	}
}
