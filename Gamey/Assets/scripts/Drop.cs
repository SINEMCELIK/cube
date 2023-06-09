using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    MeshRenderer rend;
    Rigidbody rb;
   [SerializeField] float timeToWait = 5f;

    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        rend.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            rend.enabled = true;
            rb.useGravity = true;
            

        }
    }
}
