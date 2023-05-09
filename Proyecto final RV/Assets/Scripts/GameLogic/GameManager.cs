using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{    
    [SerializeField] private Transform pivotePedidos;

    [SerializeField] private XRSocketInteractor socket;
    [SerializeField] private GameObject platoEnviado;
    [SerializeField] private Dish pedidoActual;

    public int puntuacion = 0;


    private void Start()
    {
        //var pedido = Instantiate(listaPedidos[0],pivotePedidos);
        
        
    }

    public void ComprobarPedido() 
    {
        IXRSelectInteractable obj = socket.GetOldestInteractableSelected();
        platoEnviado = obj.transform.gameObject;

        if (CompararPedido(platoEnviado,pedidoActual))
        {
            puntuacion += 10;
        }        
        
    }

    public bool CompararPedido(GameObject plato, Dish pedidoActual) 
    {
        var listaIngredientesPlato = plato.GetComponent<MontarHamburguesa>().ingredientesHamburguesa;
        HashSet<string> hashSet1 = new HashSet<string>(listaIngredientesPlato);
        HashSet<string> hashSet2 = new HashSet<string>(pedidoActual.listaIngredientes);

        return hashSet1.SetEquals(hashSet2);
    }
    
    public void ResetZonaEnvio() 
    {
        platoEnviado = null;
    }
}
