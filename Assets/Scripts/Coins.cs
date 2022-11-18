using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public AudioClip audioFX;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(audioFX, gameObject.transform.position);
            if(audioFX == true)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
