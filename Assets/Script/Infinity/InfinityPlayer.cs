
using Spine.Unity;
using UnityEngine;

public class InfinityPlayer: MonoBehaviour
{
    public int hp;
    int random;
    public AudioClip[] hit_audio;
    public GameObject lefthp;
    public GameObject centerhp;
    public GameObject righthp;
    public GameObject over;
    public GameObject Monster;
    public GameObject Hit;
    public GameObject bt;
    public GameObject resultime;
    public GameObject BackGround;
    public SkeletonAnimation spn;
    // Start is called before the first frame update

    private void Start()
    {

        spn = GetComponent<SkeletonAnimation>();
    }
    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isLeftEnemy = collision.gameObject.CompareTag("LeftEnemy");
        bool isRightEnemy = collision.gameObject.CompareTag("RightEnemy");
        bool isUpEnemy = collision.gameObject.CompareTag("UpEnemy");
        bool isDownEnemy = collision.gameObject.CompareTag("DownEnemy");
        bool isLeftEnemy_hp2 = collision.gameObject.CompareTag("LeftEnemy2");
        bool isRightEnemy_hp2 = collision.gameObject.CompareTag("RightEnemy2");
        bool isUpEnemy_hp2 = collision.gameObject.CompareTag("UpEnemy2");
        bool isDownEnemy_hp2 = collision.gameObject.CompareTag("DownEnemy2");
        if (isLeftEnemy || isDownEnemy || isRightEnemy || isUpEnemy ||
            isLeftEnemy_hp2 || isRightEnemy_hp2 || isUpEnemy_hp2 || isDownEnemy_hp2)
        {
            Debug.Log("Enemy");
            hp--;
            Damage();
            Hit.GetComponent<Animation>().OnSkill();

        }
    }

    void Damage()
    {
        if (hp == 2)
        {
            Destroy(righthp.gameObject);
            spn.AnimationState.SetAnimation(0, "hit", false);
            OnSound();
            Invoke("Idle", 1f);
        }
        else if (hp == 1)
        {
            Destroy(centerhp.gameObject);
            spn.AnimationState.SetAnimation(0, "hit", false);
            OnSound();
            Invoke("Idle", 1f);
        }
        else if (hp == 0)
        {
            Destroy(lefthp.gameObject);
            spn.AnimationState.SetAnimation(0, "die", false);
            BackGround.GetComponent<Fade>().ShowBack();
            bt.GetComponent<InfinityAttackBtn>().OffBtn();
            OnSound();
            Invoke("Over", resultime.GetComponent<Result>().FailedTime);
        }
    }

    void Idle()
    {
        spn.AnimationState.SetAnimation(0, "Idle", true);
    }

    void Over()
    {
        over.GetComponent<GameOver>().show();
        Time.timeScale = 0f;
    }

    void OnSound()
    {
        random = UnityEngine.Random.Range(0, 2);
        AudioSource hit = GetComponent<AudioSource>();
        hit.clip = hit_audio[random];
        hit.Play();
    }
}
