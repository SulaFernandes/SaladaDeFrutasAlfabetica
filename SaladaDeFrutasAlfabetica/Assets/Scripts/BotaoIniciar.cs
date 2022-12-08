using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoIniciar : MonoBehaviour
{
    public  void abrirScene(string nome)
    {
        SceneManager.LoadScene(nome);
    }
        
   
}
