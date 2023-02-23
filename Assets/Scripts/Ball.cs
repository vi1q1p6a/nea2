using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

/* Checks against else-if statement for collision logic */

    private void OnTriggerEnter(Collider other)
    {
    switch (other.gameObject.layer) {
      case 3: /* 3 is layer: Characters */
        Debug.Log("PLAYER COLLISION: DRIBBLE");
        GetComponent<Dribble>().dribbleActive();
        break;
      case 6: /* 6 is layer: Goals */
        Debug.Log("GOAL REGISTERED");
        break;
      case 7: /* 7 is layer: CornerBoundary */
        Debug.Log("BALL OUT OF BOUNDS: CORNER REGISTERED");
        break;
      case 8: /* 8 is layer: ThrowingBoundary */
        Debug.Log("BALL OUT OF BOUNDS: THROW-IN REGISTERED");
        break;
      }
    }

}