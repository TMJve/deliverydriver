using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
  // Start is called before the first frame update
  [SerializeField] float turnSpeed = 0.1f;
  [SerializeField] float gasSpeed = 0.01f;
  void Start()
  {


  }

  // Update is called once per frame
  void Update()
  {
    float steerAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
    float speedAmount = Input.GetAxis("Vertical") * gasSpeed * Time.deltaTime;
    transform.Rotate(0, 0, -steerAmount);
    transform.Translate(0, speedAmount, 0);
  }
}
