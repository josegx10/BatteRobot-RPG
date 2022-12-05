using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class irTienda : MonoBehaviour
{
    // Start is called before the first frame update
    public void atienda()
    {
        SceneManager.LoadScene("tienda");
    }
    public void ainicio()
    {
        SceneManager.LoadScene("inicio");
    }
}
