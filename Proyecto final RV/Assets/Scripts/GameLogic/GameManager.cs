using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private MeshRenderer pedidoRenderer;
    [SerializeField] private Dictionary<string, Material> materialesDiccionario= new Dictionary<string, Material>();
    [SerializeField] private List<Material> materialesPedidos;

    [SerializeField] private XRSocketInteractor socketPedido;    

    [SerializeField] private GameObject platoEnviado;
    [SerializeField] private List<Dish> pedidosPosibles;
    [SerializeField] private Dish pedidoActual;    

    public float tiempoRestante = 10.0f;

    public int puntuacion = 0;


    private void Start()
    {
        materialesDiccionario.Add("Pizza", materialesPedidos[0]);
        materialesDiccionario.Add("Hamburguesa", materialesPedidos[1]);
        materialesDiccionario.Add("Ensalada", materialesPedidos[2]);
        StartCoroutine(CuentaAtras());
        
    }

    IEnumerator CuentaAtras()
    {
        while (tiempoRestante > 0)
        {
            yield return new WaitForSeconds(1);
            tiempoRestante--;
        }

        pedidoActual = pedidosPosibles[Random.Range(0, 3)];
        ActualizarPedidoRender();
        tiempoRestante = 60.0f;
        StartCoroutine(CuentaAtras());
    }

    public void ActualizarPedidoRender() 
    {
        pedidoRenderer.material = materialesDiccionario[pedidoActual.name];
    }
    public void ComprobarPedido()
    {        
        platoEnviado = GetObjectInSocket(GetObjectInSocket(socketPedido).GetComponent<XRSocketInteractor>());        

        if (CompararPedido(platoEnviado, pedidoActual))
        {
            puntuacion += 1;
        }

    }

    public bool CompararPedido(GameObject plato, Dish pedidoActual)
    {
        var listaIngredientesPlato = plato.GetComponent<ListaIngredientes>().listaIngredientes;
        HashSet<string> hashSet1 = new HashSet<string>(listaIngredientesPlato);
        HashSet<string> hashSet2 = new HashSet<string>(pedidoActual.listaIngredientes);

        return hashSet1.SetEquals(hashSet2);
    }

    public void ResetZonaEnvio()
    {
        platoEnviado = null;
    }
    private GameObject GetObjectInSocket(XRSocketInteractor socket) 
    {        
        IXRSelectInteractable obj = socket.GetOldestInteractableSelected();        
        return obj.transform.gameObject; ;
    }
}
