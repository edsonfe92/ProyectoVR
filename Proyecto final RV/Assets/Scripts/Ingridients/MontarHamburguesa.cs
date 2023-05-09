using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontarHamburguesa : MonoBehaviour
{
    public List<GetSelectObject> attachIngredientes;
    public List<string> ingredientesHamburguesa;

    private void Start()
    {
        ingredientesHamburguesa.Add("PanAbajo");
    }
    public void TerminarHamburguesa()
    {
        ObtenerReferenciasObjetos();
        foreach (var ingrediente in attachIngredientes)
        {

        }
    }

    private void ObtenerReferenciasObjetos() 
    {
        foreach (var ingrediente in attachIngredientes)
        {
            ingredientesHamburguesa.Add(ingrediente.objetoInteractuado.tag);
        }
    }

}
