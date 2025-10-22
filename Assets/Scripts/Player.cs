using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character, InputSystem_Actions.IPlayerActions
{
    private InputSystem_Actions _actions;
    private void Awake()
    {
        base.Awake();
        _actions = new InputSystem_Actions();
        _actions.Player.SetCallbacks(this);
    }
    private void OnEnable()
    {
        _actions.Enable();
    }
    private void OnDisable()
    {
        _actions.Disable();
    }
    
    public void OnJump(InputAction.CallbackContext context)
    {
        _mb.MoveCharacter(new Vector2(transform.position.x, transform.position.y+10));
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _mb.MoveCharacter(context.ReadValue<Vector2>());
    }
}
