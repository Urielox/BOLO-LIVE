using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Controlador : MonoBehaviour
{
   public void CambiarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void CambiarEscena1(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
