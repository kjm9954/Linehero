using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]
public class Tutorial
{
    public string EventName;
    public int id;
}
[System.Serializable]
public class TextEvent
{
    public Tutorial tutorial;
}
public class Clipboard : MonoBehaviour
{
    public GameObject btn;
    public GameObject click;
    public GameObject Monster;
    public GameObject Monster2;
    public Text tx;
    bool tuto = false;
    public bool montuto = false;
    bool damtuto = false;
    private string m_text;
    public TextEvent[] textevents;
    int _id = 1;
    public float wating;
    float time;
    List<Dictionary<string, object>> data_Dialog;
    private void Start()
    {
        btn.GetComponent<AttackBtn>().OffBtn();
        data_Dialog = CSVReader.Read("Test");
        tx = gameObject.GetComponent<Text>();
        //data_Dialog[i][«‡¿Ã∏ß]
        for (int i = 0; i < data_Dialog.Count; i++)
        {
            if (data_Dialog[i]["Number"].ToString() == _id.ToString())
            {
                m_text = (string)data_Dialog[i]["Content"];
            }
        
        }
        StartMethod();

    }

    private void Update()
    {
        time += Time.deltaTime;

        if (time >= wating)
        {
            NextText();
            
        }
        if (btn.GetComponent<AttackBtn>().tuto == true && tuto == false)
        {
            click.GetComponent<Fade>().ShowOut();
            NextText();
            btn.GetComponent<AttackBtn>().OffBtn();
            btn.GetComponent<AttackBtn>().tuto = false;
            tuto = true;
        }
        if (Monster.activeInHierarchy == true && montuto == false)
        {
            time = 0;
            Invoke("MonTuto", 0.2f);
        }
        if (damtuto == false)
            DamageTuto();
    }

    public void NextText()
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }

        if (_id >= 1)
        {
            _id++;
        }
        for (int i = 0; i < data_Dialog.Count; i++)
        {
            if (data_Dialog[i]["Number"].ToString() == _id.ToString())
            {
               m_text = (string)data_Dialog[i]["Content"];
            }
            if (_id == textevents[0].tutorial.id)
            {
                if (tuto == false)
                {
                    btn.GetComponent<AttackBtn>().OnBtn();
                    click.GetComponent<Fade>().ShowBack();
                }
            }
            else if (_id == textevents[1].tutorial.id)
            {
                if (Monster.activeInHierarchy == false)
                {
                    Monster.SetActive(true);
                }
            }
            else if (_id == textevents[2].tutorial.id)
            {
                if (Monster2.activeInHierarchy == false)
                {
                    if (tuto == true)
                    {
                        btn.GetComponent<AttackBtn>().OffBtn();
                    }
                    Monster2.SetActive(true);
                }
            }
            else if (_id == textevents[3].tutorial.id)
            {
                SceneManager.LoadScene("Main");
            }
        }
        StartMethod();
        time = 0;
    }

    void DamageTuto()
    {
        GameObject Hp = GameObject.Find("Hp_right");
        if (Hp == null)

        {
            damtuto = true;
            NextText();
        }
    }
    void MonTuto()
    {
        GameObject Mon2 = GameObject.FindWithTag("UpEnemy");
        if (Mon2 == null)
        {
            if (montuto == false)
                NextText();
            montuto = true;
            Monster.SetActive(false);
        }
    }
    Coroutine coroutine;
    void StartMethod()
    {
        coroutine = StartCoroutine(_typing());
    }
    IEnumerator _typing()
    {
        yield return new WaitForSeconds(0.1f);
        for (int i = 0; i <= m_text.Length; i++)
        {
            tx.text = m_text.Substring(0, i);
            yield return new WaitForSeconds(0.1f);
        }
    }
}



