using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] List<GameObject> checkpoins;
    [SerializeField] Vector3 Point;
    [SerializeField] float muerte_Lego;

    private void Update()
    {
        if(player.transform.position.y < -muerte_Lego)
        {
            player.transform.position = Point;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Point = player.transform.position;
        Destroy(other.gameObject);
    }
}
