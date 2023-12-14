
using UnityEngine;

public class InfinityStage : MonoBehaviour
{
    public GameObject[] Enemy;
    public GameObject[] Enemy_2Hp;
    public GameObject[] Enemy_3Hp;
    protected GameObject enemy;
    protected GameObject leftenemy;
    protected GameObject rightenemy;
    protected GameObject upenemy;
    public float wating;
    protected float time;
    public float nexttime;
    public string[] pattern2;
    public string[] pattern3;
    public string[] pattern4;
    protected int i = 0;
    public int random = 1;
    public int pattenrNum = 1;
    public float enemyspeed;
    public float width_x;
    public float width_y;
    public float height_x;
    public float height_y;
    // Start is called before the first frame update

    protected void SpawnUp()
    {
        random = Random.Range(0, 4);
        int randomHp = Random.Range(0, 3);
        if (randomHp == 0) 
        {
            upenemy = (GameObject)Instantiate(Enemy[random], new Vector3(height_x, height_y, 1f), Quaternion.identity);
            upenemy.tag = "UpEnemy";
            Rigidbody2D rb = upenemy.GetComponent<Rigidbody2D>();
        }
        else if (randomHp == 1) 
        {
            SpawnUp_2Hp();
        }
        else if (randomHp == 2) 
        {
            SpawnUp_3Hp();
        }
    }
    protected void SpawnDown()
    {
        random = Random.Range(0, 4);
        int randomHp = Random.Range(0, 3);
        if (randomHp == 0)
        {
            enemy = (GameObject)Instantiate(Enemy[random], new Vector3(height_x, -height_y, 1f), Quaternion.identity);
            enemy.tag = "DownEnemy";
            Rigidbody2D rb = enemy.GetComponent<Rigidbody2D>();
        }
        else if (randomHp == 1)
        {
            SpawnDown_2Hp();
        }
        else if (randomHp == 2)
        {
            SpawnDown_3Hp();
        }

    }
    protected void SpawnLeft()
    {
        int randomHp = Random.Range(0, 3);
        if (randomHp == 0)
        {
            random = Random.Range(0, 4);
            leftenemy = (GameObject)Instantiate(Enemy[random], new Vector3(-width_x, width_y, 1f), Quaternion.identity);
            leftenemy.tag = "LeftEnemy";
            Rigidbody2D rb = leftenemy.GetComponent<Rigidbody2D>();
        }
        else if (randomHp == 1)
        {
            SpawnLeft_2Hp();
        }
        else if (randomHp == 2)
        {
            SpawnLeft_3Hp();
        }

    }
    protected void SpawnRight()
    {
        int randomHp = Random.Range(0, 3);
        if (randomHp == 0)
        {
            random = Random.Range(0, 4);
            rightenemy = (GameObject)Instantiate(Enemy[random], new Vector3(width_x, width_y, 1f), Quaternion.identity);
            rightenemy.tag = "RightEnemy";
            Rigidbody2D rb = rightenemy.GetComponent<Rigidbody2D>();
        }
        else if (randomHp == 1)
        {
            SpawnRight_2Hp();
        }
        else if (randomHp == 2)
        {
            SpawnRight_3Hp();
        }

    }
    protected void SpawnUp_2Hp()
    {
        upenemy = (GameObject)Instantiate(Enemy_2Hp[random], new Vector3(height_x, height_y, 1f), Quaternion.identity);
        upenemy.tag = "UpEnemy2";
        Rigidbody2D rb = upenemy.GetComponent<Rigidbody2D>();
    }
    protected void SpawnDown_2Hp()
    {
        enemy = (GameObject)Instantiate(Enemy_2Hp[random], new Vector3(height_x, -height_y, 1f), Quaternion.identity);
        enemy.tag = "DownEnemy2";
        Rigidbody2D rb = enemy.GetComponent<Rigidbody2D>();
    }
    protected void SpawnLeft_2Hp()
    {
        leftenemy = (GameObject)Instantiate(Enemy_2Hp[random], new Vector3(-width_x, width_y, 1f), Quaternion.identity);
        leftenemy.tag = "LeftEnemy2";
        Rigidbody2D rb = leftenemy.GetComponent<Rigidbody2D>();
    }
    protected void SpawnRight_2Hp()
    {

        rightenemy = (GameObject)Instantiate(Enemy_2Hp[random], new Vector3(width_x, width_y, 1f), Quaternion.identity);
        rightenemy.tag = "RightEnemy2";
        Rigidbody2D rb = rightenemy.GetComponent<Rigidbody2D>();
    }
    protected void SpawnUp_3Hp()
    {
        upenemy = (GameObject)Instantiate(Enemy_3Hp[random], new Vector3(height_x, height_y, 1f), Quaternion.identity);
        upenemy.tag = "UpEnemy2";
        Rigidbody2D rb = upenemy.GetComponent<Rigidbody2D>();
    }
    protected void SpawnDown_3Hp()
    {
        enemy = (GameObject)Instantiate(Enemy_3Hp[random], new Vector3(height_x, -height_y, 1f), Quaternion.identity);
        enemy.tag = "DownEnemy2";
        Rigidbody2D rb = enemy.GetComponent<Rigidbody2D>();
    }
    protected void SpawnLeft_3Hp()
    {
        leftenemy = (GameObject)Instantiate(Enemy_3Hp[random], new Vector3(-width_x, width_y, 1f), Quaternion.identity);
        leftenemy.tag = "LeftEnemy2";
        Rigidbody2D rb = leftenemy.GetComponent<Rigidbody2D>();
    }
    protected void SpawnRight_3Hp()
    {
        rightenemy = (GameObject)Instantiate(Enemy_3Hp[random], new Vector3(width_x, width_y, 1f), Quaternion.identity);
        rightenemy.tag = "RightEnemy2";
        Rigidbody2D rb = rightenemy.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        
        time += Time.deltaTime;
        if (pattenrNum == 1)
        {
            Pattern1();
        }
        else if (pattenrNum == 2)
        {
            Pattern2();
        }
        else if (pattenrNum == 3)
        {
            Pattern3();
        }
        else if (pattenrNum == 4)
        {
            Pattern4();
        }

    }

    void Pattern1()
    {
        if (time >= wating)
        {
  
            SpawnUp();
            SpawnRight();
            SpawnDown();
            SpawnLeft();
            time = nexttime * -1;
            pattenrNum = Random.Range(1, 5);
        }
    }

    void Pattern2()
    {
        if (time >= wating)
        {
            
            switch (pattern2[i])
            {
                case "up":
                    SpawnUp();
                    break;
                case "right":
                    SpawnRight();
                    break;
                case "down":
                    SpawnDown();
                    break;
                case "left":
                    SpawnLeft();
                    break;
                case "End":
                    break;
            }
            if (i < pattern2.Length - 1)
            {
                i++;
            }
            else if (i == pattern2.Length - 1)
            {
                pattenrNum = Random.Range(1, 5);
                i = 0;
            }
            time = nexttime * -1;
        }
    }

    void Pattern3()
    {
        if (time >= wating)
        {
            switch (pattern3[i])
            {
                case "up":
                    SpawnUp();
                    break;
                case "right":
                    SpawnRight();
                    break;
                case "down":
                    SpawnDown();
                    break;
                case "left":
                    SpawnLeft();
                    break;
                case "End":
                    break;
            }
            if (i < pattern3.Length - 1)
            {
                i++;
            }
            else if (i == pattern3.Length - 1)
            {
                pattenrNum = Random.Range(1, 5);
                i = 0;
            }
            time = nexttime * -1;
        }
    }

    void Pattern4()
    {
        if (time >= wating)
        {
            switch (pattern4[i])
            {
                case "up":
                    SpawnUp();
                    break;
                case "right":
                    SpawnRight();
                    break;
                case "down":
                    SpawnDown();
                    break;
                case "left":
                    SpawnLeft();
                    break;
                case "End":
                    break;
            }
            if (i < pattern4.Length - 1)
            {
                i++;
            }
            else if (i == pattern4.Length - 1)
            {
                pattenrNum = Random.Range(1, 5);
                i = 0;
            }
            time = nexttime * -1;
        }
    }
    public void DamageUpMonster()
    {
        GameObject Mon2 = GameObject.FindWithTag("UpEnemy2");
        Mon2.GetComponent<Monster_Destroy>().hp -= 1;
        Mon2.GetComponent<Enemy_Move>().Back();
    }
    public void DamageLeftMonster()
    {
        GameObject Mon2 = GameObject.FindWithTag("LeftEnemy2");
        Mon2.GetComponent<Monster_Destroy>().hp -= 1;
        Mon2.GetComponent<Enemy_Move>().Back();
    }
    public void DamageDownMonster()
    {
        GameObject Mon2 = GameObject.FindWithTag("DownEnemy2");
        Mon2.GetComponent<Monster_Destroy>().hp -= 1;
        Mon2.GetComponent<Enemy_Move>().Back();
    }
    public void DamageRightMonster()
    {
        GameObject Mon2 = GameObject.FindWithTag("RightEnemy2");
        Mon2.GetComponent<Monster_Destroy>().hp -= 1;
        Mon2.GetComponent<Enemy_Move>().Back();
    }

    public void KillUpMonster()
    {
        GameObject Mon2 = GameObject.FindWithTag("UpEnemy");
        Mon2.GetComponent<Monster_Destroy>().hp -= 1;
    }
    public void KillUp2Monster()
    {
        GameObject Mon2 = GameObject.FindWithTag("UpEnemy2");
        Mon2.GetComponent<Monster_Destroy>().hp -= 1;

    }
    public void KillDownMonster()
    {
        GameObject Mon2 = GameObject.FindWithTag("DownEnemy");
        Mon2.GetComponent<Monster_Destroy>().hp -= 1;
    }
    public void KillDown2Monster()
    {
        GameObject Mon2 = GameObject.FindWithTag("DownEnemy2");
        Mon2.GetComponent<Monster_Destroy>().hp -= 1;

    }
    public void KillLeftMonster()
    {
        GameObject Mon2 = GameObject.FindWithTag("LeftEnemy");
        Mon2.GetComponent<Monster_Destroy>().hp -= 1;
    }
    public void KillLeft2Monster()
    {
        GameObject Mon2 = GameObject.FindWithTag("LeftEnemy2");
        Mon2.GetComponent<Monster_Destroy>().hp -= 1;
    }
    public void KillRightMonster()
    {
        GameObject Mon2 = GameObject.FindWithTag("RightEnemy");
        Mon2.GetComponent<Monster_Destroy>().hp -= 1;
    }
    public void KillRight2Monster()
    {
        GameObject Mon2 = GameObject.FindWithTag("RightEnemy2");
        Mon2.GetComponent<Monster_Destroy>().hp -= 1;
    }
}
