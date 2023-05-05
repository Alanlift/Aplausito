using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoLanzamiento : MonoBehaviour
{
    public Transform [] WayPoints;
    public Transform Pelota;
    private MaquinaDeEstadosPel maquinaDeEstadosPel;
    private int siguienteWayPoint;

    void Awake()
    {
        maquinaDeEstadosPel = GetComponent<MaquinaDeEstadosPel>();
    }

    void Update()
    {
        
    }
    void OnEnable() {
        siguienteWayPoint = Random.Range(0,6);
        Pelota.position = (WayPoints[siguienteWayPoint].position) + new Vector3(0, 10, 0);
    }
    //La pelota se choca al jugador
    public void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Recogepelotas"))
        {
            maquinaDeEstadosPel.ActivarEstado(maquinaDeEstadosPel.EstadoReinicio);
        }
    }
}
