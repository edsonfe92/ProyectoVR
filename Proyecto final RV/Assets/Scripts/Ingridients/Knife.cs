using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Knife : MonoBehaviour
{
    [SerializeField]private bool hasCollided = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (hasCollided) return;
        
        var go = collision.transform;
        if (go.CompareTag("Cuttable"))
        {
            Vector3 contactPoint = collision.contacts[0].point;
            go.GetComponent<Cuttable>().Cut(contactPoint);
            hasCollided = true;            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("Cuttable"))
        {
            hasCollided = false;
        }
    }


}
