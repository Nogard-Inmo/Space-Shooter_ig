using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    [SerializeField] float projectileDeleatSpeed = 1f; // time until it destroys itself
    public int damage = 40;
    [SerializeField] bool moving;
    [SerializeField] bool hitDestroy = true;
    void Start()
    {
        if (moving == true)//if it should move or not
        {
            rb.linearVelocity = transform.up * speed;
        }


        StartCoroutine(SelfDestroy());
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.GetComponent<Health>() != null)
        {
            if (collider.CompareTag("Enemy"))//makes it so that bullets only hurt the enemies and not the player
            {
                Health health = collider.GetComponent<Health>();
                health.Damage(damage);
                if (hitDestroy==true)//if it has penetration or not
                {
                    Destroy(gameObject);
                }
            }
        }

        

    }//waits until it destroys itself if it did not hit anything
    private IEnumerator SelfDestroy()
    {
        yield return new WaitForSeconds(projectileDeleatSpeed);
        Destroy(gameObject);
    }

}
