using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other){

        if(other.tag == "Player"){
            SceneManager.LoadScene("Escena2");
        }
    }
}
