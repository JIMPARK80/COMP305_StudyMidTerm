using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraShake : MonoBehaviour
{
    public Transform cameraTransform = default;
    private Vector3 originalPosOfCam = default;
    public float shakeFrequency = default;

    // Start is called before the first frame update
    void Start()
    {
        originalPosOfCam = cameraTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            CameraShakeCall();
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            StopShakeCall();
        }
    }

    private void CameraShakeCall()
    {
        cameraTransform.position = originalPosOfCam + Random.insideUnitSphere * shakeFrequency;
    }

    private void StopShakeCall()
    {
        cameraTransform.position = originalPosOfCam;
    }
}
