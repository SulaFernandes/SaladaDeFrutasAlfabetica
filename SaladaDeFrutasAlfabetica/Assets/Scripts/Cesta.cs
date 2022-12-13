using System.Runtime.Versioning;
using System.Threading;
using System.Data.SqlTypes;
using System.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class Cesta : MonoBehaviour, IDropHandler
{
    RectTransform rectTransform;
    public static int qtFrutas = 0;
    public AudioSource audioSource;  
   // public AudioClip audioclip;  
    public void OnDrop(PointerEventData eventData){

      //  audioSource = GameObject.AddComponent<AudioSource>() as audioSource;
      //  audioclip = ResourceScope.Load<AudioClip>("Imagens/JogoParte2/Audios/Tada");
      
        if(eventData.pointerDrag != null){
            GameObject droppedObject = eventData.pointerDrag;
            String nomeletra = droppedObject.name.ToString();
            string numLetra = nomeletra.Split('_')[1];
            Int16 numOrdem = Int16.Parse(numLetra);

            if(numOrdem-1 == TocarSons.tocar){
                TocarSons.tocar++;
               // Debug.Log("Nome letra: " + valor);
               // Debug.Log("Ordem do som: " + TocarSons.tocar);
                if(qtFrutas == 9){
                    audioSource.Play();
                }else{
                    qtFrutas++;
                }
            }else{
                Debug.Log("oou"); 
                Debug.Log(ArrastarESoltar.stPosition);
             //   audioSource.PlayOneShot(audioClip);

                droppedObject.transform.position = ArrastarESoltar.stPosition;
            }
          
            
        }
    }

    /*public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }*/


}
