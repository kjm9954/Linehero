using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : BaseUi
{
    public GameObject setting;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
    }
    protected override void ButtonFuncion(string btnname)
    {
        base.ButtonFuncion(btnname);
        switch (btnname)
        {
            case "Start":
                {
                    Invoke("Chage", 0.3f);
                }
                break;
            case "Setting":
                {
                    if (setting.activeInHierarchy == false)
                        setting.SetActive(true);
                }
                break;
            case "GameEnd":
                {
                    Application.Quit();
                }
                break;
            case "Infinity_Start":
                {
                    Invoke("Infinity", 0.3f);
                }
                break;
            case "In_Start":
                {
                    Invoke("InfinityStart", 0.3f);
                }
                break;
            case "Back":
                {
                    Invoke("Main", 0.3f);
                }
                break;
        }
    }
    void Chage()
    {
        SceneManager.LoadScene("CutScene");
    }
    void Infinity()
    {
        SceneManager.LoadScene("Infinity_Main");
    }
    void InfinityStart()
    {
        SceneManager.LoadScene("Infinity");
    }
    void Main()
    {
        SceneManager.LoadScene("Main");
    }
}