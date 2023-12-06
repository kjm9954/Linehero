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
        }
        else if (player.GetComponent<Player>().spn.AnimationName == "victory")
        {
            audioSource.clip = audioClip[0];
            audioSource.Play();
        }
    }
}
