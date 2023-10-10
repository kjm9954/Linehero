using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isEnemy = collision.gameObject.CompareTag("Enemy");
        if (isEnemy)
        {
            Debug.Log("Enemy");
            hp--;
        }
    }
}
