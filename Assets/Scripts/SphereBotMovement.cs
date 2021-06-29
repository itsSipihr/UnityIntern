using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBotMovement : MonoBehaviour
{
    public float speed;
    public float turningSpeed;
    private Rigidbody rb;
    public float force;
    private bool isKeyDown = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Vector3 direction = Vector3.zero;

        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        rb.AddForce(direction * force);

        //Yukari cikmak icin basit bir cozum
        //Y axis uzerinde force ekleyerek yaptim

        if (Input.GetKey(KeyCode.Space))
            rb.AddForce(Vector3.up * force);

        /*
         //Kodun bu kismi inputa bagli olarak(Space yukari, E asagi) force uyguluyor.
         //Fakat gravityyi degistirmek icin Left Shift'e uzun basmak gerekiyor, bu bir cesit bug oldu. Cozum onerilerinizi bekliyorum.
         
        if (rb.useGravity)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && !isKeyDown)
            {
                isKeyDown = true;
                rb.useGravity = false;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.E))
                rb.AddForce(Vector3.down * force);
            if (Input.GetKeyDown(KeyCode.LeftShift) && isKeyDown)
            {
                isKeyDown = false;
                rb.useGravity = true;
            }
        }
        */
    }
}
