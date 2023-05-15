using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontarHamburguesa : MonoBehaviour
{
    public List<GetSelectObject> attachIngredientes;    
    [SerializeField] private ListaIngredientes listaObj;

    private void Start()
    {
        listaObj.listaIngredientes.Add("PanAbajo");
    }
    public void TerminarHamburguesa()
    {
        ObtenerReferenciasObjetos();
        foreach (var ingrediente in attachIngredientes)
        {
            //quitar grab interactables y demás
        }
    }

    private void ObtenerReferenciasObjetos() 
    {
        foreach (var ingrediente in attachIngredientes)
        {
            listaObj.listaIngredientes.Add(ingrediente.objetoInteractuado.tag);
        }
    }

}
