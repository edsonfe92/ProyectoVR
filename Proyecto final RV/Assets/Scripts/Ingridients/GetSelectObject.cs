using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class GetSelectObject : MonoBehaviour
{
    public GameObject objetoInteractuado;
    public XRSocketInteractor socket;   
   
    public void CheckSocket() 
    {
        IXRSelectInteractable obj = socket.GetOldestInteractableSelected();
        objetoInteractuado = obj.transform.gameObject;
    }
    public void ResetCheck()
    {
        objetoInteractuado = null;
    }

}
