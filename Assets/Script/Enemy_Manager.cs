using UnityEngine;

public class Enemy_Manager : MonoBehaviour
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
    public string[] spawnpoint;
    protected int i = 0;
    int random = 1;
    public float width_x;
    public float width_y;
    public float height_x;
    public float height_y;
    // Start is called before the first frame update

    protected void SpawnUp()
    {
        upenemy = (GameObject)Instantiate(Enemy[random], new Vector3(height_x, height_y, 1f), Quaternion.identity);
        upenemy.tag = "UpEnemy";
        Rigidbody2D rb = upenemy.GetComponent<Rigidbody2D>();
    }
    protected void SpawnDown()
    {
        enemy = (GameObject)Instantiate(Enemy[random], new Vector3(height_x, -height_y, 1f), Quaternion.identity);
        enemy.tag = "DownEnemy";
        Rigidbody2D rb = enemy.GetComponent<Rigidbody2D>();
    }
    protected void SpawnLeft()
    {
        leftenemy = (GameObject)Instantiate(Enemy[random], new Vector3(-width_x, width_y, 1f), Quaternion.identity);
        leftenemy.tag = "LeftEnemy";
        Rigidbody2D rb = leftenemy.GetComponent<Rigidbody2D>();
    }
    protected void SpawnRight()
    {
        rightenemy = (GameObject)Instantiate(Enemy[random], new Vector3(width_x, width_y, 1f), Quaternion.identity);
        rightenemy.tag = "RightEnemy";
        Rigidbody2D rb = rightenemy.GetComponent<Rigidbody2D>();
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

        if (time >= wating)
        {
            random = Random.Range(0, 4);
            switch (spawnpoint[i])
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
                case "2up":
                    SpawnUp_2Hp();
                    break;
                case "2right":
                    SpawnRight_2Hp();
                    break;
                case "2down":
                    SpawnDown_2Hp();
                    break;
                case "2left":
                    SpawnLeft_2Hp();
                    break;
                case "3up":
                    SpawnUp_3Hp();
                    break;
                case "3right":
                    SpawnRight_3Hp();
                    break;
                case "3down":
                    SpawnDown_3Hp();
                    break;
                case "3left":
                    SpawnLeft_3Hp();
                    break;
                case "End":
                    break;
            }
            if (i < spawnpoint.Length - 1)
            {
                i++;
            }
            else if (i == spawnpoint.Length - 1)
            {
                spawnpoint[i] = "End";
            }
            time = 0;
        }

    }

    public void randomMon()
    {
        int pos = UnityEngine.Random.Range(0, 7);
        switch (pos)
        {
            case 0:
                spawnpoint[spawnpoint.Length - 1] = "up";
                break;
            case 1:
                spawnpoint[spawnpoint.Length - 1] = "down";
                break;
            case 2:
                spawnpoint[spawnpoint.Length - 1] = "left";
                break;
            case 3:
                spawnpoint[spawnpoint.Length - 1] = "right";
                break;
            case 4:
                spawnpoint[spawnpoint.Length - 1] = "2up";
                break;
            case 5:
                spawnpoint[spawnpoint.Length - 1] = "2down";
                break;
            case 6:
                spawnpoint[spawnpoint.Length - 1] = "2left";
                break;
            case 7:
                spawnpoint[spawnpoint.Length - 1] = "2right";
                break;
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
