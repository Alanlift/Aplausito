using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{

    public Transform objetivo;
    private NavMeshAgent agente;
    void Awake()
    {
        agente = GetComponent<NavMeshAgent>();
        //agente.destination = objetivo.position;
    }

    void Update()
    {
        //para que lo siga
    }

    public void ActualizarObjetivoNavMesh(Vector3 nuevoObjetivo)
    {
        agente.destination = nuevoObjetivo;
    }
    public void ActualizarObjetivoNavMesh()
    {
        ActualizarObjetivoNavMesh(objetivo.position);
    }
}
