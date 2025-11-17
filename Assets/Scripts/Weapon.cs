using UnityEngine;


public class Weapon : MonoBehaviour
{

    //Weapon
    public GameObject bulletPrefab;                  // Assign your bullet prefab in the Inspector
    public Transform firePoint1;                    // Assign the fire point in the Inspector
    public Transform firePoint2;                   // Assign the fire point in the Inspector
    public int bulletCount = 9;                   // Number of bullets to fire(it can't be 1
    public float spreadAngle = 45f;              // Total spread angle in degrees
    public float fireCooldown = 1f;             // Cooldown in seconds
    private float lastFireTime = -Mathf.Infinity;
    [SerializeField]private bool isMinugun = false;
    // Update is called once per frame
    void Update()
    {


        //shooting
        
        if (isMinugun == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time >= lastFireTime + fireCooldown)
            {
                lastFireTime = Time.time;
                Shoot();
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                lastFireTime = Time.time;
                Shoot();
            }
        }

    }

    void Shoot()
    {
        float angleStep = spreadAngle / (bulletCount - 1);
        float startAngle = -spreadAngle / 2;

        for (int i = 0; i < bulletCount; i++)
        {
            float angle = startAngle + i * angleStep;
            Quaternion rotation = Quaternion.Euler(0, 0, angle);
            Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation * rotation);
            Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation * rotation);
        }

    }
}
