using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{

    public static bool pausado;

    [Tooltip("Referencia para o GO. Usado para ligar/desligar")]
    public GameObject menuPause;

    ///<sumary>
    ///Metodo para reiniciar a Scene, retornar ao jogo
    ///</sumary>

    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    ///<summary>
    ///Metodo para pausar o jogo
    ///</summary>
    ///<param name="isPausado">Parametro boleano que indica se o jogo será pausado</param>
    public void SetMenuPause(bool isPausado)
    {
        pausado = isPausado;
    }

    ///<sumary>
    ///Metodo para carregar uma Scene
    ///</sumary>
    ///<param name="nomeScene">nome da scene que sera carregada</param>
    public void CarregaScene(string nomeScene)
    {
        SceneManager.LoadScene(nomeScene);
    }

    //Use this for initialization
    void Start()
    {
        pausado = false;
        SetMenuPause(true);
    }

    
}
