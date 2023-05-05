using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abrir : MonoBehaviour
{
    // Update is called once per frame
    public void Rotar()
    {
        transform.Rotate(-90 * Vector3.left, Space.World);
    }
}
