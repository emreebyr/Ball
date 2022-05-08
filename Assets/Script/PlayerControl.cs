/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float Speed;

    void FixedUpdate()
    {
        
        float HorizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");
        Vector3 MoveBall = new Vector3(HorizontalMovement,0,VerticalMovement);
        gameObject.transform.GetComponent<Rigidbody>().AddForce(MoveBall * Speed);
    }
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
        public Rigidbody rb;
        public float speed = 10f;
        
        
        
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //inputs & animations
        float movementHorizontal = Input.GetAxis ("Horizontal");
        float movementVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (movementHorizontal,0.0f,movementVertical);

        rb.AddForce (movement * speed ) ;

    }
}

