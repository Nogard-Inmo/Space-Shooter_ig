using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    [SerializeField] int health = 3;
    int maxHealth = 5;

    private bool isDead = false; // Prevent multiple deaths


    //Score
    ScoreManager points;
    LeaderboardManager score;

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
        if (isDead) return;
        isDead = true;

        if (CompareTag("Enemy"))//adds score and destroys the enemy
        {
            ScoreManager.Instance.AddPoints(100);
            Destroy(gameObject);
        }
        if (CompareTag("Player"))
        {
            LeaderboardManager.Instance.SaveScore(points.score);//saves score to the leaderboard when the player dies

            SceneManager.LoadScene(7);//loads game over scene when the player dies
        }
        
    }

}
