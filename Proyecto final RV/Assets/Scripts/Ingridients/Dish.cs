using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Nuevo Plato", menuName = "Platos/Nuevo Plato")]
public class Dish : ScriptableObject
{
    public List<string> listaIngredientes;
    public string nombre;
}
