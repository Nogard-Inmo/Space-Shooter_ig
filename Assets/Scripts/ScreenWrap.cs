using UnityEngine;

public class ScreenWrap : MonoBehaviour //makes it so that the player can go from top to bottom, right to left based on the camera
{
    private Camera mainCamera;
    private Vector3 screenBounds;

    void Start()
    {
        mainCamera = Camera.main;
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
    }

    void Update()
    {
        Vector3 pos = transform.position;

        Vector3 viewportPos = mainCamera.WorldToViewportPoint(pos);

        if (viewportPos.x > 1f)
            pos.x = mainCamera.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).x;
        else if (viewportPos.x < 0f)
            pos.x = mainCamera.ViewportToWorldPoint(new Vector3(1f, 0f, 0f)).x;

        if (viewportPos.y > 1f)
            pos.y = mainCamera.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).y;
        else if (viewportPos.y < 0f)
            pos.y = mainCamera.ViewportToWorldPoint(new Vector3(0f, 1f, 0f)).y;

        transform.position = pos;
    }
}
