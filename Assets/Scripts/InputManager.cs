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
    private void Awake()
    {
        //Making a new instance of gameinput
        gameInput = new GameInput();
        //Enable my new instance of gameinput
        gameInput.Gameplay.Enable();
        gameInput.Gameplay.SetCallbacks(this);
    }
    public void OnCrouch(InputAction.CallbackContext context)
    {
        //CrouchEvent?.Invoke();
        if (context.performed)
        {
            Debug.Log("if i added another action i would put it here");
        }
        
    }
    //Have to have OnCrouch and OnJump when using IGameplayActions
    public void OnJump(InputAction.CallbackContext context)
    {
        //JumpEvent?.Invoke();
        //If the space bar is performed/pressed, I invoke the method stored in Actions.PerformedEvent
        if (context.performed)
        {
            Actions.PerformedEvent?.Invoke();
        }
        //If the space bar is performed/pressed, I invoke the method stored in Actions.StartedEvent
        if (context.started)
        {
            Actions.StartedEvent?.Invoke();
        }
        //If the space bar is let go/canceled, I invoke the method stored in Actions.CanceledEvent
        if (context.canceled)
        {
            Actions.CanceledEvent?.Invoke();
        }
    }

}
