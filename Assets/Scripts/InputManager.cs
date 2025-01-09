using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using static GameInput;

public class InputManager : MonoBehaviour, IGameplayActions
//if not using "using static GameInput;" than it's GameInput.IGameplayActions
{
    GameInput gameInput;

    public void OnCrouch(InputAction.CallbackContext context)
    {
        Debug.Log("Crouch was pressed");
        CrouchEvent?.Invoke();
    }
    //Have to have OnCrouch and OnJump when using IGameplayActions
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Jump was pressed");
            JumpEvent?.Invoke();
        }
    }

    #region Public Actions

    private Action JumpEvent;
    private Action CrouchEvent;

    #endregion

    void Start()
    {
        gameInput = new GameInput();

        gameInput.Gameplay.Enable();

        gameInput.Gameplay.SetCallbacks(this);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
