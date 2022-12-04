using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;

public class Movimiento
{
    // A Test behaves as an ordinary method
    private GameObject player;
    private GameObject player2;
    private Transform playerx;
    private Transform playerz;
    [SetUp]
    public void SetUp(){
        EditorSceneManager.LoadScene("ejeplo");
        
    }

    [Test]
    public void MovimientoSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator MovimientoWithEnumeratorPasses()
    {
        player = GameObject.Find("Player");
        player2 = player;   
        yield return null;
        Assert.That(player == player2);
    }
    [UnityTest]
    public IEnumerator SeMovio()
    {
        player = GameObject.Find("Player");
        
        yield return new WaitForSeconds(5);
        player = GameObject.Find("Player");
        Assert.That(player.transform.position.x != -25 || player.transform.position.z != 0 );
    }
    [TearDown]
    public void TearDown(){
        EditorSceneManager.UnloadSceneAsync("ejeplo");
    }
}
