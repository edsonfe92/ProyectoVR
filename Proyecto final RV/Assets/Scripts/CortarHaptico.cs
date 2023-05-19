using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CortarHaptico : MonoBehaviour
{
    void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        interactable.selectEntered.AddListener(Cut);
    }
    void Cut(BaseInteractionEventArgs args)
    {
        if (args.interactorObject is XRBaseControllerInteractor interactor)
        {
            Debug.Log("VIBRAR");
            interactor.SendHapticImpulse(0.5f, 1);
        }
    }

}
