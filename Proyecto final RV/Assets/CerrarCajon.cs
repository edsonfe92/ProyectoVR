using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarCajon : MonoBehaviour
{
    public void cerrar()
    {
        transform.localPosition = new Vector3(-0.245f, 0.704f, 0.3019f);
    }
}
