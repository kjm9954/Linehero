using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class GameData
{
    public static int StageNum = 1;
    // Start is called before the first frame update
    public void StageClear()
    {
        StageNum++;
    }
}
