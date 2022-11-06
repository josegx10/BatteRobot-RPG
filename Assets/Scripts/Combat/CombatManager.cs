using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public Fighter[] fighters;
    private int fightindex;

    private bool iscombatActive;
    void Start()
    {
        Debug.Log("Empezar Comabate");
        this.fightindex = 0;

        this.iscombatActive = true;
        StartCoroutine(this.CombatLoop());
    }
    IEnumerator CombatLoop()
    {
        while (this.iscombatActive)
        {
            yield return new WaitForSeconds(2f);
            
            var CurrentTurn = this.fighters[fightindex];

            Debug.Log($"{CurrentTurn.Name} has the turn.");
            CurrentTurn.InitTurn();
            this.fightindex = (this.fightindex + 1) % this.fighters.Length;
        }
    }

}
