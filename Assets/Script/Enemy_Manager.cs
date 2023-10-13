using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Enemy_Manager: MonoBehaviour
{
    [SerializeField] private bool enableSpawn = true;
    private bool upSpawn = false;
    private bool downSpawn = false;
    private bool leftSpawn = true;
    private bool rightSpawn = false;
    public GameObject Enemy;
    private GameObject enemy;
    private GameObject leftenemy;
    public GameObject lineup;
    public GameObject lineleft;
    public GameObject linedown;
    public GameObject lineright;
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
                enemy.name = "Enemy";
                Rigidbody2D rb = enemy.GetComponent<Rigidbody2D>();
            }
            if (leftSpawn) 
            {
                leftenemy = (GameObject)Instantiate(Enemy, new Vector3(-4f, 0f, -5f), Quaternion.identity);
                leftenemy.name = "Enemy";
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
        if (lineup.GetComponent<LineManager>().monsterAttack)
        {
            Destroy(enemy.gameObject);
            lineup.GetComponent<LineManager>().monsterAttack = false;
        }
        if (lineleft.GetComponent<LineManager>().monsterAttack)
        {
            Destroy(leftenemy.gameObject);
            lineleft.GetComponent<LineManager>().monsterAttack = false;
        }
        if (linedown.GetComponent<LineManager>().monsterAttack)
        {
            Debug.Log("down");
            Destroy(enemy.gameObject);
            linedown.GetComponent<LineManager>().monsterAttack = false;
        }
        if (lineright.GetComponent<LineManager>().monsterAttack)
        {
            Destroy(enemy.gameObject);
            lineright.GetComponent<LineManager>().monsterAttack = false;
        }
    }

    
}
