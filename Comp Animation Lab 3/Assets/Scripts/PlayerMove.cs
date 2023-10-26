using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.W))
            {
                rig.AddForce(new Vector3(transform.forward.x, 0, transform.forward.z).normalized, ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rig.AddForce(new Vector3(transform.forward.x, 0, transform.forward.z).normalized / -1, ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rig.AddForce(new Vector3(transform.right.x, 0, transform.right.z).normalized / -1, ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rig.AddForce(new Vector3(transform.right.x, 0, transform.right.z).normalized, ForceMode.Impulse);
            }
    }
    private void FixedUpdate()
    {

        if (rig.velocity.magnitude > 0.00125f)
        {
            rig.velocity = rig.velocity / 100f;
        }
    }
}
