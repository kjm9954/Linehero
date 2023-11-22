using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseUi : MonoBehaviour
{
    [SerializeField]protected Image[] imgs;
    [SerializeField] protected Button[] btns; 
    protected virtual void Awake()
    {
        for(int i = 0; i < btns.Length; i++)
        {
            string name = btns[i].name;
            btns[i].onClick.AddListener(() => { ButtonOnClick(name); });
        }
    }
    // Start is called before the first frame update
    protected virtual void Start()
    {
        
    }
    void ButtonOnClick(string btnname)
    {
        ButtonFuncion(btnname);
    }
    protected virtual void ButtonFuncion(string btnname)
    {

    }
}
