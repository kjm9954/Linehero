using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LineManager : MonoBehaviour
{
    public GameObject attack;
    public bool InLine;
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
            InLine = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        bool isLeftEnemy = collision.gameObject.CompareTag("LeftEnemy");
        bool isRightEnemy = collision.gameObject.CompareTag("RightEnemy");
        bool isUpEnemy = collision.gameObject.CompareTag("UpEnemy");
        bool isDownEnemy = collision.gameObject.CompareTag("DownEnemy");
        if (isLeftEnemy || isDownEnemy || isRightEnemy || isUpEnemy)
        {
            InLine = false;
        }
    }
}
