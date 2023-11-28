using Spine.Unity;
using System;
using UnityEngine;

public class Monster_Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp;
    [SerializeField] GameObject[] hp_;
    Enemy_Move move;

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
            Destroy(hp_[2]);
        }
        else if (hp == 1)
        {
            if (hp_.Length >= 2)
            Destroy(hp_[1]);
            
        }
        else if (hp == 0)
        {
            Destroy(hp_[0]);
            move.dir.x = 0;
            move.dir.y = 0;
            if (spn != null)
            {
                if (spn.AnimationName == "M1_move")
                {
                    spn.AnimationState.SetAnimation(0, "M1_death", false);
                    Invoke("Death", 1.3f);
                }
                else if (spn.AnimationName == "M2_move_front" ||
                    spn.AnimationName == "M2_move_back")
                {
                    Death();
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
            Destroy(gameObject);

        }
    }

    void Death()
    {
       Destroy (gameObject);
    }
}
