using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityAudio : MonoBehaviour
{
    public GameObject player;

    public AudioSource audioSource;

    public AudioClip[] audioClip;

    private void Update()
    {
        if (player.GetComponent<InfinityPlayer>().hp == 0)
        {
            audioSource.clip = audioClip[1];
            audioSource.Play();
        }
        else if (player.GetComponent<InfinityPlayer>().spn.AnimationName == "victory")
        {
            audioSource.clip = audioClip[0];
            audioSource.Play();
        }
    }
}
