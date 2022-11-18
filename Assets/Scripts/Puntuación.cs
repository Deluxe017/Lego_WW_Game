using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuación : MonoBehaviour
{
    private int puntuacion;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        puntuacion = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Moneda")
        {
            puntuacion++;
            scoreText.text = "" + puntuacion;
        }
    }
}
