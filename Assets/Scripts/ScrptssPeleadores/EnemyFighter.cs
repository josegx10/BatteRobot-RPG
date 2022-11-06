using UnityEngine;

public class EnemyFighter : Fighter
{
    void Awake()
    {
        this.stats = new Stats(25, 30, 100, 250);
    }
    public override void InitTurn()
    {
        
    }
}
