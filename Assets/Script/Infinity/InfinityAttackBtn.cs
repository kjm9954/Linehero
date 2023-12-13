
using UnityEngine;
using UnityEngine.UI;

public class InfinityAttackBtn : MonoBehaviour
{
    public GameObject leftline;
    public GameObject rightline;
    public GameObject upline;
    public GameObject downline;
    public GameObject MonManager;
    public GameObject InGame;
    public GameObject skill;
    public GameObject Camera;
    public GameObject spn;
    public GameObject resultime;
    public GameObject Stage;
    public GameObject Back;
    public GameObject score;
    public float wating = 0;
    int random;
    public AudioClip[] attack_audio;
    Color _color;
    Image _image;
    [SerializeField] int Btn_count = 0;
    GameObject Left = null;
    GameObject Right = null;
    GameObject Up = null;
    GameObject Down = null;

    private void Start()
    {
        _image = GetComponent<Image>();
        _color = GetComponent<Image>().color;
        

    }
    private void Update()
    {
        Left = GameObject.FindWithTag("LeftEnemy2");
        Right = GameObject.FindWithTag("RightEnemy2");
        Up = GameObject.FindWithTag("UpEnemy2");
        Down = GameObject.FindWithTag("DownEnemy2");
        if (Btn_count >= 3)
        {
            _color.a = 0.7f;
            _image.color = _color;
        }
    }
    public void DesMonster()
    {
        if (!downline.GetComponent<LineManager>().InLine &&
            !upline.GetComponent<LineManager>().InLine &&
            !rightline.GetComponent<LineManager>().InLine &&
            !leftline.GetComponent<LineManager>().InLine)
        {
            OffBtn();
            Invoke("OnBtn", wating);
        }
        if (leftline.GetComponent<LineManager>().InLine)
        {
            if (GameObject.FindWithTag("LeftEnemy"))
            {
                Camera.GetComponent<CameraShake>().m_force = 2;
                Camera.GetComponent<CameraShake>().C_Shake();
                MonManager.GetComponent<InfinityStage>().KillLeftMonster();
                score.GetComponent<MonsterScore>().AddScore();
            }
            else if (GameObject.FindWithTag("LeftEnemy2"))
            {
                if (Left.GetComponent<Monster_Destroy>().hp == 3)
                {
                    Camera.GetComponent<CameraShake>().m_force = 8;
                    Camera.GetComponent<CameraShake>().C_Shake();
                    MonManager.GetComponent<InfinityStage>().DamageLeftMonster();
                }
                else if (Left.GetComponent<Monster_Destroy>().hp == 2)
                {
                    Camera.GetComponent<CameraShake>().m_force = 4;
                    Camera.GetComponent<CameraShake>().C_Shake();
                    MonManager.GetComponent<InfinityStage>().DamageLeftMonster();
                }
                else if (Left.GetComponent<Monster_Destroy>().hp == 1)
                {
                    Camera.GetComponent<CameraShake>().m_force = 2;
                    Camera.GetComponent<CameraShake>().C_Shake();
                    MonManager.GetComponent<InfinityStage>().KillLeft2Monster();
                    score.GetComponent<MonsterScore>().AddScore();
                    Debug.Log("Hp 0");
                }
            }
            attck();
        }
        if (rightline.GetComponent<LineManager>().InLine)
        {
            if (GameObject.FindWithTag("RightEnemy"))
            {
                Camera.GetComponent<CameraShake>().m_force = 2;
                Camera.GetComponent<CameraShake>().C_Shake();
                MonManager.GetComponent<InfinityStage>().KillRightMonster();
                score.GetComponent<MonsterScore>().AddScore();
            }
            else if (GameObject.FindWithTag("RightEnemy2"))
            {
                if (Right.GetComponent<Monster_Destroy>().hp == 3)
                {
                    Camera.GetComponent<CameraShake>().m_force = 8;
                    Camera.GetComponent<CameraShake>().C_Shake();
                    MonManager.GetComponent<InfinityStage>().DamageRightMonster();
                }
                else if (Right.GetComponent<Monster_Destroy>().hp == 2)
                {
                    Camera.GetComponent<CameraShake>().m_force = 4;
                    Camera.GetComponent<CameraShake>().C_Shake();
                    MonManager.GetComponent<InfinityStage>().DamageRightMonster();
                }
                else if (Right.GetComponent<Monster_Destroy>().hp == 1)
                {
                    Camera.GetComponent<CameraShake>().m_force = 2;
                    Camera.GetComponent<CameraShake>().C_Shake();
                    MonManager.GetComponent<InfinityStage>().KillRight2Monster();
                    score.GetComponent<MonsterScore>().AddScore();
                    Debug.Log("Hp 0");
                }
            }
            attck();
        }
        if (upline.GetComponent<LineManager>().InLine)
        {
            if (GameObject.FindWithTag("UpEnemy"))
            {
                Camera.GetComponent<CameraShake>().m_force = 2;
                Camera.GetComponent<CameraShake>().C_Shake();
                MonManager.GetComponent<InfinityStage>().KillUpMonster();
                score.GetComponent<MonsterScore>().AddScore();
            }
            else if (GameObject.FindWithTag("UpEnemy2"))
            {
                if (Up.GetComponent<Monster_Destroy>().hp == 3)
                {
                    Camera.GetComponent<CameraShake>().m_force = 8;
                    Camera.GetComponent<CameraShake>().C_Shake();
                    MonManager.GetComponent<InfinityStage>().DamageUpMonster();
                }
                else if (Up.GetComponent<Monster_Destroy>().hp == 2)
                {
                    Camera.GetComponent<CameraShake>().m_force = 4;
                    Camera.GetComponent<CameraShake>().C_Shake();
                    MonManager.GetComponent<InfinityStage>().DamageUpMonster();
                }
                else if (Up.GetComponent<Monster_Destroy>().hp == 1)
                {
                    Camera.GetComponent<CameraShake>().m_force = 2;
                    Camera.GetComponent<CameraShake>().C_Shake();
                    MonManager.GetComponent<InfinityStage>().KillUp2Monster();
                    score.GetComponent<MonsterScore>().AddScore();
                    Debug.Log("Hp 0");
                }
            }
            attck();
        }
        if (downline.GetComponent<LineManager>().InLine)
        {
            if (GameObject.FindWithTag("DownEnemy"))
            {
                Camera.GetComponent<CameraShake>().m_force = 2;
                Camera.GetComponent<CameraShake>().C_Shake();
                MonManager.GetComponent<InfinityStage>().KillDownMonster();
                score.GetComponent<MonsterScore>().AddScore();
            }
            else if (GameObject.FindWithTag("DownEnemy2"))
            {
                if (Down.GetComponent<Monster_Destroy>().hp == 3)
                {
                    Camera.GetComponent<CameraShake>().m_force = 8;
                    Camera.GetComponent<CameraShake>().C_Shake();
                    MonManager.GetComponent<InfinityStage>().DamageDownMonster();
                }
                else if (Down.GetComponent<Monster_Destroy>().hp == 2)
                {
                    Camera.GetComponent<CameraShake>().m_force = 4;
                    Camera.GetComponent<CameraShake>().C_Shake();
                    MonManager.GetComponent<InfinityStage>().DamageDownMonster();
                }
                else if (Down.GetComponent<Monster_Destroy>().hp == 1)
                {
                    Camera.GetComponent<CameraShake>().m_force = 2;
                    Camera.GetComponent<CameraShake>().C_Shake();
                    MonManager.GetComponent<InfinityStage>().KillDown2Monster();
                    score.GetComponent<MonsterScore>().AddScore();
                    Debug.Log("Hp 0");
                }
            }
            attck();
        }
        Btn_count++;
    }
    public void OnBtn()
    {
        gameObject.GetComponent<Button>().interactable = true;
    }
    public void OffBtn()
    {
        gameObject.GetComponent<Button>().interactable = false;
    }
    void attck()
    {
        spn.GetComponent<SpineAnimation>().Attack();
        Invoke("Idle", 0.6f);
        random = Random.Range(0, 2);
        AudioSource attack = GetComponent<AudioSource>();
        attack.clip = attack_audio[random];
        attack.Play();
        ClearAnimation();
    }
    void Idle()
    {
        spn.GetComponent<SpineAnimation>().Idle();
    }
    void ClearAnimation()
    {
        if (InGame.GetComponent<InfinityInGame>().MonsterNum == 0)
        {
            Back.GetComponent<Fade>().ShowBack();
            Stage.GetComponent<Stage_Clear>().Stage();
            Invoke("ClearStage", resultime.GetComponent<Result>().ClearTime);
        }
    }
}
