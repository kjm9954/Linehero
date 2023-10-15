using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int hp;
    public GameObject lefthp;
    public GameObject centerhp;
    public GameObject righthp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
        }
        else if (hp == 1) 
        {
            Destroy(centerhp.gameObject);
        }
        else if (hp == 0)
        {
            Destroy(lefthp.gameObject);
        }
    }
}
