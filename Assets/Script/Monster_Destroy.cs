using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class Monster_Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp;
    [SerializeField] GameObject[] hp_; 

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
}
