using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{

    public GameObject player;
    public GameObject clear;

    public AudioSource audioSource;

    public AudioClip[] audioClip;

    private void Update()
    {
        if (player.GetComponent<Player>().hp == 0)
        {
            audioSource.clip = audioClip[1];
            audioSource.Play();
        }
        else if (clear.GetComponent<InGameManager>().MonsterNum == 0)
        {
            audioSource.clip = audioClip[0];
            audioSource.Play();
        }
        
    }
}
