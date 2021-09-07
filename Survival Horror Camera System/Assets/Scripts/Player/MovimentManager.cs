using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentManager : MonoBehaviour{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] Vector2 leftStick; //Visualization purpose
    [SerializeField] float velocity;
    Vector3 fowardCamDirection = Vector3.zero;
    Vector3 rightCamDirection = Vector3.zero;
    [SerializeField]Vector3 actualDirection = Vector3.zero;

    void FixedUpdate(){
        Moviment();
    }

    void Moviment() {
        leftStick = playerManager.inputManager.GetLeftStick();

        actualDirection = fowardCamDirection.normalized * leftStick.y + rightCamDirection.normalized * leftStick.x;

        if (actualDirection != Vector3.zero){
            playerManager.rigidbody.MovePosition(transform.position + actualDirection.normalized * velocity * Time.deltaTime);
            MeshRotation(actualDirection);
        }
        else
            SetCamDirections();
    }

    void MeshRotation(Vector3 direction) {
        playerManager.meshObject.transform.rotation = Quaternion.LookRotation(direction, playerManager.meshObject.transform.up);
    }

    void SetCamDirections() {
        fowardCamDirection = Vector3.ProjectOnPlane(playerManager.cameraManager.GetActualCamera().transform.forward, transform.up);
        rightCamDirection = Vector3.ProjectOnPlane(playerManager.cameraManager.GetActualCamera().transform.right, transform.up);
    }
}
