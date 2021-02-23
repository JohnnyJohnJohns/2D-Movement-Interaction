using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public void Move(InputAction.CallbackContext context)
    {
        print(context.ReadValue<float>());
    }

    public void Jump(InputAction.CallbackContext context)
    {
        print(context.ReadValue<float>());
    }
    
}
