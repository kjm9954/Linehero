using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int hp;

    public GameObject lefthp;
    public GameObject centerhp;
    public GameObject righthp;
    public GameObject over;
    public GameObject Monster;
    public GameObject Hit;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isLeftEnemy = collision.gameObject.CompareTag("LeftEnemy");
        bool isRightEnemy = collision.gameObject.CompareTag("RightEnemy");
        bool isUpEnemy = collision.gameObject.CompareTag("UpEnemy");
        bool isDownEnemy = collision.gameObject.CompareTag("DownEnemy");
        bool isLeftEnemy_hp2 = collision.gameObject.CompareTag("LeftEnemy2");
        bool isRightEnemy_hp2 = collision.gameObject.CompareTag("RightEnemy2");
        bool isUpEnemy_hp2 = collision.gameObject.CompareTag("UpEnemy2");
        bool isDownEnemy_hp2 = collision.gameObject.CompareTag("DownEnemy2");
        if (isLeftEnemy || isDownEnemy || isRightEnemy || isUpEnemy ||
            isLeftEnemy_hp2 || isRightEnemy_hp2 || isUpEnemy_hp2 || isDownEnemy_hp2)
        {
            Debug.Log("Enemy");
            hp--;
            Damage();
            Hit.GetComponent<Animation>().OnSkill();
        }
    }

    void Damage()
    {
        if (hp == 2)
        {
            Destroy(righthp.gameObject);
            Array.Resize(ref Monster.GetComponent<Enemy_Manager>().spawnpoint, Monster.GetComponent<Enemy_Manager>().spawnpoint.Length + 1);
            Monster.GetComponent<Enemy_Manager>().randomMon();
        }
        else if (hp == 1) 
        {
            Destroy(centerhp.gameObject);
            Array.Resize(ref Monster.GetComponent<Enemy_Manager>().spawnpoint, Monster.GetComponent<Enemy_Manager>().spawnpoint.Length + 1);
            Monster.GetComponent<Enemy_Manager>().randomMon();
        }
        else if (hp == 0)
        {
            Destroy(lefthp.gameObject);
            Time.timeScale = 0;
            over.GetComponent<GameOver>().show();
        }
    }


}
