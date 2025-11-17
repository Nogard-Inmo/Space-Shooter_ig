using TMPro;
using UnityEngine;

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