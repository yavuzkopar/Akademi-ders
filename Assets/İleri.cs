using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İleri : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime *10);
    }

    private void OnCollisionEnter(Collision collision)
    {
       
       
        VectorDrawing.score += 1;
    }
}
