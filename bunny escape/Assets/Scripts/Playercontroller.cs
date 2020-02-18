using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    // Start is called before the first frame update

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
        //a function to check the movement of the player  which consistis of two things like input
        // and  change position

        //input i will check the horizontal with respect to axis 
        

        Xinput = Input.GetAxis("Horizontal");// value between -1 / +1
        newposition = transform.position;
        newposition.x += Xinput * moveSpeed;

        newposition.x = Mathf.Clamp(newposition.x, -xPositionlimit, xPositionlimit);

        rb.MovePosition(newposition);
        
    }

    //extrahealth
    void superPower() {
        //if score is greater than 14 then a mode which lasts for 3 secs 
        //and enemies comes faster but u  can kill them
       
       /* if( )
        {
            print("score is greater and player has power");
        }
        */
    }
}
