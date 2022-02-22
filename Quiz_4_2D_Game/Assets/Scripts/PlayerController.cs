using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int playerMovementSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 4)
            {
                transform.Translate(Vector3.right * playerMovementSpeed * Time.deltaTime);
            }
           
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -4)
            {
                transform.Translate(Vector3.left * playerMovementSpeed * Time.deltaTime);
            }
        }
    }
}
