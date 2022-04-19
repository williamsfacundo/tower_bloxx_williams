using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apply_Force : MonoBehaviour
{
    [SerializeField] private float force = 200;

    private Rigidbody rb;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector3(force, 0, 0));                        
    }
}
