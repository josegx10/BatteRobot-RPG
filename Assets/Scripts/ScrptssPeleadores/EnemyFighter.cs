using System.Collections;
using UnityEngine;

public class EnemyFighter : Fighter
{
    void Awake()
    {
        this.stats = new Stats(25, 30, 100, 250);
    }
    public override void InitTurn()
    {
        StartCoroutine(IA());
    }

    IEnumerator IA()
    {
        yield return new WaitForSeconds(1f);
        
        Skills skill = this.skills[Random.Range(0,this.skills.Length)];

        skill.SetEmitterAndReceiver(
            this,this.combatManager.GetOpposingFighter()
            );
        this.combatManager.OnFighterSkill(skill);
    }

}
