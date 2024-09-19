using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEditor.XR.LegacyInputHelpers;

public class PlayerShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BulletTemplate;
    public float shootPower = 300f;

    public InputActionReference trigger;
    
    void Start()
    {
        trigger.action.performed += Shoot;
    }

    void Shoot(InputAction.CallbackContext __){
        GameObject newBullet = Instantiate(BulletTemplate, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);
    }
  
}
