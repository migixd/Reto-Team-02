using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCam : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;

    private Camera[] cameras;
    private int currentCameraIndex;

    private void Start()
    {
        cameras = new Camera[] { camera1, camera2, camera3, camera4 };
        currentCameraIndex = 0;

        SetActiveCamera(currentCameraIndex);
    }

    private void Update()
    {
        if (Keyboard.current != null && Keyboard.current.cKey.wasPressedThisFrame)
        {
            SwitchToNextCamera();
        }
    }

    private void SwitchToNextCamera()
    {
        if (cameras == null || cameras.Length == 0)
        {
            return;
        }

        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;
        SetActiveCamera(currentCameraIndex);
    }

    private void SetActiveCamera(int activeIndex)
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            if (cameras[i] != null)
            {
                cameras[i].gameObject.SetActive(i == activeIndex);
            }
        }
    }
}
