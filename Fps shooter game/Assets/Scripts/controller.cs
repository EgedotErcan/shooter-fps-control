using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float speed;


    
    void Update()
    {
        moveInput();
    }

    void moveInput()
    {
        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 movePlayer = playerInput * speed * Time.deltaTime;
        transform.Translate(movePlayer);
    }
}
