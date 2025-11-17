using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void MainMenu()
    {
        ScoreManager.Instance.ResetScore();
        SceneManager.LoadScene(0);
    }
    public void LeaderboardMenu()
    {
        SceneManager.LoadScene(8);
    }

}
