using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DetectarPlato : MonoBehaviour
{
    public XRSocketInteractor socket;
    public GameObject platillo;

    public void PlatoInteractuado() 
    {        
        IXRSelectInteractable obj = socket.GetOldestInteractableSelected();
        platillo = obj.transform.gameObject;

        if (platillo.CompareTag("Lechuga"))
        {
            platillo.transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
