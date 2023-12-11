using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerAnimation : MonoBehaviour
{
    public GameObject[] danger;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            danger[i].GetComponent<Danger>().CheckMonster();
        }
    }
}
