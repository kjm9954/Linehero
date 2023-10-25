using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpineAnimation : MonoBehaviour
{
    SkeletonAnimation spn;
    // Start is called before the first frame update
    void Start()
    {
        spn = GetComponent<SkeletonAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Idle()
    {
        spn.AnimationState.SetAnimation(0, "Idle", true);
    }
    public void Attack()
    {
        spn.AnimationState.SetAnimation(0, "attack", false);
    }

    void die()
    {
        spn.AnimationState.SetAnimation(0, "attack", false);
    }
    public void Clear()
    {
        spn.AnimationState.SetAnimation(0, "victory_after", false);
    }
}
