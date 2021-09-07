using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TriggerCameraSwitch : MonoBehaviour{
    bool state = false;
    [SerializeField] string playerTag = "Player";
    [SerializeField] GameObject vCam1;
    [SerializeField] GameObject vCam2;

    void OnTriggerExit(Collider other){
        if (other.gameObject.CompareTag(playerTag)){
            CameraManager cameraManager = Camera.main.GetComponent<CameraManager>();
            if (!state){
                if (cameraManager.GetActualCamera() != vCam1)
                    cameraManager.SwitchCamera(vCam1);
                else
                    cameraManager.SwitchCamera(vCam2);
            }
            else{
                if (cameraManager.GetActualCamera() != vCam2)
                    cameraManager.SwitchCamera(vCam2);
                else
                    cameraManager.SwitchCamera(vCam1);
            }

            state = !state; 
        }
        
    }

}
