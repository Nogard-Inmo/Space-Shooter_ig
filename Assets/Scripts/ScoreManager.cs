using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] TMP_Text scoreText;
    [SerializeField] public int score = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //makes so the text on screen updates. 
    {
        scoreText.text = $"{score}";
    }
}
