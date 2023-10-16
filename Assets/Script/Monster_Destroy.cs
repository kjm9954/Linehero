using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class Monster_Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public bool InLine;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isPlayer = collision.gameObject.CompareTag("Player");
        if (isPlayer)
        {
            Destroy(gameObject);

        }
        

    }


}
