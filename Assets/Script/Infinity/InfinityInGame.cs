
using UnityEngine;


public class InfinityInGame: BaseUi
{
    public GameObject AttackButton;
    public GameObject Monster;
    public GameObject Over;
    public Stop stop;
    public float MonsterNum;
    public float MonsterLength;

    protected override void Awake()
    {
        base.Awake();

    }

    protected override void Start()
    {
        base.Start();

    }
    private void Update()
    {
        //imgs[0].fillAmount = MonsterNum / MonsterLength;
    }

    protected override void ButtonFuncion(string btnname)
    {
        base.ButtonFuncion(btnname);
        switch (btnname)
        {
            case "AttackBtn":
                {
                    AttackButton.GetComponent<InfinityAttackBtn>().DesMonster();
                    Debug.Log("Button");
                }
                break;
            case "Over_Retry":
                {
                    Time.timeScale = 1f;
                    Debug.Log("Retry");
                    Over.GetComponent<GameOver>().Click_Infinity();

                }
                break;
            case "Over_Back":
                {
                    Time.timeScale = 1f;
                    Over.GetComponent<GameOver>().Click_Infinity_Main();
                }
                break;
            case "Stop":
                {
                    stop.OnInter();
                }
                break;
            case "Continue":
                {
                    stop.OffInter();
                }
                break;
            case "Back":
                {
                    Time.timeScale = 1f;
                    Over.GetComponent<GameOver>().Click_Infinity_Main();
                }
                break;
        }
    }

    
}