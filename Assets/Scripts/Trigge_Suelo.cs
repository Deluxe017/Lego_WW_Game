using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigge_Suelo : MonoBehaviour
{
    public string scene;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(scene);
    }
}
