using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoReinicio : MonoBehaviour
{
    private MaquinaDeEstadosPel maquinaDeEstadosPel;

    void Awake()
    {
        maquinaDeEstadosPel = GetComponent<MaquinaDeEstadosPel>();
    }
    //Te lo morfas y vuelve a aparecer
    public void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            maquinaDeEstadosPel.ActivarEstado(maquinaDeEstadosPel.EstadoLanzamiento);
        }
    }
}
