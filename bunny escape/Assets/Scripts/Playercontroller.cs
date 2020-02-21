using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    

    Rigidbody2D rb;
    float Xinput;
    public float moveSpeed;
    Vector2 newposition; //which can store two values (x,y)
    public float xPositionlimit = 2.5f;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Moveplayer();
    }

    void Moveplayer() {
       

        Xinput = Input.GetAxis("Horizontal");// value between -1 / +1
        newposition = transform.position;
        newposition.x += Xinput * moveSpeed;

        newposition.x = Mathf.Clamp(newposition.x, -xPositionlimit, xPositionlimit);

        rb.MovePosition(newposition);
        
    }

    
    
}
