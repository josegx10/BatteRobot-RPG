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

    public Skills[] skills;
    public bool isAlive
    {
        get => this.stats.HealtNucleo > 0;
    }


    protected virtual void Start()
    {
        mostrarVida.text =$"Health {Name}: "+ stats.HealtNucleo;
        this.skills = this.GetComponentsInChildren<Skills>();
    }

    public void ModifyHealth(float amont)
    {
        this.stats.HealtNucleo = Mathf.Clamp(this.stats.HealtNucleo+amont,0f,this.stats.MaxHealtNucleo);
        mostrarVida.text = $"Health {Name}: " + stats.HealtNucleo;
    }
    public Stats GetCurrentStats()
    {
        return this.stats;
    }
    public void ModifyDefence(float amont)
    {
        //Agregar MaxDefensa
        this.stats.Defensa += amont;
    }
    public abstract void InitTurn();
           
}
