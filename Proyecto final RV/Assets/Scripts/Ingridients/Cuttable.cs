using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuttable : MonoBehaviour
{
    [SerializeField] private List<Transform> ingridientParts;
    Transform goParent;

    private void Awake()
    {
        goParent = transform.parent;
        for (int i = 0; i < transform.childCount; i++)
        {
            ingridientParts.Add(transform.GetChild(i));
        }
    }

    public void Cut() 
    {
        var lastIngridient = ingridientParts[ingridientParts.Count - 1];
        lastIngridient.gameObject.GetComponent<SphereCollider>().enabled = true;
        lastIngridient.gameObject.AddComponent<Rigidbody>();
        lastIngridient.SetParent(goParent);
        ingridientParts.RemoveAt(ingridientParts.Count - 1);

    }
}
