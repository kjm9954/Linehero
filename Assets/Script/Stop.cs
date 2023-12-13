using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stop : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInter()
    {
        gameObject.SetActive (true);
        Time.timeScale = 0.0f;
    }

    public void OffInter()
    {
        Time.timeScale = 1.0f;
        gameObject.SetActive(false);
        Debug.Log("Stop");
    }
}
