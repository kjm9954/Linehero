using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public Vector3 dir;
    public GameObject move;
    public Rigidbody2D rb;
    [SerializeField] private float speed;
    public bool Hit = false;
    // Start is called before the first frame update

    private void Start()
    {
        Hit = false;
        rb = GetComponent<Rigidbody2D>();
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
            if (move.transform.position.x >= 0.5f && move.transform.position.y <= 0f)
            {
                dir.x = 10;
            }
            if (move.transform.position.x <= -0.5f && move.transform.position.y <= 0f)
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
        if (move.transform.position.x >= 0.5f && move.transform.position.y <= 0f)
        {
            dir.x = -1;
        }
        if (move.transform.position.x <= -0.5f && move.transform.position.y <= 0f)
        {
            dir.x = 1;
        }
        
    }
    public void Back()
    {
        Debug.Log("Back");
        Hit = true;
        //rb.AddForce(new Vector2(-speed * 2, 0f));
        //Invoke("OffBack", 1f);
    }

    void OffBack()
    {
        MonMove();
    }
}
