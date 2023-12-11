using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger : MonoBehaviour
{
    Animator ani;
    [SerializeField] private string[] tagname; 
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckMonster()
    {
        GameObject Mon1 = GameObject.FindWithTag(tagname[0]);
        GameObject Mon2 = GameObject.FindWithTag(tagname[1]);

        if (Mon1 != null || Mon2 != null)
        {
            transform.gameObject.SetActive(true);
        }
        else if (Mon1 == null || Mon2 == null)
        {
            ani = gameObject.GetComponent<Animator>();

            ani.SetBool("Destroy", true);
            Invoke("Off", 0.8f);
        }
    }

    void Off()
    {
        gameObject.SetActive(false);
    }
}
