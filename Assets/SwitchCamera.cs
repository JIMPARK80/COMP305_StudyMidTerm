using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField] 
    CinemachineVirtualCamera cam1;
    [SerializeField] 
    CinemachineVirtualCamera cam2;
    [SerializeField]
    CinemachineVirtualCamera cam3;

    void Awake()
    {
        CameraManager.Register(cam1);
        CameraManager.Register(cam2);
        CameraManager.Register(cam3);
        CameraManager.SwitchCamera(cam1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (CameraManager.IsActiveCamera(cam1))
            {
                CameraManager.SwitchCamera(cam2);
            }
            else if (CameraManager.IsActiveCamera(cam2))
            {
                CameraManager.SwitchCamera(cam3);
            }
            else if (CameraManager.IsActiveCamera(cam3)){
                CameraManager.SwitchCamera(cam1);
            }

        }
    }
}
