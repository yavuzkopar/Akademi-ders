using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorDrawing : MonoBehaviour
{
    [SerializeField] private GameObject hedef;
    public static int score = 0;

    public TMPro.TextMeshProUGUI scoretext;

    private float gra = -9.81f;
    private bool isOnGround = false;


    
    
    void Update()
    {
        
        scoretext.text = score.ToString();
        float h = Input.GetAxis("Horizontal"); // ad -1 1
        float v = Input.GetAxis("Vertical"); // ws -1 1

        float angle = Vector3.Angle(transform.forward, hedef.transform.position - transform.position);
        transform.Translate(new Vector3(h,0,v) * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.P))
        {
            // 1- obje oluşturulacak            
            GameObject go = Instantiate(hedef, transform.position + new Vector3(0, 1, 2),Quaternion.identity);
        }
        if (angle <= 90)
        {
           MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
           meshRenderer.material.color = Color.green;
           


           //  transform.Translate((Vector3.forward * Time.deltaTime *5));
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }

    private void OnCollisionExit(Collision other)
    {
        isOnGround = false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position,hedef.transform.position);
        Gizmos.color = Color.red;
        float mesafe = Vector3.Distance(transform.position, hedef.transform.position);
        Gizmos.DrawLine(transform.position,transform.forward);
    }
}
