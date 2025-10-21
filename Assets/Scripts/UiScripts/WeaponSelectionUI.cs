using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponSelectionUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NormalGun()
    {
        SceneManager.LoadScene(3);
    }

    public void Shotgun()
    {
        SceneManager.LoadScene(4);
    }

    public void Minigun()
    {
        SceneManager.LoadScene(5);
    }

    public void Pulsegun()
    {
        SceneManager.LoadScene(6);
    }

    public void Railgun()
    {
        SceneManager.LoadScene(7);
    }

}
