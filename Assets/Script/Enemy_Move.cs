using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    
    public GameObject move;
    public bool Hit = false;
    public float speed;
    public Vector3 dir;
    SkeletonAnimation skani;
    public float animation_speed;
    // Start is called before the first frame update

    private void Start()
    {
        skani = GetComponent<SkeletonAnimation>();
        Hit = false;
        MonMove();
    }
    // Update is called once per frame
    void Update()
    {
        if (Hit == true)
        {
            if (move.transform.position.x <= 0f && move.transform.position.y >= 0.5f)
            {
                dir.y = 10;
            }
            if (move.transform.position.x <= 0f && move.transform.position.y <= -0.5f)
            {
                dir.y = -10;
            }
            if (move.transform.position.x >= 0.5f && move.transform.position.y <= 0.25f)
            {
                dir.x = 10;
            }
            if (move.transform.position.x <= -0.5f && move.transform.position.y <= 0.25f)
            {
                dir.x = -10;
            }
            Debug.Log("Hit");
            Hit = false;
            Invoke("MonMove", 0.1f);
        }
        transform.position += dir * speed * Time.deltaTime;
    }

    void MonMove()
    {
        if (move.transform.position.x <= 0f && move.transform.position.y >= 0.5f)
        {
            dir.y = -1;
        }
        if (move.transform.position.x <= 0f && move.transform.position.y <= -0.5f)
        {
            dir.y = 1;   
        }
        if (move.transform.position.x >= 0.5f && move.transform.position.y <= 0.25f)
        {
            dir.x = -1;
        }
        if (move.transform.position.x <= -0.5f && move.transform.position.y <= 0.25f)
        {
            dir.x = 1;
        }
        
    }
    public void MonStop()
    {
        dir.x = 0;
        dir.y = 0;
    }
    public void Back()
    {
        Debug.Log("Back");
        Hit = true;
        //rb.AddForce(new Vector2(-speed * 2, 0f));
        //Invoke("OffBack", 1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.name == "tutorial_mon(Clone)")
        {
            if (collision.gameObject.CompareTag("Line"))
            {
                MonStop();
            }
        }
    }
    void OffBack()
    {
        MonMove();
    }
}
