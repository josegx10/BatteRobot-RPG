using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CombatStatus
{
    WAITING_FOR_FIGHTER,
    FIGHTER_ACTION,
    CHECK_FOR_VICTORY,
    NEXT_TURN
}
public class CombatManager : MonoBehaviour
{
    public Fighter[] fighters;
    private int fightindex;

    private bool iscombatActive;

    private CombatStatus combatstatus;
    private Skills currentFighterSkill;
    void Start()
    {
        Debug.Log("Empezar Comabate");
        foreach(var fgtr in this.fighters)
        {
            fgtr.combatManager = this;
        }
        this.fightindex = 0;

        this.combatstatus = CombatStatus.NEXT_TURN;
        this.iscombatActive = true;
        StartCoroutine(this.CombatLoop());
    }
    IEnumerator CombatLoop()
    {
        while (this.iscombatActive)
        {
            switch (this.combatstatus)
            {
                case CombatStatus.WAITING_FOR_FIGHTER:
                    yield return null;
                    break;
                case CombatStatus.FIGHTER_ACTION:
                    Debug.Log($"{this.fighters[this.fightindex].Name} uses {currentFighterSkill.NameSkills}.");
                    yield return null;

                    currentFighterSkill.Run();
                    this.combatstatus = CombatStatus.CHECK_FOR_VICTORY;
                    currentFighterSkill = null;
                    break;
                case CombatStatus.CHECK_FOR_VICTORY:
                    foreach(var fgtr in this.fighters)
                    {
                        if (fgtr.isAlive == false)
                        {
                            this.iscombatActive = false;
                            fgtr.mostrarVida.text = "Victoria";

                        }
                        else
                        {
                            this.combatstatus = CombatStatus.NEXT_TURN;
                        }
                    }
                    break;
                case CombatStatus.NEXT_TURN:
                    yield return new WaitForSeconds(2f);

                    var CurrentTurn = this.fighters[fightindex];

                    Debug.Log($"{CurrentTurn.Name} has the turn.");
                    CurrentTurn.InitTurn();
                    this.fightindex = (this.fightindex + 1) % this.fighters.Length;
                    this.combatstatus = CombatStatus.WAITING_FOR_FIGHTER;
                    break;
            }
            
        }
    }
    public Fighter GetOpposingFighter()
    {
        if (this.fightindex == 0)
        {
            return this.fighters[1];
        }
        else
        {
            return this.fighters[0];
        }
    }

    public void OnFighterSkill(Skills skills)
    {
        this.currentFighterSkill = skills;
        this.combatstatus = CombatStatus.FIGHTER_ACTION;
    }
}
