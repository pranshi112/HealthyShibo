using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15f;
    private Vector3 pos;
    

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0, 0) * Time.deltaTime * speed);

        /*if (transform.position.x < -11f)
        {
            Vector2 pos = transform.position;
            pos.x = -11f;
            transform.position = pos;
        }
        else if(transform.position.x > 11f)
        {
            Vector2 pos = transform.position;
            pos.x = 11f;
            transform.position = pos;
        }*/

        pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x, 0.07f, 0.93f);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
