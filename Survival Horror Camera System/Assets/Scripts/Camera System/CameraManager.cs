using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour{
    [SerializeField] GameObject actualCamera = null;
    [SerializeField] GameObject lastCamera = null;
    
    void Start(){
        actualCamera = Camera.main.GetComponent<CinemachineBrain>().ActiveVirtualCamera.VirtualCameraGameObject;
    }

    public GameObject GetActualCamera() {
        return actualCamera;
    }

    public GameObject GetLastCamera() {
        return lastCamera;
    }

    public void SwitchCamera(GameObject virtualCamera){
        lastCamera = actualCamera;
        actualCamera = virtualCamera;
        virtualCamera.SetActive(true);
        lastCamera.SetActive(false);
    }
}
