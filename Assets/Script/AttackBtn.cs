using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AttackBtn : MonoBehaviour
{
    public GameObject leftline;
    public GameObject rightline;
    public GameObject upline;
    public GameObject downline;
    public GameObject MonManager;
    public GameObject InGame;
    public GameObject Clear;
    public GameObject skill;
    public GameObject Camera;
    public GameObject spn;
    public GameObject resultime;
    public GameObject Stage;
    public GameObject Back;
    public float wating = 0;
    GameObject Left = null;
    GameObject Right = null;
    GameObject Up = null;
    GameObject Down = null;

    private void Update()
    {
        Left = GameObject.FindWithTag("LeftEnemy2");
        Right = GameObject.FindWithTag("RightEnemy2");
        Up = GameObject.FindWithTag("UpEnemy2");
        Down = GameObject.FindWithTag("DownEnemy2");
    }
    public void DesMonster()
    {
        if (!downline.GetComponent<LineManager>().InLine &&
            !upline.GetComponent<LineManager>().InLine &&
            !rightline.GetComponent<LineManager>().InLine &&
            !leftline.GetComponent<LineManager>().InLine)
        {
            OffBtn();
            Invoke("OnBtn", wating);
        }
        if (leftline.GetComponent<LineManager>().InLine)
        {
            if(GameObject.FindWithTag("LeftEnemy"))
            {
                MonManager.GetComponent<Enemy_Manager>().KillLeftMonster();
                InGame.GetComponent<InGameManager>().MonsterNum--;
            }
            else if (GameObject.FindWithTag("LeftEnemy2"))
            {
                if (Left.GetComponent<Monster_Destroy>().hp == 3)
                {
                    MonManager.GetComponent<Enemy_Manager>().DamageLeftMonster();
                }
                else if (Left.GetComponent<Monster_Destroy>().hp == 2)
                {
                    MonManager.GetComponent<Enemy_Manager>().DamageLeftMonster();
                }
                else if (Left.GetComponent<Monster_Destroy>().hp == 1)
                {
                    MonManager.GetComponent<Enemy_Manager>().KillLeft2Monster();
                    Debug.Log("Hp 0");
                    InGame.GetComponent<InGameManager>().MonsterNum--;
                }
            }
            attck();
        }
        if (rightline.GetComponent<LineManager>().InLine)
        {
            if (GameObject.FindWithTag("RightEnemy"))
            {
                MonManager.GetComponent<Enemy_Manager>().KillRightMonster();
                InGame.GetComponent<InGameManager>().MonsterNum--;
            }
            else if (GameObject.FindWithTag("RightEnemy2"))
            {
                if (Right.GetComponent<Monster_Destroy>().hp == 3)
                {
                    MonManager.GetComponent<Enemy_Manager>().DamageRightMonster();
                }
                else if (Right.GetComponent<Monster_Destroy>().hp == 2)
                {
                    MonManager.GetComponent<Enemy_Manager>().DamageRightMonster();
                }
                else if (Right.GetComponent<Monster_Destroy>().hp == 1)
                {
                    MonManager.GetComponent<Enemy_Manager>().KillRight2Monster();
                    Debug.Log("Hp 0");
                    InGame.GetComponent<InGameManager>().MonsterNum--;
                }
            }
            attck();
        }
        if (upline.GetComponent<LineManager>().InLine)
        {
            if (GameObject.FindWithTag("UpEnemy"))
            {
                MonManager.GetComponent<Enemy_Manager>().KillUpMonster();
                InGame.GetComponent<InGameManager>().MonsterNum--;
            }
            else if (GameObject.FindWithTag("UpEnemy2"))
            {
                if (Up.GetComponent<Monster_Destroy>().hp == 3)
                {
                    MonManager.GetComponent<Enemy_Manager>().DamageUpMonster();
                }
                else if (Up.GetComponent<Monster_Destroy>().hp == 2)
                {
                    MonManager.GetComponent<Enemy_Manager>().DamageUpMonster();
                }
                else if (Up.GetComponent<Monster_Destroy>().hp == 1)
                {
                    MonManager.GetComponent<Enemy_Manager>().KillUp2Monster();
                    Debug.Log("Hp 0");
                    InGame.GetComponent<InGameManager>().MonsterNum--;
                }
            }
            attck();
        }
        if (downline.GetComponent<LineManager>().InLine)
        {
            if (GameObject.FindWithTag("DownEnemy"))
            {
                MonManager.GetComponent<Enemy_Manager>().KillDownMonster();
                InGame.GetComponent<InGameManager>().MonsterNum--;
            }
            else if (GameObject.FindWithTag("DownEnemy2"))
            {
                if (Down.GetComponent<Monster_Destroy>().hp == 3)
                {
                    MonManager.GetComponent<Enemy_Manager>().DamageDownMonster();
                }
                else if (Down.GetComponent<Monster_Destroy>().hp == 2)
                {
                    MonManager.GetComponent<Enemy_Manager>().DamageDownMonster();
                }
                else if (Down.GetComponent<Monster_Destroy>().hp == 1)
                {
                    MonManager.GetComponent<Enemy_Manager>().KillDown2Monster();
                    Debug.Log("Hp 0");
                    InGame.GetComponent<InGameManager>().MonsterNum--;
                }
            }
            attck();
        }
    }

    void ClearStage()
    {
        Clear.GetComponent<GameClear>().show();
    }
    public void OnBtn()
    {
        gameObject.GetComponent<Button>().interactable = true;
    }
    public void OffBtn()
    {
        gameObject.GetComponent<Button>().interactable = false;
    }
    void attck()
    {
        spn.GetComponent<SpineAnimation>().Attack();
        Invoke("Idle", 0.6f);
        Camera.GetComponent<CameraShake>().C_Shake();
        skill.GetComponent<Animation>().OnSkill();
        ClearAnimation();
    }
    void Idle()
    {
        spn.GetComponent<SpineAnimation>().Idle();
    }
    void ClearAnimation()
    {
        if (InGame.GetComponent<InGameManager>().MonsterNum == 0)
        {
            spn.GetComponent<SpineAnimation>().Clear();
            Back.GetComponent<Fade>().ShowBack();
            Stage.GetComponent<Stage_Clear>().Stage();
            Invoke("ClearStage", resultime.GetComponent<Result>().ClearTime);
        }
    }
}
