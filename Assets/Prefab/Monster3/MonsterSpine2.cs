using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterSpine2 : MonoBehaviour
{
    public SkeletonAnimation Spn;
    public GameObject move;
    private float dir = 0.0f;
    private float dir2 = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        dir = move.GetComponent<Enemy_Move>().dir.y;
        dir2 = move.GetComponent <Enemy_Move>().dir.x;
        if (dir > 0)
        {
            Spn.AnimationState.SetAnimation(0, "M3_move_back", true);
        }
        if (gameObject.transform.position.y == 0.25)
        {
            Spn.AnimationState.SetAnimation(0, "M3_move_side", true);
        }

        if (dir2 < 0) 
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }


    }

}
