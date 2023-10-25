using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LineManager : MonoBehaviour
{
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
        bool isLeftEnemy_hp2 = collision.gameObject.CompareTag("LeftEnemy2");
        bool isRightEnemy_hp2 = collision.gameObject.CompareTag("RightEnemy2");
        bool isUpEnemy_hp2 = collision.gameObject.CompareTag("UpEnemy2");
        bool isDownEnemy_hp2 = collision.gameObject.CompareTag("DownEnemy2");
        if (isLeftEnemy || isDownEnemy || isRightEnemy || isUpEnemy ||
            isLeftEnemy_hp2 || isRightEnemy_hp2 || isUpEnemy_hp2 || isDownEnemy_hp2)
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
        bool isLeftEnemy_hp2 = collision.gameObject.CompareTag("LeftEnemy2");
        bool isRightEnemy_hp2 = collision.gameObject.CompareTag("RightEnemy2");
        bool isUpEnemy_hp2 = collision.gameObject.CompareTag("UpEnemy2");
        bool isDownEnemy_hp2 = collision.gameObject.CompareTag("DownEnemy2");
        if (isLeftEnemy || isDownEnemy || isRightEnemy || isUpEnemy ||
            isLeftEnemy_hp2 || isRightEnemy_hp2 || isUpEnemy_hp2 || isDownEnemy_hp2)
        {
            InLine = false;
        }
    }
}
