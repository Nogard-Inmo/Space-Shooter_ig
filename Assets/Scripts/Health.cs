using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 3;
    int maxHealth = 5;

    //Score
    ScoreManager points;


    public void Start()
    {
        points = FindAnyObjectByType<ScoreManager>();
    }

    public void SetHealth(int maxhealth, int health)
    {
        this.health = health;
        this.maxHealth = maxhealth;
    }

    public void Damage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Can not have negativ damage!");
        }    
        this.health -= amount;
        if (health <= 0)
        {
            die();
        }
    }

     public void Heal(int amount)
     {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Can not have negative healing!");
        }
        
        if (health +  amount > maxHealth)//makes it so you can't overheal
        {
            this.health = maxHealth;
        }
        else
        {
            this.health = amount;
        }
     }

    private void die()
    {
        if (CompareTag("Enemy"))
        {
            Destroy(gameObject);
            points.score += 100;
        }
        if (CompareTag("Player"))
        {
            SceneManager.LoadScene(7);
        }
        
    }

}
