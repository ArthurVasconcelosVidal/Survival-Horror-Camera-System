using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour{
    [SerializeField] Animator animator;

    public void SetWalkinState(float movimentMagnitute) {
        animator.SetFloat("Velocity", movimentMagnitute);
    }
}
