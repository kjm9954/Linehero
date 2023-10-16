using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBtn : MonoBehaviour
{
    public GameObject leftline;
    public GameObject rightline;
    public GameObject upline;
    public GameObject downline;
    public GameObject Mon;
    public GameObject InGame;
    public GameObject Clear;
    public bool Des;
    

    private void Awake()
    {
        
    }
    public void DesMonster()
    {
        if(leftline.GetComponent<LineManager>().InLine)
        {
            Destroy(GameObject.FindWithTag("LeftEnemy"));
            InGame.GetComponent<InGameManager>().MonsterNum--;
            if (InGame.GetComponent<InGameManager>().MonsterNum == 0)
            {
                Clear.GetComponent<GameClear>().show();
            }
        }
        if (rightline.GetComponent<LineManager>().InLine)
        {
            Destroy(GameObject.FindWithTag("RightEnemy"));
            InGame.GetComponent<InGameManager>().MonsterNum--;
            if (InGame.GetComponent<InGameManager>().MonsterNum == 0)
            {
                Clear.GetComponent<GameClear>().show();
            }
        }
        if (upline.GetComponent<LineManager>().InLine)
        {
            Destroy(GameObject.FindWithTag("UpEnemy"));
            InGame.GetComponent<InGameManager>().MonsterNum--;
            if (InGame.GetComponent<InGameManager>().MonsterNum == 0)
            {
                Clear.GetComponent<GameClear>().show();
            }
        }
        if (downline.GetComponent<LineManager>().InLine)
        {
            Destroy(GameObject.FindWithTag("DownEnemy"));
            InGame.GetComponent<InGameManager>().MonsterNum--;
            if (InGame.GetComponent<InGameManager>().MonsterNum == 0)
            {
                Clear.GetComponent<GameClear>().show();
            }
        }
        
    }
}
