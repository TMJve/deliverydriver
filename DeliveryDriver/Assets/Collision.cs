using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("OUCH MF!");
  }


  private void OnTriggerEnter2D(Collider2D other)
  {
    Debug.Log("Timer starts Now!");
  }
}
