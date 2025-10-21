using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    //public int damage = 40;
    public Rigidbody2D rb;

    void Start()
    {
        rb.linearVelocity = transform.up * speed;
        StartCoroutine(Deletee());
    }

    private void Update()
    {
        
    }


    private IEnumerator Deletee()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
}
