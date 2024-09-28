using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// at the top add this ^^

public class GameOver : MonoBehaviour
{

private void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Enemyhitbox") {
	      string currentSceneName = SceneManager.GetActiveScene().name;
	      SceneManager.LoadScene(currentSceneName);
	  }
}
}
