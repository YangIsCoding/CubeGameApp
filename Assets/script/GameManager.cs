
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public float Delay = 1.5f;
	public GameObject completeGameUI;

	public void CompleteLevel(){
		completeGameUI.SetActive (true);
	}

	public void EndGame(){
		if (gameHasEnded == false) {
			gameHasEnded = true;
			Invoke ("Restart" , Delay);
		}
		Debug.Log ("over");
	}

	void Restart (){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
