using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    // Start is called before the first frame update
    private void Awake()
    {
        transform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void show()
    {
        transform.gameObject.SetActive(true);
    }

    public void OnClick_Retry()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void Click_Infinity()
    {
        SceneManager.LoadScene("Infinity");
    }

    public void Click_Infinity_Main()
    {
        SceneManager.LoadScene("Infinity_Main");
    }
    public void OnClick_Back()
    {
        SceneManager.LoadScene("Stage_Select");
    }
}
