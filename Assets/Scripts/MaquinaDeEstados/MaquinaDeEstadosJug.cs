using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaDeEstadosJug : MonoBehaviour
{
    public MonoBehaviour EstadoEspera;
    public MonoBehaviour EstadoBusqueda;
    public MonoBehaviour EstadoEntrega;
    public MonoBehaviour EstadoInicial;

    private MonoBehaviour estadoActual;
    // Start is called before the first frame update
    void Start()
    {
        ActivarEstado(EstadoInicial);
    }
    public void ActivarEstado(MonoBehaviour nuevoEstado)
    {
        if(estadoActual != null) estadoActual.enabled = false;
        estadoActual = nuevoEstado;
        estadoActual.enabled = true;
    }
}
