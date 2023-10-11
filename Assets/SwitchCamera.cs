using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField] 
    CinemachineVirtualCamera cam1;
    [SerializeField] 
    CinemachineVirtualCamera cam2;

    void Awake()
    {
        CameraManager.Register(cam1);
        CameraManager.Register(cam2);
        CameraManager.SwitchCamera(cam1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CameraManager.IsActiveCamera(cam1))
            {
                CameraManager.SwitchCamera(cam2);
            }
            else
            {
                CameraManager.SwitchCamera(cam1);
            }

        }
    }
}
