using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public bool held;
    public GameObject obj;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        held = obj.GetComponent<InteractObject>().isHolding;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        held = obj.GetComponent<InteractObject>().isHolding;
        if(held)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
