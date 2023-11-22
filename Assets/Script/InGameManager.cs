
using UnityEngine;

public class InGameManager : BaseUi
{
    public GameObject AttackButton;
    public GameObject Monster;
    public GameObject Over;
    public GameObject Clear;
    public float MonsterNum;
    public float MonsterLength;

    protected override void Awake()
    {
        base.Awake();
        if(gameObject.scene.name != "Infinity")
        {
            MonsterNum = Monster.GetComponent<Enemy_Manager>().spawnpoint.Length;
            MonsterLength = Monster.GetComponent<Enemy_Manager>().spawnpoint.Length;
        }

    }

    protected override void Start()
    {
        base.Start();
        
    }
    private void Update()
    {
        imgs[0].fillAmount = MonsterNum / MonsterLength;
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
            case "Over_Retry":
                {
                    Time.timeScale = 1f;
                    Debug.Log("Retry");
                    Over.GetComponent<GameOver>().OnClick_Retry();
                    
                }
                break;
            case "Clear_Retry":
                {
                    Time.timeScale = 1f;
                    Debug.Log("Retry");
                    Clear.GetComponent<GameClear>().OnClick_Retry();
                }
                break;
            case "Over_Back":
                {
                    Over.GetComponent<GameOver>().OnClick_Back();
                }
                break;
            case "Clear_Back":
                {
                    Clear.GetComponent<GameClear>().OnClick_Back();
                }
                break;
        }
    }

    protected void MonsterBar()
    {
        int MaxMonster = Monster.GetComponent<Enemy_Manager>().spawnpoint.Length;

    }
}