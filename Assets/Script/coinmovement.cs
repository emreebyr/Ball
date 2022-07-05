using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class coinmovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y == 1.8f)
        {
            transform.DOMoveY(1.6f, 1f);
        }

        if (transform.position.y == 1.6f)
        {
            transform.DOMoveY(1.8f, 1f);
        }

         if (transform.position.y == 1.3f)
        {
            transform.DOMoveY(1.5f, 1f);
        }

        if (transform.position.y == 1.5f)
        {
            transform.DOMoveY(1.3f, 1f);
        }

        if (transform.position.y == 0.6f)
        {
            transform.DOMoveY(0.8f, 1f);
        }

        if (transform.position.y == 0.8f)
        {
            transform.DOMoveY(0.6f, 1f);
        }

        if (transform.position.y == 0f)
        {
            transform.DOMoveY(0.2f, 1f);
        }

        if (transform.position.y == 0.2f)
        {
            transform.DOMoveY(0f, 1f);
        }
        
        if (transform.position.y == -0.371f)
        {
            transform.DOMoveY(-0.149f, 1f);
        }

        if (transform.position.y == -0.149f)
        {
            transform.DOMoveY(-0.371f, 1f);
        }

        if (transform.position.y == 0.253f)
        {
            transform.DOMoveY(0.477f, 1f);
        }

        if (transform.position.y == 0.477f)
        {
            transform.DOMoveY(0.253f, 1f);
        }

        if (transform.position.y == 1.9f)
        {
            transform.DOMoveY(2.1f, 1f);
        }

        if (transform.position.y == 2.1f)
        {
            transform.DOMoveY(1.9f, 1f);
        }

        
    }
}
