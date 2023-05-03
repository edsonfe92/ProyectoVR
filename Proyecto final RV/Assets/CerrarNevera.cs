using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarNevera : MonoBehaviour
{
    public void Rotar()
    {
        transform.Rotate(90 * Vector3.up, Space.World);
    }
}
