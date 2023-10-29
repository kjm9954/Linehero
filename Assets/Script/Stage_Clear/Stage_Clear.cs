using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage_Clear : MonoBehaviour
{
    // Start is called before the first frame update
    public void Stage()
    {
        if(SceneManager.GetActiveScene().name == "Stage1")
        {
            if (GameData.StageNum == 1)
            {
                GameData.StageNum = 2;
            }

        }
        else if (SceneManager.GetActiveScene().name == "Stage2")
        {
            if (GameData.StageNum == 2)
            {
                GameData.StageNum = 3;
            }
        }
    }
}
