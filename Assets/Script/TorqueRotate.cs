using UnityEngine;

public class TorqueRotate : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float torqueSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddTorque(Vector3.forward * torqueSpeed * Time.deltaTime);
    }
}
