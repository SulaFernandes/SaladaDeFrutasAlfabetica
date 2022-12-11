using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocarSons : MonoBehaviour

{
    public AudioSource audioSource;
    public AudioClip[] audioClips;

    public void tocarSonsLetras()
    {
        //audioSource.Play();
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.PlayOneShot(audioSource.clip);
    }
}
