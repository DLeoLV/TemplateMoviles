using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalSceneManager : MonoBehaviour
{
    public void CargarEscena(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }

    public void DescargarEscena(string sceneName)
    {
        SceneManager.UnloadSceneAsync(sceneName);
    }
}