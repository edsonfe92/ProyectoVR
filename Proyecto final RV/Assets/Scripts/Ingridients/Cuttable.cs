using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Cuttable : MonoBehaviour
{
    [SerializeField] private List<Transform> ingridientParts;
    public GameObject ingredienteCortado;
    Transform goParent;

    private void Awake()
    {
        goParent = transform.parent;
        for (int i = 0; i < transform.childCount; i++)
        {
            ingridientParts.Add(transform.GetChild(i));
        }
    }

    public void Cut(Vector3 posCorte) 
    {
        var lastIngridient = ingridientParts[ingridientParts.Count - 1];
        lastIngridient.gameObject.SetActive(false);
        Instantiate(ingredienteCortado,posCorte,new Quaternion(0,0,0,0));
        ingridientParts.RemoveAt(ingridientParts.Count - 1);

    }
}
