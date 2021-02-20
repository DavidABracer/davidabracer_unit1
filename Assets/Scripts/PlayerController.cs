using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  //rate of forward/backward movement
    public float speed = 15.0f;
    public float TurnSpeed = 15.0f;

    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
   void Update()
   {
        horizontalInput=Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //turning vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * horizontalInput);
    }
}
