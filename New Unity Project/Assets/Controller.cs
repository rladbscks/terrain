using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    float moveSpeed = 5.0f;
    float rotSpeed = 5.0f;
    public Camera fpsCam;
       
	// Use this for initialization
	void moveCtrl()
    {
        if (Input.GetKey(KeyCode.W))
        {
    this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
    this.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
    this.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
    this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
	void rotCnrl()
    {
        float rotX = Input.GetAxis("Mouse Y") * rotSpeed;
        float rotY = Input.GetAxis("Mouse X") * rotSpeed;
        rotX = Mathf.Clamp(rotX, -80, 80);
        this.transform.localRotation *= Quaternion.Euler(0, rotY, 0);
        fpsCam.transform.localRotation *= Quaternion.Euler(-rotX, 0, 0);
    }

	void Update () {
        moveCtrl();
        rotCnrl();
	}
}
