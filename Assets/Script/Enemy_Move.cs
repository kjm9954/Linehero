using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    private Vector3 dir;
    public GameObject move;
    [SerializeField] private float speed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (move.transform.position.x >= 0f && move.transform.position.y >= 7.5f)
            dir.y = -1;
        if (move.transform.position.x >= 0f && move.transform.position.y <= -7.5f)
            dir.y = 1;
        if (move.transform.position.x >= 4f && move.transform.position.y <= 0f)
            dir.x = -1;
        if (move.transform.position.x <= -4f && move.transform.position.y <= -0f)
            dir.x = 1;
        move.transform.position += dir * speed * Time.deltaTime;
    }
}
