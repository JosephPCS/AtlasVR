using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public GameObject player;        // Reference to the player
    public GameObject bulletPrefab;  // Reference to the bullet prefab
    public Transform bulletSpawn;    // Bullet spawn point
    public float shootingInterval = 2f;  // How often to shoot
    public float bulletSpeed = 10f;      // Speed of the bullet
    private float timeSinceLastShot;

    void Start()
    {
        // Assuming the player has the tag "Player"
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        timeSinceLastShot = 0f;
    }

    void Update()
    {
        // Make the enemy look at the player
        if (player != null)
        {
            transform.LookAt(player.transform.position);

            // Count the time since the last shot
            timeSinceLastShot += Time.deltaTime;

            // Shoot a bullet if enough time has passed
            if (timeSinceLastShot >= shootingInterval)
            {
                Shoot();
                timeSinceLastShot = 0f; // Reset the timer
            }
        }
    }

    void Shoot()
    {
        // Instantiate the bullet at the bullet spawn point
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        
        // Get the Rigidbody of the bullet and disable gravity
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.useGravity = false;

        // Set the bullet's velocity in the direction the enemy is facing
        rb.velocity = transform.forward * bulletSpeed;
    }
}
