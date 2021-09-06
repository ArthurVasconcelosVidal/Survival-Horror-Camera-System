using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour{
    Vector2 leftStick;

    void OnLeftStick(InputValue inputValue) {
        leftStick = inputValue.Get<Vector2>();
    }

    public Vector2 GetLeftStick() {
        return leftStick;
    }
}
