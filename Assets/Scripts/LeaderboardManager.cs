using System.Collections.Generic;
using UnityEngine;

public class LeaderboardManager : MonoBehaviour
{
    private const int MaxEntries = 6;
    private const string ScoreKey = "HighScore";

    public static LeaderboardManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // stayes even if i load another scene
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveScore(int newScore)
    {
        List<int> scores = LoadScores();
        scores.Add(newScore);
        scores.Sort((a, b) => b.CompareTo(a));
        if (scores.Count > MaxEntries)
            scores.RemoveAt(scores.Count - 1);

        for (int i = 0; i < scores.Count; i++)
        {
            PlayerPrefs.SetInt(ScoreKey + i, scores[i]);
        }

        PlayerPrefs.Save();
    }

    public List<int> LoadScores()
    {
        List<int> scores = new List<int>();
        for (int i = 0; i < MaxEntries; i++)
        {
            if (PlayerPrefs.HasKey(ScoreKey + i))
                scores.Add(PlayerPrefs.GetInt(ScoreKey + i));
        }
        return scores;
    }

    [ContextMenu("Clear Leaderboard")]// system to manually clear the leaderboard from unity editor
    public void ClearLeaderboard()
    {
        for (int i = 0; i < MaxEntries; i++)
        {
            PlayerPrefs.DeleteKey(ScoreKey + i);
        }
        PlayerPrefs.Save();
        Debug.Log("Leaderboard manually cleared.");
    }

}