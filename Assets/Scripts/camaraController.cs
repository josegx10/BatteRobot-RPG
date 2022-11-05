using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraController : MonoBehaviour
{
    public Transform personaje;
    private float distanciaX = 30f;
    private float velocidadCam = 0f;
    public bool suavizadoActive = true;
    private Vector3 nuevaPosicion;
    void Update()
    {
        nuevaPosicion = this.transform.position;
        nuevaPosicion.x = personaje.transform.position.x;
        nuevaPosicion.z = personaje.transform.position.z - distanciaX;
        if(suavizadoActive){
            this.transform.position = Vector3.Lerp(this.transform.position, nuevaPosicion, velocidadCam*Time.deltaTime);

        }else {
            this.transform.position = nuevaPosicion;
        }
    }

    
}
