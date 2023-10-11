using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerMenu : MonoBehaviour
{
    [SerializeField] GameObject PanelNotificacionSalir;
    [SerializeField] string NivelMundo;  

    public void ActivarNotificacionSalir()
    {
        PanelNotificacionSalir.SetActive(true);
    }

    public void SalirSi()
    {
        Application.Quit();
        Debug.Log("Salio del juego");
    }
    public void SalirNo()
    {
        PanelNotificacionSalir.SetActive(false);
        Debug.Log("no salio del juego");
    }

    public void IniciarJuego()
    {
        SceneManager.LoadScene(NivelMundo);

        Debug.Log("Inicio el juego");
    }




}
