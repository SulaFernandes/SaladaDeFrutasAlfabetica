using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Animais : MonoBehaviour, IDropHandler
{
    Sprite sprite1;
    Sprite sprite2;
    Sprite sprite3;
    Sprite sprite4;

    public static int acertos = 0;
    public GameObject Premio;

    AudioSource audioSource1;
    AudioClip audioClip1;
    AudioSource audioSource2;
    AudioClip audioClip2;

    void Start()
    {
        sprite1 = Resources.Load<Sprite>("Imagens/JogoParte2/formaVidro");
        sprite2 = Resources.Load<Sprite>("Imagens/JogoParte2/luva");
        sprite3 = Resources.Load<Sprite>("Imagens/JogoParte2/vila");
        sprite4 = Resources.Load<Sprite>("Imagens/JogoParte2/fone");

        audioSource1 = gameObject.AddComponent<AudioSource>() as AudioSource;
        audioClip1 = Resources.Load<AudioClip>("Imagens/JogoParte2/Audios/aaaaaaah");

        audioSource2 = gameObject.AddComponent<AudioSource>() as AudioSource;
        audioClip2 = Resources.Load<AudioClip>("Imagens/JogoParte2/Audios/oou");
    }

    RectTransform rectTransform;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.gameObject.GetComponent<Image>().sprite == sprite2 && gameObject.name == "Raposa")
            {
                eventData.pointerDrag.gameObject.GetComponent<Image>().sprite = sprite1;
                audioSource1.PlayOneShot(audioClip1);
                acertos++;
            }
            else if (eventData.pointerDrag.gameObject.GetComponent<Image>().sprite == sprite3 && gameObject.name == "Iguana")
            {
                eventData.pointerDrag.gameObject.GetComponent<Image>().sprite = sprite1;
                audioSource1.PlayOneShot(audioClip1);
                acertos++;
            }
            else if (eventData.pointerDrag.gameObject.GetComponent<Image>().sprite == sprite4 && gameObject.name == "Bonobo")
            {
                eventData.pointerDrag.gameObject.GetComponent<Image>().sprite = sprite1;
                audioSource1.PlayOneShot(audioClip1);
                acertos++;
            }
            else
                audioSource2.PlayOneShot(audioClip2);
            
            terminarJogo();
        }
    }

    AudioSource audioSource3;
    AudioClip audioClip3;

    public void terminarJogo()
    {
        if(acertos == 3)
        {
            audioSource3 = gameObject.AddComponent<AudioSource>() as AudioSource;
            audioClip3 = Resources.Load<AudioClip>("Imagens/JogoParte2/Audios/aplausos");
            audioSource3.PlayOneShot(audioClip3);
            Premio.SetActive(true);
            fecharAplicacao();
        }
    }

    public void fecharAplicacao()
    {
        Application.Quit();
    }
}
