
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageManager : BaseUi
{
    // Start is called before the first frame update
    public Sprite[] sprites;
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
        StageSpritesChange();
    }

    private void Update()
    {
        
    }

    protected override void ButtonFuncion(string btnname)
    {
        base.ButtonFuncion(btnname);
        switch(btnname)
        {
            case "Stage1":
                Debug.Log("Stage1");
                SceneManager.LoadScene("Stage1");
                break;
            case "Stage2":
                SceneManager.LoadScene("Stage2");
                break;
            case "Stage3":
                break;
                
            case "Back":
                SceneManager.LoadScene("Main");
                break;
        }
    }
    
    void StageSpritesChange()
    {
        if (GameData.StageNum >= 2)
        {
            GameObject.Find("Stage1").GetComponent<Image>().sprite = sprites[0];
            GameObject.Find("Stage2").GetComponent<Button>().interactable = true;
            if (GameData.StageNum >= 3)
            {
                GameObject.Find("Stage2").GetComponent<Image>().sprite = sprites[0];
                GameObject.Find("Stage3").GetComponent<Button>().interactable = true;
            }
        }
    }
}
