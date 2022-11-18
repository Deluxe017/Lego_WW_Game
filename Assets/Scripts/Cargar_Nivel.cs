using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cargar_Nivel : MonoBehaviour
{
    public string cargarNivel;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(cargarNivel);
    }
}
