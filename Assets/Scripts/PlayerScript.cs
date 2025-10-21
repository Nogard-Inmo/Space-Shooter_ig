using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Movement
    KeyCode left = KeyCode.LeftArrow ;
    KeyCode right = KeyCode.RightArrow;
    KeyCode up = KeyCode.UpArrow;
    KeyCode down = KeyCode.DownArrow;
    KeyCode shoot = KeyCode.Space;


    [SerializeField, Range(1,3)] float speed;
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
            print("left");
            transform.position -= new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKey(right))
        {
            print("Right");
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

        //gun
        if (Input.GetKeyDown(shoot))
        {
            print("shoot");

        }

        //rotation
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 dir = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.up = dir;
    }
}
