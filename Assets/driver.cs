using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.5f;

    [SerializeField] float moveSpeed = 0.05f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
      float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
      transform.Rotate(0, 0, steerAmount);
      transform.Translate(0, moveAmount, 0); 

    }
}
