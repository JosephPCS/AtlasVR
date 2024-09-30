using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eshooter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BulletFab;

    public GameObject playerTarget;

    float shootpower = 5f;

    float shotTime;

    System.Random rnd = new System.Random();
    void Start()
    {
        shotTime = 1f;
        //shotTime = 0.1F;
    }

    // Update is called once per frame
    void Update()
    {
        shotTime -= Time.deltaTime;

        if(shotTime <= 0.0f){
            transform.LookAt(playerTarget.transform);
            GameObject newBullet = Instantiate(BulletFab, transform.position + (transform.forward * 1.5f), transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootpower * (1/Time.deltaTime));
            Destroy(newBullet, 5);
            //shotTime = 0.2f;
            shotTime = rnd.Next(2,5);
        }
    }
}
