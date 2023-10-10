using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LineManager : MonoBehaviour
{
    public GameObject attack;
    public bool monsterAttack;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }


    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        bool isEnemy = collision.gameObject.CompareTag("Enemy");
        if (isEnemy)
        {
            if (attack.GetComponent<Attack>().attack)
            {
                Debug.Log("Attack");
                attack.GetComponent<Attack>().attack = false;
                monsterAttack = true;
            }
        }
    }
}
