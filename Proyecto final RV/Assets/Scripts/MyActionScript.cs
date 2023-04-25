using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class MyActionScript : MonoBehaviour
{
    private InputAction myAction;
    [Space] [SerializeField] private InputActionAsset myActionsAsset;
    void Start()
    {
        myAction = myActionsAsset.FindAction("XRI LeftHand/My action");
        myAction.performed += OnMyAction;
    }
    void OnMyAction(InputAction.CallbackContext context)
    {
        Debug.Log("PULSADO");
    }

}
