using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyParent : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnCollisionEnter(Collision other){
        if(transform.parent != null){
            Destroy(gameObject, 1f);
        }
   }
}
