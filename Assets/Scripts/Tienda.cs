using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tienda : MonoBehaviour
{
    public AudioSource AudioCash;

    public void playsoundsfx()
    {
        AudioCash.Play();
    }

    // Start is called before the first frame update
    public void BtnSalirTienda()
    {
        SceneManager.LoadScene("ejeplo");
    }

    public void Misil()
    {
        Debug.Log("Misil");
    }

    public void Cuchillo()
    {
        Debug.Log("Cuchillo");
    }

    public void Lanzallamas()
    {
        Debug.Log("Lanzallamas");
    }

}
