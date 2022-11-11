using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BotonesMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void NewGame()
    {
        SceneManager.LoadScene("ejeplo");
    }

    public void Continue()
    {
        SceneManager.LoadScene("ejeplo");
    }
}
