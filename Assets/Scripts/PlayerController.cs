using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // sonsuz runner?
    public float speed = 5f;

    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed,0,speed) * Time.deltaTime);
     
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Engel"))
        {
           
           _rigidbody.AddForce(Vector3.back * 10f);
            Debug.Log("aslhdşa");
        }
    }
}
