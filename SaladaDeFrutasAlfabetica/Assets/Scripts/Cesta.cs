using System.Runtime.Versioning;
using System.Threading;
using System.Data.SqlTypes;
using System.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Cesta : MonoBehaviour, IDropHandler
{
    RectTransform rectTransform;
    public static int qtFrutas = 0;
    public AudioSource audioSource1;  
    public AudioClip audioClip1;

    AudioSource audioSource2;
    AudioClip audioClip2;

    public void OnDrop(PointerEventData eventData){

        audioSource1 = gameObject.AddComponent<AudioSource>() as AudioSource;
        audioClip1 = Resources.Load<AudioClip>("Imagens/JogoParte2/Audios/pop");

        audioSource2 = gameObject.AddComponent<AudioSource>() as AudioSource;
        audioClip2 = Resources.Load<AudioClip>("Imagens/JogoParte2/Audios/oou");

        if (eventData.pointerDrag != null){
            GameObject droppedObject = eventData.pointerDrag;
            String nomeletra = droppedObject.name.ToString();
            string numLetra = nomeletra.Split('_')[1];
            Int16 numOrdem = Int16.Parse(numLetra);

            if(numOrdem-1 == TocarSons.tocar){
                TocarSons.tocar++;
               // Debug.Log("Nome letra: " + valor);
               // Debug.Log("Ordem do som: " + TocarSons.tocar);
                if(qtFrutas == 9){
                    //audioSource1.PlayOneShot(audioClip1);
                }
                else{
                    qtFrutas++;
                    audioSource1.PlayOneShot(audioClip1);
                }
            }else{
                 
                Debug.Log(ArrastarESoltar.stPosition);
                audioSource2.PlayOneShot(audioClip2);

                droppedObject.transform.position = ArrastarESoltar.stPosition;
            }

            StartCoroutine(esperarSegundos());
            
        }
    }

    AudioSource audioSource3;
    AudioClip audioClip3;

    IEnumerator esperarSegundos()
    {
        if (qtFrutas == 9)
        {
            audioSource3 = gameObject.AddComponent<AudioSource>() as AudioSource;
            audioClip3 = Resources.Load<AudioClip>("Imagens/JogoParte2/Audios/aplausos");
            audioSource3.PlayOneShot(audioClip3);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(2);
        }
        
    }

}
