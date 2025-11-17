using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] TMP_Text scoreText;
    [SerializeField] public int score = 0;

    public static ScoreManager Instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //makes so the text on screen updates. 
    {
        if (scoreText != null)
        {
            scoreText.text = $"{score}";
        }

    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keeps score alive across scenes
        }
        else
        {
            Destroy(gameObject); // Prevent duplicates
        }

    }

    public void ResetScore()
    {
        score = 0;
    }
    public void AddPoints(int amount)
    {
        score += amount;
    }


}
