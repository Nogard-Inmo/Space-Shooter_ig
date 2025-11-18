using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponSelectionUI : MonoBehaviour
{
    //changes scenes
    public void NormalGun()
    {
        SceneManager.LoadScene(2);
        ScoreManager.Instance.ResetScore();

    }

    public void Shotgun()
    {
        SceneManager.LoadScene(3);
        ScoreManager.Instance.ResetScore();

    }

    public void Minigun()
    {
        SceneManager.LoadScene(4);
        ScoreManager.Instance.ResetScore();

    }

    public void Pulsegun()
    {
        SceneManager.LoadScene(5);
        ScoreManager.Instance.ResetScore();

    }

    public void Railgun()
    {
        SceneManager.LoadScene(6);
        ScoreManager.Instance.ResetScore();

    }

}
