using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    KeyCode left = KeyCode.LeftArrow ;
    KeyCode right = KeyCode.RightArrow;
    KeyCode shoot = KeyCode.Space;

    [SerializeField, Range(1,3)] float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            print("left");
            transform.position -= new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKey(right))
        {
            print("Right");
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(shoot))
        {
            print("shoot");

            Shoot();
        }

        void Shoot()
        {
            //Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }

    }
}
