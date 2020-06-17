using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float maxSpeed;
    public Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            velocity = new Vector3(velocity.x, Input.GetAxisRaw("Vertical") * maxSpeed, 0f);
        } else
        { 
            if (Mathf.Abs(velocity.y) < (maxSpeed * 0.25f))
            {
                velocity.y = 0;
            }
            else
            {
                velocity.y = velocity.y - (Mathf.Sign(velocity.y) * maxSpeed * Time.deltaTime);
            }
        }
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            print("you should be seeing movement");
            velocity = new Vector3(Input.GetAxisRaw("Horizontal") * maxSpeed, velocity.y, 0f);
        } else
        {
            print("heyo"); 
            if (Mathf.Abs(velocity.x) < (maxSpeed * 0.25f))
            {
                velocity.x = 0;
            } else
            {
                velocity.x = velocity.x - (Mathf.Sign(velocity.x) * maxSpeed * Time.deltaTime);
            }
        }
        transform.Translate(new Vector3(velocity.x * Time.deltaTime, velocity.y * Time.deltaTime, 0f));
    }
}
