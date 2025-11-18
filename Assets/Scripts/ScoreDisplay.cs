using TMPro;
using UnityEngine;


//shows the current score on the screen
public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    void Update()
    {
        if (ScoreManager.Instance != null && scoreText != null)
        {
            scoreText.text = $"Score: {ScoreManager.Instance.score}";
        }
    }
}