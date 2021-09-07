using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour{
    CinemachineVirtualCamera actualCamera = null;
    CinemachineVirtualCamera lastCamera = null;

    public CinemachineVirtualCamera GetActualCamera() {
        return actualCamera;
    }

    public CinemachineVirtualCamera GetLastCamera() {
        return lastCamera;
    }

    public void SwitchCamera(CinemachineVirtualCamera virtualCamera) {
        lastCamera = actualCamera;
        actualCamera = virtualCamera;
        virtualCamera.enabled = true;
        lastCamera.enabled = false;
    }
}
