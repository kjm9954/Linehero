using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackBtn : MonoBehaviour
{
    public GameObject leftline;
    public GameObject rightline;
    public GameObject upline;
    public GameObject downline;
    public GameObject Mon;
    public GameObject Mon_Hp2;
    public GameObject MonManager;
    public GameObject InGame;
    public GameObject Clear;
    public GameObject skill;
    public GameObject Camera;
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
                Destroy(GameObject.FindWithTag("LeftEnemy"));
                InGame.GetComponent<InGameManager>().MonsterNum--;
            }
            else if (GameObject.FindWithTag("LeftEnemy2"))
            {
                if (Left.GetComponent<Monster_Destroy>().hp == 2)
                {
                    MonManager.GetComponent<Enemy_Manager>().DamageLeftMonster();
                }
                else if (Left.GetComponent<Monster_Destroy>().hp == 1)
                {
                    Debug.Log("Hp 0");
                    Destroy(GameObject.FindWithTag("LeftEnemy2"));
                    InGame.GetComponent<InGameManager>().MonsterNum--;
                }
            }
            Camera.GetComponent<CameraShake>().C_Shake();
            skill.GetComponent<Animation>().OnSkill();
            ClearStage();
        }
        if (rightline.GetComponent<LineManager>().InLine)
        {
            if (GameObject.FindWithTag("RightEnemy"))
            {
                Destroy(GameObject.FindWithTag("RightEnemy"));
                InGame.GetComponent<InGameManager>().MonsterNum--;
            }
            else if (GameObject.FindWithTag("RightEnemy2"))
            {
                if (Right.GetComponent<Monster_Destroy>().hp == 2)
                {
                    MonManager.GetComponent<Enemy_Manager>().DamageRightMonster();
                }
                else if (Right.GetComponent<Monster_Destroy>().hp == 1)
                {
                    Debug.Log("Hp 0");
                    Destroy(GameObject.FindWithTag("RightEnemy2"));
                    InGame.GetComponent<InGameManager>().MonsterNum--;
                }
            }
            Camera.GetComponent<CameraShake>().C_Shake();
            skill.GetComponent<Animation>().OnSkill();
            ClearStage();
        }
        if (upline.GetComponent<LineManager>().InLine)
        {
            if (GameObject.FindWithTag("UpEnemy"))
            {
                Destroy(GameObject.FindWithTag("UpEnemy"));
                InGame.GetComponent<InGameManager>().MonsterNum--;
            }
            else if (GameObject.FindWithTag("UpEnemy2"))
            {
                if (Up.GetComponent<Monster_Destroy>().hp == 2)
                {
                    MonManager.GetComponent<Enemy_Manager>().DamageUpMonster();
                }
                else if (Up.GetComponent<Monster_Destroy>().hp == 1)
                {
                    Debug.Log("Hp 0");
                    Destroy(GameObject.FindWithTag("UpEnemy2"));
                    InGame.GetComponent<InGameManager>().MonsterNum--;
                }
            }
            Camera.GetComponent<CameraShake>().C_Shake();
            skill.GetComponent<Animation>().OnSkill();
            ClearStage();
        }
        if (downline.GetComponent<LineManager>().InLine)
        {
            if (GameObject.FindWithTag("DownEnemy"))
            {
                Destroy(GameObject.FindWithTag("DownEnemy"));
                InGame.GetComponent<InGameManager>().MonsterNum--;
            }
            else if (GameObject.FindWithTag("DownEnemy2"))
            {
                if (Down.GetComponent<Monster_Destroy>().hp == 2)
                {
                    MonManager.GetComponent<Enemy_Manager>().DamageDownMonster();
                }
                else if (Down.GetComponent<Monster_Destroy>().hp == 1)
                {
                    Debug.Log("Hp 0");
                    Destroy(GameObject.FindWithTag("DownEnemy2"));
                    InGame.GetComponent<InGameManager>().MonsterNum--;
                }
            }
            Camera.GetComponent<CameraShake>().C_Shake();
            skill.GetComponent<Animation>().OnSkill();
            ClearStage();
        }

        


    }

    void ClearStage()
    {
        if (InGame.GetComponent<InGameManager>().MonsterNum == 0)
        {
            Clear.GetComponent<GameClear>().show();
        }
    }

    void OnBtn()
    {
        gameObject.GetComponent<Button>().interactable = true;
    }
    void OffBtn()
    {
        gameObject.GetComponent<Button>().interactable = false;
    }
}
