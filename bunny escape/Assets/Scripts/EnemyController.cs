using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
   public float rotationspeed;
   public GameObject dust;

    
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0,0,rotationspeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameManager.instance.Gameover();
            
        }
        else if(collision.gameObject.tag == "Ground") {

            GameManager.instance.GameScore();
            gameObject.SetActive(false);
            GameObject dusteffect =   Instantiate(dust, transform.position, Quaternion.identity);
             
            Destroy(dusteffect,2f);
            Destroy(gameObject,2f);
        }
    }
}
