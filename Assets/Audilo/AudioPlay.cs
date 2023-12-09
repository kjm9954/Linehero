using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{

    public GameObject player;

    public AudioSource audioSource;

    public AudioClip[] audioClip;
    
    private void Update()
    {
        if (player.GetComponent<Player>().hp == 0)
        {
            audioSource.clip = audioClip[1];
            audioSource.Play();
            player.GetComponent<Player>().hp--;
        }
        else if (player.GetComponent<SpineAnimation>().Vic == true) 
        {
            audioSource.clip = audioClip[0];
            audioSource.Play();
            player.GetComponent<SpineAnimation>().Vic = false;
        }
        
    }
}
