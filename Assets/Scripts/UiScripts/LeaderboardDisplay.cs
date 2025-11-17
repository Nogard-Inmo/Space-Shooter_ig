using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardDisplay : MonoBehaviour
{
    [SerializeField] private Transform scoreContainer;
    [SerializeField] private GameObject scoreEntryPrefab;

    void Start()
    {
        List<int> scores = LeaderboardManager.Instance.LoadScores();

        for (int i = 0; i < scores.Count; i++)
        {
            GameObject entry = Instantiate(scoreEntryPrefab, scoreContainer);
            entry.GetComponent<TMPro.TextMeshProUGUI>().text = $"{i + 1}. Score: {scores[i]}";
        }
    }
}