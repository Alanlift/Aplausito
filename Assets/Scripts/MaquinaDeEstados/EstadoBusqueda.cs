using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoBusqueda : MonoBehaviour
{
    public float duracionBusqueda = 6f;
    private NavMeshController controladorNavMesh;
    private MaquinaDeEstadosJug maquinaDeEstadosJug;
    private float tiempoBuscando;

    void Awake()
    {
        maquinaDeEstadosJug = GetComponent<MaquinaDeEstadosJug>();
        controladorNavMesh = GetComponent<NavMeshController>();
    }

    // Update is called once per frame
    void Update()
    {
        tiempoBuscando += Time.deltaTime;
        if (Input.GetKey("space"))
        {
            controladorNavMesh.ActualizarObjetivoNavMesh();
                return;
        }
        if (tiempoBuscando >= duracionBusqueda){
            maquinaDeEstadosJug.ActivarEstado(maquinaDeEstadosJug.EstadoEspera);
            return;
        }
    }
    void OnEnable() {
        tiempoBuscando = 0f;
        controladorNavMesh.ActualizarObjetivoNavMesh();
    }
        public void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Pelota") && enabled)
        {
            maquinaDeEstadosJug.ActivarEstado(maquinaDeEstadosJug.EstadoEntrega);
        }
    }
}
