using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameManager : BaseUi
{
    public GameObject AttackButton;
    public GameObject Monster;
    public float MonsterNum;
    protected override void Awake()
    {
        base.Awake();
        MonsterNum = Monster.GetComponent<Enemy_Manager>().spawnpoint.Length;
    }

    protected override void Start()
    {
        base.Start();
        
    }
    private void Update()
    {
        imgs[0].fillAmount = MonsterNum / Monster.GetComponent<Enemy_Manager>().spawnpoint.Length;
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

    protected void MonsterBar()
    {
        int MaxMonster = Monster.GetComponent<Enemy_Manager>().spawnpoint.Length;

    }
}
