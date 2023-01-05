using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class Mover : MonoBehaviour
{
    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("Я нажал W");
    }
}
