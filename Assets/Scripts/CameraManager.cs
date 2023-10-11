using System.Collections.Generic;
using vCam = Cinemachine.CinemachineVirtualCamera;
public static class CameraManager
{
    static List<vCam> cameras = new List<vCam>();
    static vCam activeCamera;
    public static bool IsActiveCamera(vCam cam) => cam == activeCamera;
    public static void Register(vCam cam) => cameras.Add(cam);
    public static void UnRegister(vCam cam) => cameras.Remove(cam);

    public static void SwitchCamera(vCam cam)
    {
        activeCamera = cam;
        activeCamera.Priority = 10;
        foreach (vCam vcam in cameras)
        {
            if (IsActiveCamera(vcam)) continue;
            vcam.Priority = 0;
        }
    }
}
