using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoEspera : MonoBehaviour
{
    public Transform PuntoBase;
    private NavMeshController controladorNavMesh;
    private MaquinaDeEstadosJug maquinaDeEstadosJug;

    void Awake()
    {
        maquinaDeEstadosJug = GetComponent<MaquinaDeEstadosJug>();
        controladorNavMesh = GetComponent<NavMeshController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            maquinaDeEstadosJug.ActivarEstado(maquinaDeEstadosJug.EstadoBusqueda);
                return;
        }
    }
    void OnEnable() {
        controladorNavMesh.ActualizarObjetivoNavMesh(PuntoBase.position);
    }
        
}
