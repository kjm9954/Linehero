using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Enemy_Manager: MonoBehaviour
{
    [SerializeField] private bool enableSpawn = true;
    private bool upSpawn = false;
    private bool downSpawn = true;
    private bool leftSpawn = true;
    private bool rightSpawn = false;
    public GameObject Enemy;
    private GameObject enemy;
    private GameObject leftenemy;
    // Start is called before the first frame update

    void SpawnEnemies()
    {
        if (enableSpawn)
        {
            if (upSpawn)
            {

            }
            if (downSpawn) 
            {
                enemy = (GameObject)Instantiate(Enemy, new Vector3(0f, -7.5f, -5f), Quaternion.identity);
                enemy.tag = "DownEnemy";
                Rigidbody2D rb = enemy.GetComponent<Rigidbody2D>();
            }
            if (leftSpawn) 
            {
                leftenemy = (GameObject)Instantiate(Enemy, new Vector3(-4f, 0f, -5f), Quaternion.identity);
                leftenemy.tag = "LeftEnemy";
                Rigidbody2D rb = leftenemy.GetComponent<Rigidbody2D>();
            }
            if (rightSpawn)
            {

            }
            //enemy = (GameObject)Instantiate(Enemy,new Vector3(320, -50, -7),Quaternion.identity);
            
          
           
            //enemy = (GameObject)Instantiate(Enemy, new Vector3(700, 640, -5), Quaternion.identity);
        }
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 1 ,3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
