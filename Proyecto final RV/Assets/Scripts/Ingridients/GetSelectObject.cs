using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class GetSelectObject : MonoBehaviour
{
    public GameObject objetoInteractuado;
    private XRSocketInteractor socket;
    

    private void Start()
    {
        socket = GetComponent<XRSocketInteractor>();                
    }
   
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
