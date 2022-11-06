using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Fighter : MonoBehaviour
{
    public string Name;
    public CombatManager combatManager;
    public TMP_Text mostrarVida;
    protected Stats stats;

    protected virtual void Start()
    {
        mostrarVida.text += stats.HealtNucleo;
    }

    public void ModifyHealth(float amont)
    {
        this.stats.HealtNucleo = Mathf.Clamp(this.stats.HealtNucleo+amont,0f,this.stats.MaxHealtNucleo);
    }
    public abstract void InitTurn();
           
}
