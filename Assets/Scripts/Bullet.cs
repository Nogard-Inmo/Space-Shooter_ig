using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    [SerializeField] float projectileDeleatSpeed = 1f;
    public int damage = 40;
    [SerializeField] bool moving;
    [SerializeField] bool hitDestroy = true;
    void Start()
    {
        if (moving == true)
        {
            rb.linearVelocity = transform.up * speed;
        }


        StartCoroutine(SelfDestroy());
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.GetComponent<Health>() != null)
        {
            if (collider.CompareTag("Enemy"))
            {
                Health health = collider.GetComponent<Health>();
                health.Damage(damage);
                if (hitDestroy==true)
                {
                    Destroy(gameObject);
                }
            }
        }

        

    }
    private IEnumerator SelfDestroy()
    {
        yield return new WaitForSeconds(projectileDeleatSpeed);
        Destroy(gameObject);
    }

}
