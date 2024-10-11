using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;

    // Update is called once per frame
    private void OnCollisionEnter(Collision other){
        if(health == 0){
            Destroy(gameObject, 1f);
            //SceneManager.LoadScene("Scenes/Win");
        }else{
            health -= 1;
        }
    }
}
