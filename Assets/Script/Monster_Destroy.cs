using Spine.Unity;
using UnityEngine;

public class Monster_Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp;
    int death = 0;
    int getdamege = 0;
    [SerializeField] GameObject[] hp_;
    Enemy_Move move;
    [SerializeField] private string move_front;
    [SerializeField] private string move_side;
    [SerializeField] private string move_back;
    [SerializeField] private string death_front;
    [SerializeField] private string death_back;
    [SerializeField] private string side_attack;
    [SerializeField] private string front_attack;
    [SerializeField] private string back_attack;
    [SerializeField] private string damage_front;
    [SerializeField] private string damage_back;
    [SerializeField] private string damage_side;

    public SkeletonAnimation spn;

    private void Awake()
    {
        move = gameObject.GetComponent<Enemy_Move>();
        spn = gameObject.GetComponent<SkeletonAnimation>();
    }
    private void Update()
    {
        if (hp == 2)
        {
            if (hp_.Length == 3)
            {
                Destroy(hp_[2]);

            }

        }
        else if (hp == 1)
        {
            if (hp_.Length >= 2)
            {
                Destroy(hp_[1]);

            }

        }
        else if (hp == 0)
        {
            Destroy(hp_[0]);
            move.dir.x = 0;
            move.dir.y = 0;
            if (death == 0)
            {
                death = 1;
            }

            if (spn != null)
            {
                if (death_back != null)
                {
                    if (gameObject.CompareTag("DownEnemy") || gameObject.CompareTag("DownEnemy2"))
                    {
                        if (death == 1)
                        {
                            spn.AnimationState.SetAnimation(0, death_back, false);
                            gameObject.GetComponent<CircleCollider2D>().enabled = false;
                            death++;
                        }

                        Invoke("Death", 1.3f);
                    }
                    else
                    {
                        if (death == 1)
                        {
                            spn.AnimationState.SetAnimation(0, death_front, false);
                            gameObject.GetComponent<CircleCollider2D>().enabled = false;
                            death++;
                        }

                        Invoke("Death", 1.3f);
                    }
                }

            }

            else if(spn == null)
            {
                Death();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isPlayer = collision.gameObject.CompareTag("Player");
        if (isPlayer)
        {
            move.GetComponent<Enemy_Move>().MonStop();
            if (spn != null)
            {
                if (gameObject.CompareTag("LeftEnemy") || gameObject.CompareTag("LeftEnemy2")
                    || gameObject.CompareTag("RightEnemy") || gameObject.CompareTag("RightEnemy2"))
                {
                    spn.AnimationState.SetAnimation(0, side_attack, false);
                }
                else if (gameObject.CompareTag("UpEnemy") || gameObject.CompareTag("UpEnemy2"))
                {
                    spn.AnimationState.SetAnimation(0, front_attack, false);
                }
                else if (gameObject.CompareTag("DownEnemy") || gameObject.CompareTag("DownEnemy2"))
                {
                    spn.AnimationState.SetAnimation(0, back_attack, false);
                }
                Invoke("Death", 0.8f);
            }
            else
                Invoke("Death", 0.8f);
        }
    }

    void Death()
    {
       Destroy (gameObject);
    }

    void Idle()
    {
        if (spn != null)
        {
            if (gameObject.CompareTag("LeftEnemy") || gameObject.CompareTag("LeftEnemy2")
                || gameObject.CompareTag("RightEnemy") || gameObject.CompareTag("RightEnemy2"))
            {
                spn.AnimationState.SetAnimation(0, move_side, false);
                spn.timeScale = 1f;
            }
            else if (gameObject.CompareTag("UpEnemy") || gameObject.CompareTag("UpEnemy2"))
            {
                spn.AnimationState.SetAnimation(0, move_front, false);
                spn.timeScale = 1f;
            }
            else if (gameObject.CompareTag("DownEnemy") || gameObject.CompareTag("DownEnemy2"))
            {
                spn.AnimationState.SetAnimation(0, move_back, false);
                spn.timeScale = 1f;
            }
        }
    }
}

