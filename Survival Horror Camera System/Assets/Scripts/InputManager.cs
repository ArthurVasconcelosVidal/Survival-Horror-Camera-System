using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour{
    void OnLeftStick(InputValue inputValue) {
        Debug.Log("Stick direction: " +  inputValue.Get<Vector2>());
    }
}
