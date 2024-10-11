using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        // Add behavior when the bullet collides, e.g., damage the player
        if (collision.gameObject.tag == "Enemyhitbox") {
	      string currentSceneName = SceneManager.GetActiveScene().name;
	      SceneManager.LoadScene(currentSceneName);
	    }
        Destroy(gameObject);
    }

        // Destroy the bullet after collision
      
}


