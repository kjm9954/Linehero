using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMonster()
    {
        transform.gameObject.SetActive(true);
        StartCoroutine(Skill());
    }
    IEnumerator Skill()
    {
        yield return new WaitForSeconds(0.5f);
        transform.gameObject.SetActive(false);
    }
}
