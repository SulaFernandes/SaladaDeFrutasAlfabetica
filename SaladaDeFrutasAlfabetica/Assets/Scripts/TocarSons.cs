using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocarSons : MonoBehaviour

{
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public static int tocar = 0;

    public void tocarSonsLetras()
    {
        if(tocar < audioClips.Length){
            audioSource.clip = audioClips[tocar];
            audioSource.PlayOneShot(audioSource.clip);
        }

    }
  
}
