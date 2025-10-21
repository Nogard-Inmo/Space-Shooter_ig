using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player; 
    public Vector3 offset = new Vector3(0f, 0f, -10f); 
    public float smoothSpeed = 5f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = Player.position + offset; // Hitta players postion men addera offset
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
    }
}
