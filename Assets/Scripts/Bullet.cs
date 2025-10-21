using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;

    void Start()
    {
        rb.linearVelocity = transform.up * speed;
    }

    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        else
        {
            StartCoroutine(Deletee());
        }
    }
    private IEnumerator Deletee()
    {
        yield return new WaitForSeconds(0.45f);
        Destroy(gameObject);
    }
}
