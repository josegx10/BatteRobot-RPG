using UnityEngine;

public class PlayerFighter : Fighter
{
    [Header("UI")]
    public PlayerSkillPanel skillPanel;
    void Awake()
    {
        this.stats = new Stats(25, 30, 100, 250);    
    }
    public override void InitTurn()
    {
        this.skillPanel.Snow();
        for(int i=0; i < this.skills.Length; i++)
        {
            this.skillPanel.ConfigureButtons(i, this.skills[i].NameSkills);
        }
    }

    public void ExecuteSkills(int index) 
    {
        this.skillPanel.Hide();
        Skills skills = this.skills[index];

        Debug.Log($"Running {skills.NameSkills} Skill");
    }
}
