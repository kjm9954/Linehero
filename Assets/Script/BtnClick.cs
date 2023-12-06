using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnClick : MonoBehaviour
{
    public GameObject txt;
    // Start is called before the first frame update
    private void Start()
    {
        
    }
    public void NextText()
    {
        txt.GetComponent<Clipboard>().NextText();
    }
}
