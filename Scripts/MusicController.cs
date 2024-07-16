using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField]
    private AudioClip menuClip;

    [SerializeField]
    private AudioClip gameClip;

    [SerializeField]
    private AudioSource audioSource;

    public void TurnMusic()
    {
        audioSource.Stop();
        audioSource.clip = audioSource.clip == gameClip ? menuClip : gameClip; 
        audioSource.Play();
    }
}
