using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestingInputSystem : MonoBehaviour
{
    private Rigidbody sphereRigidBody;

    public void Awake()
    {
        sphereRigidBody = GetComponent<Rigidbody>();
    }


    public void Jump(InputAction.CallbackContext context)
    {
      if (context.performed){
        Debug.Log("Jump! " + context.phase);
        sphereRigidBody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
      }
    }
}
