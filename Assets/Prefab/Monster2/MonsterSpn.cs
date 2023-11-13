using Spine.Unity;
using UnityEngine;

public class MonsterSpn : MonoBehaviour
{
    public SkeletonAnimation Spn;
    public GameObject move;
    private float dir = 0.0f;
    // Start is called before the first frame update
    // Update is called once per frame
    private void Start()
    {
        dir = move.GetComponent<Enemy_Move>().dir.y;
        if (dir > 0)
        {
            Spn.AnimationState.SetAnimation(0, "M2_move_back", true);
        }
    }
}
