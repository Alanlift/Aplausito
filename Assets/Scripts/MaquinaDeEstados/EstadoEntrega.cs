using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoEntrega : MonoBehaviour
{
    public float velocidadGiro = 40f;
    public GameObject Pelota;
    public Transform Recogedor;
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
         RaycastHit hit;
        Pelota.transform.Rotate(0f, velocidadGiro, 0f);
        if(PuedeVerBloque(out hit)){
            Pelota.transform.position = hit.transform.position + new Vector3(0, 1, 0);
            maquinaDeEstadosJug.ActivarEstado(maquinaDeEstadosJug.EstadoEspera);
            return;
        }
    }
    void FixedUpdate() {
        Pelota.transform.position = Recogedor.position + new Vector3(0, 1, 0);
    }
    
    public bool PuedeVerBloque(out RaycastHit hit)
    {
        return Physics.Raycast(Pelota.transform.position - new Vector3(0, 1, 0), Pelota.transform.forward, out hit, 1f) && hit.collider.CompareTag("Bloque");
    }

    void OnEnable() {
        maquinaDeEstadosJug = GetComponent<MaquinaDeEstadosJug>();
        controladorNavMesh = GetComponent<NavMeshController>();
        Pelota.transform.position = Recogedor.position + new Vector3(0, 1, 0);
        controladorNavMesh.ActualizarObjetivoNavMesh();
    }
}
