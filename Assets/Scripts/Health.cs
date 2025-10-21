using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 3;
    int MAX_HEALTH = 5;

    //Score
    ScoreManager points;


    public void Start()
    {
        points = FindAnyObjectByType<ScoreManager>();
    }

    public void SetHealth(int maxhealth, int health)
    {
        this.health = health;
        this.MAX_HEALTH = maxhealth;
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
        
        if (health +  amount > MAX_HEALTH)//makes it so you can't overheal
        {
            this.health = MAX_HEALTH;
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
            points.score += 100;
        }
        Destroy(gameObject);
    }

}
