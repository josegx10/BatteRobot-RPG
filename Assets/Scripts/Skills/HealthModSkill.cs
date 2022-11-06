using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HealthModType
{
    STAT_BASED,FIXED,DEFENCE_AUM
}
public class HealthModSkill : Skills
{
    [Header("Health Mod")]
    public float amount;

    public HealthModType modType;

    public bool ModeDefence;

    protected override void OnRun()
    {
        
        
         this.amount = this.GetModification();
         this.receiver.ModifyHealth(amount);

        if (ModeDefence == false)
        {
            this.receiver.ModifyDefence(amount);
        }
    }

    public float GetModification()
    {
        switch (this.modType)
        {
            case HealthModType.STAT_BASED:
                Stats emitterStats = this.emitter.GetCurrentStats();
                Stats receiverStats = this.receiver.GetCurrentStats();

                float rowdamage = (((2 * 5) / 5) + 2) * amount * (emitterStats.Ataque / receiverStats.Defensa);
                return (rowdamage / 50) + 2;

            case HealthModType.FIXED:
                return this.amount;
            case HealthModType.DEFENCE_AUM:
                return 0;
        }
        throw new System.InvalidOperationException("HealthModDamage");
    }
}
