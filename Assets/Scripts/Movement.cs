using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class Movement : MonoBehaviour
{
    public Animator anim;
    [Range(0, 1)]

    Rigidbody rb;

    public bool golpear;

    bool JumpFloor;
    bool JumpTrue = false;
    public float jumpoForce = 5f;

    public AudioClip audio_Caminar;
    public AudioClip audio_Correr;
    public AudioClip audio_Saltar;

    public float movementSpeed;
    public float rotationSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 movementDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
        anim.SetFloat("speed", movementDirection.z);
        transform.Translate(movementDirection * movementSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotationSpeed, 0));

        if (Input.GetButtonDown("Correr"))
        {
            movementSpeed = 20f;
            
            AudioSource.PlayClipAtPoint(audio_Correr, gameObject.transform.position);

        } 
        if (Input.GetButtonUp("Correr"))
        {
            movementSpeed = 10f;

            AudioSource.PlayClipAtPoint(audio_Caminar, gameObject.transform.position);
        }

        Vector3 floor = transform.TransformDirection(Vector3.down);

        if(Physics.Raycast(transform.position, floor, 00.5f))
        {
            JumpFloor = true;
        }
        else
        {
            JumpFloor = false;
        }
        JumpTrue = Input.GetButtonDown("Jump");

        if(JumpTrue && JumpFloor)
        {
            rb.AddForce(new Vector3(0, jumpoForce, 0), ForceMode.Impulse);
            anim.SetBool("Saltar", true);
            AudioSource.PlayClipAtPoint(audio_Saltar, gameObject.transform.position);
            
        }
        if (!JumpTrue && JumpFloor)
        { 
            anim.SetBool("Saltar", false);
        }

        golpear = Input.GetMouseButtonDown(0);

        if (golpear)
        {
            anim.SetBool("Pelear", true);
        }
        if (!golpear)
        {
            anim.SetBool("Pelear", false);
        }
    }
}
