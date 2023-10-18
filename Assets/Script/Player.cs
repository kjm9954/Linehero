using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int hp;

    public GameObject lefthp;
    public GameObject centerhp;
    public GameObject righthp;
    public GameObject over;
    public GameObject Monster;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isLeftEnemy = collision.gameObject.CompareTag("LeftEnemy");
        bool isRightEnemy = collision.gameObject.CompareTag("RightEnemy");
        bool isUpEnemy = collision.gameObject.CompareTag("UpEnemy");
        bool isDownEnemy = collision.gameObject.CompareTag("DownEnemy");
        if (isLeftEnemy || isDownEnemy || isRightEnemy || isUpEnemy)
        {
            Debug.Log("Enemy");
            hp--;
            Damage();
        }
    }

    void Damage()
    {
        if (hp == 2)
        {
            Destroy(righthp.gameObject);
            int pos = UnityEngine.Random.Range(0, 3);
            Array.Resize(ref Monster.GetComponent<Enemy_Manager>().spawnpoint, Monster.GetComponent<Enemy_Manager>().spawnpoint.Length + 1);
            Monster.GetComponent<Enemy_Manager>().spawnpoint[Monster.GetComponent<Enemy_Manager>().spawnpoint.Length - 1] = pos;
        }
        else if (hp == 1) 
        {
            Destroy(centerhp.gameObject);
            int pos = UnityEngine.Random.Range(0, 3);
            Array.Resize(ref Monster.GetComponent<Enemy_Manager>().spawnpoint, Monster.GetComponent<Enemy_Manager>().spawnpoint.Length + 1);
            Monster.GetComponent<Enemy_Manager>().spawnpoint[Monster.GetComponent<Enemy_Manager>().spawnpoint.Length - 1] = pos;
        }
        else if (hp == 0)
        {
            Destroy(lefthp.gameObject);
            Time.timeScale = 0;
            over.GetComponent<GameOver>().show();
        }
    }
}
