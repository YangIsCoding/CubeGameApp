using UnityEngine.SceneManagement;
using UnityEngine;

public class manu : MonoBehaviour {

	public void StartGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);
	}
		
}
