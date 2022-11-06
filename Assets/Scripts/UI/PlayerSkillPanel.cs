using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerSkillPanel : MonoBehaviour
{
    public GameObject[] skillButton;
    public TMP_Text[] skillButtonLabel;

    void Awake()
    {
        this.Hide();
        foreach(var btn in this.skillButton)
        {
            btn.SetActive(false);
        }

    }

    public void ConfigureButtons(int index,string NameSkills)
    {
        this.skillButton[index].SetActive(true);
        this.skillButtonLabel[index].text = NameSkills;
    }
    public void Snow()
    {
        this.gameObject.SetActive(true);
    }
    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
