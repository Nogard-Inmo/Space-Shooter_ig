using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Movement
    [SerializeField] KeyCode left = KeyCode.LeftArrow ;
    [SerializeField] KeyCode right = KeyCode.RightArrow;
    [SerializeField] KeyCode up = KeyCode.UpArrow;
    [SerializeField] KeyCode down = KeyCode.DownArrow;
    [SerializeField] KeyCode shoot = KeyCode.Space;

    [SerializeField, Range(1,3)] float speed;

    //weapon
    public Transform firePointRight;
    public Transform firePointLeft;
    public GameObject bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //movement
        if (Input.GetKey(left))
        {
            transform.position -= new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKey(right))
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
       
        if (Input.GetKey(up))
        {
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        }
        
        if (Input.GetKey(down))
        {
            transform.position -= new Vector3(0, 1, 0) * speed * Time.deltaTime;
        }


        //rotation
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 dir = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.up = dir;

        //gun
        if (Input.GetKeyDown(shoot))
        {
            print("shoot");
            Shoot();
        }

    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePointLeft.position, firePointLeft.rotation);
        Instantiate(bulletPrefab,firePointRight.position, firePointRight.rotation);
    }
}
