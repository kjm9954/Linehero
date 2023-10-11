using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Attack : MonoBehaviour, IPointerClickHandler
{
    public bool attack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    public void OnPointerClick(PointerEventData eventData)
    {
        attack = true;
        Debug.Log("Button");
    }

}
