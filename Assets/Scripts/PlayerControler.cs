using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidbody2D;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal")>0)
        {
            rigidbody2D.velocity = new Vector2(speed, 0f);    
        }
       else if (Input.GetAxis("Horizontal") < 0)
        {
            rigidbody2D.velocity = new Vector2(-speed, 0f);
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            rigidbody2D.velocity = new Vector2(0f, speed);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            rigidbody2D.velocity = new Vector2(0f, -speed);
        }
        else if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)
        {
            rigidbody2D.velocity = new Vector2(0f, 0f);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {  if(other.tag == "Door")
        Debug.Log("LEVEL COMPLETE");
    }
}
