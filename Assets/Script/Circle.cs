using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] LineManager[] line;
    [SerializeField] CircleAnimation ani;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 4; i++) 
        {
            if (line[i].InLine == true)
            {
                ani.OnMonster();
            }
        }
    }
}
