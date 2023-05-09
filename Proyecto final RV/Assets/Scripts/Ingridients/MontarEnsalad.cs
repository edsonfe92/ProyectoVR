using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontarEnsalad : MonoBehaviour
{
    public List<GetSelectObject> attachIngredientes;
    [SerializeField] private ListaIngredientes listaObj;
    private void Start()
    {
        listaObj.listaIngredientes.Add("Lechuga");
    }

    public void TerminarEnsalada() 
    {
        ObtenerReferenciasObjetos();
    }
    private void ObtenerReferenciasObjetos()
    {
        foreach (var ingrediente in attachIngredientes)
        {
            listaObj.listaIngredientes.Add(ingrediente.objetoInteractuado.tag);
        }
    }
}
