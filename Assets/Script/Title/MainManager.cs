using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : BaseUi
{
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
                    SceneManager.LoadScene("Stage_Select");
                }
                break;
            case "Setting":
                {

                }
                break;
            case "GameEnd":
                {
                    Application.Quit();
                }
                break;
        }
    }
}