using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerrar : MonoBehaviour
{
    public void Rotar()
    {
        transform.Rotate(90 * Vector3.left, Space.World);
    }
}
