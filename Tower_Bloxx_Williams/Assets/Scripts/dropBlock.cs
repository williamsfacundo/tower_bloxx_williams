using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropBlock : MonoBehaviour
{
    private HingeJoint hingeJoint;
    
    private void Awake()
    {
        hingeJoint = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Destroy(hingeJoint);
            Destroy(this);
        }       
    }
}
