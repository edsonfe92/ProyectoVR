using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Sarten : MonoBehaviour
{
    public XRSocketInteractor socket;
    public GameObject platilloCocinando;
    public string tagNueva;
    public Material materialNuevo;
    public int tiempoRestante = 5;
    Coroutine contadorCocina;

    public void Cocinar() 
    {
        IXRSelectInteractable obj = socket.GetOldestInteractableSelected();
        platilloCocinando = obj.transform.gameObject;
        contadorCocina = StartCoroutine(ContadorCocinado());
    }
    public void PararContador() 
    {
        StopCoroutine(contadorCocina);
    }
    IEnumerator ContadorCocinado() 
    {
        while (tiempoRestante > 0)
        {
            yield return new WaitForSeconds(1);
            tiempoRestante--;
            if (tiempoRestante == 0)
            {                
                platilloCocinando.tag = tagNueva;
                platilloCocinando.transform.GetChild(0).gameObject.GetComponent<MeshRenderer>().material = materialNuevo;
            }
        }

    }
}
