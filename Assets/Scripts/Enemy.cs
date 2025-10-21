using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;


public class Enemy : MonoBehaviour
{
    public int health = 80;
    public GameObject enemy;
    ScoreManager points;
    private void Start()
    {
        points = FindAnyObjectByType<ScoreManager>();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();

        }
    }
    void Die()
    {
        print("die");
        StartCoroutine(Death());
        

    }
    IEnumerator Death()
    {
        print("death?");
        yield return new WaitForSeconds(0.5f);
        points.score += 100;
        print("points?");
        Instantiate(enemy);
        Destroy(gameObject);
        




    }

}
