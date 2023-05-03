using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirNevera : MonoBehaviour
{
    public void Rotar()
    {
        transform.Rotate(-90 * Vector3.up, Space.World);
    }
}
