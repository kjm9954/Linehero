
using Spine.Unity;
using System;
using UnityEngine;



public class Player : MonoBehaviour
{
    [SerializeField] private int hp;

    public GameObject lefthp;
    public GameObject centerhp;
    public GameObject righthp;
    public GameObject over;
    public GameObject Monster;
    public GameObject Hit;
    public GameObject bt;
    public GameObject resultime;
    SkeletonAnimation spn;
    float time;
    // Start is called before the first frame update

    private void Start()
    {
        Application.targetFrameRate = 60;
       spn = GetComponent<SkeletonAnimation>();
    }
    private void Update()
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
            Debug.Log("Enemy");
            hp--;
            Damage();
            Hit.GetComponent<Animation>().OnSkill();
            
        }
    }

    void Damage()
    {
        if (hp == 2)
        {
            Destroy(righthp.gameObject);
            Array.Resize(ref Monster.GetComponent<Enemy_Manager>().spawnpoint, Monster.GetComponent<Enemy_Manager>().spawnpoint.Length + 1);
            Monster.GetComponent<Enemy_Manager>().randomMon();
            spn.AnimationState.SetAnimation(0, "hit", false);
            Invoke("Idle", 1f);
        }
        else if (hp == 1) 
        {
            Destroy(centerhp.gameObject);
            Array.Resize(ref Monster.GetComponent<Enemy_Manager>().spawnpoint, Monster.GetComponent<Enemy_Manager>().spawnpoint.Length + 1);
            Monster.GetComponent<Enemy_Manager>().randomMon();
            spn.AnimationState.SetAnimation(0, "hit", false);
            Invoke("Idle", 1f);
        }
        else if (hp == 0)
        {
            Destroy(lefthp.gameObject);
            spn.AnimationState.SetAnimation(0, "die", false);
            bt.GetComponent<AttackBtn>().OffBtn();
            Invoke("Over", resultime.GetComponent<Result>().FailedTime);
        }
    }

    void Idle()
    {
        spn.AnimationState.SetAnimation(0, "Idle", true);
    }

    void Over()
    {
        over.GetComponent<GameOver>().show();
        Time.timeScale = 0f;
    }
}
