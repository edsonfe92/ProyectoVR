using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var go = collision.transform;
        if (go.CompareTag("Cuttable"))
        {
            Debug.Log("CUT");
            go.GetComponent<Cuttable>().Cut();
        }
    }
}
