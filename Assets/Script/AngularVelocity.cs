using UnityEngine;
using UnityEngine.InputSystem;

public class AngularVelocity : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float angularSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            //rb.angularVelocity = new Vector3(0, angularSpeed, 0);
            rb.angularVelocity = Vector3.up * angularSpeed;
        }
        else
        {
            rb.angularVelocity = Vector3.zero;  
        }
    }
}
