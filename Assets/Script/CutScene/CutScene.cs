using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class CutScene : MonoBehaviour
{
    public int cutnum;

    public Image background;

    public GameObject cut1;
    public GameObject cut2;
    public GameObject cut3;
    public GameObject cut4;

    void Awake()
    {
        cutnum = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            cutnum++;
        }

        if (cutnum == 1)
        {
            cut1.SetActive(false);
            cut2.SetActive(true);
        }
        if (cutnum == 2)
        {
            cut2.SetActive(false);
            cut3.SetActive(true);
        }
        if (cutnum == 3)
        {
            cut3.SetActive(false);
            cut4.SetActive(true);
        }

        if (cutnum == 4)
        {
            SceneManager.LoadScene("Stage_Select");
        }
    }
}
