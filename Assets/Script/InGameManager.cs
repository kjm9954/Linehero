using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameManager : BaseUi
{
    public GameObject AttackButton;
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
        //imgs[0].fillAmount = hp / maxhp;
    }

    protected override void ButtonFuncion(string btnname)
    {
        base.ButtonFuncion(btnname);
        switch (btnname)
        {
            case "AttackBtn":
                {
                    AttackButton.GetComponent<AttackBtn>().DesMonster();
                    Debug.Log("Button");
                }
                break;
        }
    }
}
