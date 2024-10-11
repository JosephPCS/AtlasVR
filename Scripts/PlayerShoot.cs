using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEditor.XR.LegacyInputHelpers;
using UnityEngine.Audio;

public class PlayerShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BulletTemplate;
    public float shootPower = 300f;

    public InputActionReference trigger;

    public AudioClip gunShotSFX;
    
    void Start()
    {
        trigger.action.performed += Shoot;
    }

    void Shoot(InputAction.CallbackContext __){
        GameObject newBullet = Instantiate(BulletTemplate, transform.position+(transform.forward*0.7f), transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);
        GetComponent<AudioSource>().PlayOneShot(gunShotSFX);
    }
  
}
