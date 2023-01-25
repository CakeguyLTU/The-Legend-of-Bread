using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingScript : MonoBehaviour
{

    public Rigidbody reggiebody;
    public float jumpForce;

    void Update()
    {
        if (Input.GetButtonDown("Jump") && Time.timeScale >= 1f)
        {
            reggiebody.AddForce(Vector3.up * jumpForce);
        }
    }
}
