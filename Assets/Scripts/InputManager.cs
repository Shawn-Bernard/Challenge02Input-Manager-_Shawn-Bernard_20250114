using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
//using static GameInput;

public class InputManager : MonoBehaviour, GameInput.IGameplayActions
//if not using "using static GameInput;" than it's GameInput.IGameplayActions
{
    GameInput gameInput;
    private void Start()
    {
        gameInput = new GameInput();
        gameInput.Gameplay.Enable();
        gameInput.Gameplay.SetCallbacks(this);
    }
    private void Update()
    {
        
    }
    private void Awake()
    {
        
    }
    public void OnCrouch(InputAction.CallbackContext context)
    {
        //CrouchEvent?.Invoke();
        if (context.performed)
        {
            Debug.Log("Crouch was pressed");
        }
        
    }
    //Have to have OnCrouch and OnJump when using IGameplayActions
    public void OnJump(InputAction.CallbackContext context)
    {
        //JumpEvent?.Invoke();
        if (context.performed)
        {
            Actions.JumpEvent?.Invoke();
        }
        if (context.started)
        {
            Actions.StartedEvent?.Invoke();
        }
        if (context.canceled)
        {
            Actions.CanceledEvent?.Invoke();
        }
    }

}
