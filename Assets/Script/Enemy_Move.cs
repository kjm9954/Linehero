using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    private Vector3 dir;
    public GameObject move;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move.transform.position.x >= 320 && move.transform.position.y >= 1300)
            dir.y = -1;
        if (move.transform.position.x >= 320 && move.transform.position.y <= 0)
            dir.y = 1;
        if (move.transform.position.x >= 640 && move.transform.position.y <= 700)
            dir.x = -1;
        if (move.transform.position.x <= 0 && move.transform.position.y <= 700)
            dir.x = 1;
        move.transform.position += dir * speed * Time.deltaTime;
    }
}
