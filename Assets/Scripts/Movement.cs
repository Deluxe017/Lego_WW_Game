using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class Movement : MonoBehaviour
{
    public Animator anim;

    [Range(0, 1)]
    public float movementSpeed;
    public float rotationSpeed;

    private void Update()
    {
        Vector3 movementDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
        anim.SetFloat("speed", movementDirection.z);
        transform.Translate(movementDirection * movementSpeed * Time.deltaTime);

        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotationSpeed, 0));
    }
}
