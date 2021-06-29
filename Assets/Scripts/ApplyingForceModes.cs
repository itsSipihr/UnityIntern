using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyingForceModes : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float forceAmount = 5.0f;
    public ForceModes modes;
    public enum ForceModes
    {
        force,
        acceleration,
        impulse,
        velocityChange
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (modes)
            {
                case ForceModes.force:
                    rb.AddForce(Vector3.forward * forceAmount, ForceMode.Force);
                    break;
                case ForceModes.acceleration:
                    rb.AddForce(Vector3.forward * forceAmount, ForceMode.Acceleration);
                    break;
                case ForceModes.impulse:
                    rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
                    break;
                case ForceModes.velocityChange:
                    rb.AddForce(Vector3.forward * forceAmount, ForceMode.VelocityChange);
                    break;
            }
        }
    }
}
