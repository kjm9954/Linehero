using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Enemy_Manager: MonoBehaviour
{
    public GameObject Enemy;
    private GameObject enemy;
    private GameObject leftenemy;
    private GameObject rightenemy;
    private GameObject upenemy;
    public float wating;
    private float time;
    public float[] spawnpoint;
    public int i = 0;
    
    // Start is called before the first frame update

    void SpawnUp()
    {
        upenemy = (GameObject)Instantiate(Enemy, new Vector3(0f, 7.5f, 1f), Quaternion.identity);
        upenemy.tag = "UpEnemy";
        Rigidbody2D rb = upenemy.GetComponent<Rigidbody2D>();
    }

    void SpawnDown()
    {
        enemy = (GameObject)Instantiate(Enemy, new Vector3(0f, -7.5f, 1f), Quaternion.identity);
        enemy.tag = "DownEnemy";
        Rigidbody2D rb = enemy.GetComponent<Rigidbody2D>();
    }
    void SpawnLeft()
    {
        leftenemy = (GameObject)Instantiate(Enemy, new Vector3(-4f, 0f, 1f), Quaternion.identity);
        leftenemy.tag = "LeftEnemy";
        Rigidbody2D rb = leftenemy.GetComponent<Rigidbody2D>();
    }
    void SpawnRight()
    {
        rightenemy = (GameObject)Instantiate(Enemy, new Vector3(4f, 0f, 1f), Quaternion.identity);
        rightenemy.tag = "RightEnemy";
        Rigidbody2D rb = rightenemy.GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= wating)
        {
            switch(spawnpoint[i])
            {
                case 0:
                    SpawnUp();
                    break;
                case 1:
                    SpawnRight();
                    break;
                case 2:
                    SpawnDown();
                    break;
                case 3:
                    SpawnLeft();
                    break;
            }
            if (i < spawnpoint.Length - 1)
            {
                i++;
            }
            else if (i == spawnpoint.Length - 1)
            {
                spawnpoint[i] = 4;
            }
            time = 0;
        }
        
    }

    
}
