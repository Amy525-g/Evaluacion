using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject canvasMenu; // Asigna el Canvas del menú en el Inspector

    public void Jugar()
    {
        SceneManager.LoadScene("SampleScene");
        canvasMenu.SetActive(false); // Desactiva el Canvas al cargar la escena del juego
    }


    public void Salir()
    {
        Application.Quit();
    }
}
