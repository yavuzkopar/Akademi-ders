using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneYerDegistirme : MonoBehaviour
{
    public GameObject player;


    private void Update()
    {
      
      if (transform.position.z < player.transform.position.z -100f)
      {
          transform.Translate(Vector3.forward * 300f);
      }
    }

  
}
