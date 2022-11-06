using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skills : MonoBehaviour
{
    [Header("Base Skills")]
    public string NameSkills;

    public bool SelfInflicted;

    protected Fighter emitter;
    protected Fighter receiver;

    public void Run()
    {
        if (this.SelfInflicted)
        {
            this.emitter = this.receiver;
        }
        this.OnRun();

    }

    public void SetEmitterAndReceiver(Fighter _emitter,Fighter _receiver)
    {
        this.emitter = _emitter;
        this.receiver = _receiver;
    }
    protected abstract void OnRun();

}
