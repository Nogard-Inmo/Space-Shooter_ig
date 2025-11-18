using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuUi : MonoBehaviour
{
    //Loads weapon selection scene
    public void WeponSelectionButton()
    {
        SceneManager.LoadScene(1);
    }


    [SerializeField] private GameObject controlPanle;

    private void Start()
    {
        controlPanle.SetActive(false);
    }
    
    // shows/hides the controlls 
    public void Controls()
    {
        controlPanle.SetActive(true);
    }

    public void ExitControls()
    {
        controlPanle.SetActive(false);
    }

    //closes the game(if in build)
    public void QuitGame()
    {
        Application.Quit();
    }
}
