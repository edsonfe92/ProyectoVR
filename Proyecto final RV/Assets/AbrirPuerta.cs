using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    public void Rotar()
    {
        transform.Rotate(90 * Vector3.up, Space.World);
    }
}
