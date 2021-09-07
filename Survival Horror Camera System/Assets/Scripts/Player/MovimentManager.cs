using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentManager : MonoBehaviour{
    [SerializeField] PlayerManager playerManager;
    [SerializeField] Vector2 leftStick; //Visualization purpose
    [SerializeField] float velocity;

    void FixedUpdate(){
        Moviment();
    }

    void Moviment() {
        leftStick = playerManager.inputManager.GetLeftStick();
        Vector3 direction = new Vector3(leftStick.x, 0, leftStick.y);
        if (direction != Vector3.zero){
            playerManager.rigidbody.MovePosition(transform.position + direction.normalized * velocity * Time.deltaTime);
            MeshRotation(direction);
        }
    }

    void MeshRotation(Vector3 direction) {
        playerManager.meshObject.transform.rotation = Quaternion.LookRotation(direction, playerManager.meshObject.transform.up);
    }

    Vector3 RelativeToCamDirection() {
        return Vector3.zero;
    }
}
