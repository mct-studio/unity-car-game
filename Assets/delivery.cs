using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delivery : MonoBehaviour

{
     void OnCollisionEnter2D(Collision2D other) 
     {
        Debug.Log("Abur Cubur");
     }

  void OnTriggerEnter2D(Collider2D other)
  {
    
    if (other.tag == "Package")
  {
    Debug.Log("Package picked up");
  }
  }
}