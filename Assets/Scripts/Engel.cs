using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < player.transform.position.z -10f)
        {
            transform.Translate(Vector3.forward * 50f);
        }
      //  transform.Translate(Vector3.back * Time.deltaTime * 20f);
    }

  //  private void OnCollisionEnter(Collision collision)
  //  {
  //      if (collision.gameObject.CompareTag("Player"))
  //      {
  //          // player düşme animasyonu oynat
  //          // 
  //          player.GetComponent<Rigidbody>().AddForce(Vector3.back* 30f, ForceMode.Impulse);
  //      }
  //  }
}
