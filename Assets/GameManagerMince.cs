using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManagerMince : MonoBehaviour
{
     // Función para cargar una escena por su nombre
    public void ChangeSceneByName(string sceneName)
    {
        // Verifica si la escena está en el Build Settings
        if (SceneUtility.GetBuildIndexByScenePath(sceneName) != -1)
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("La escena " + sceneName + " no está en Build Settings.");
        }
    }

    

    // Función para salir del juego (solo funciona en el ejecutable)
    public void ExitGame()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}