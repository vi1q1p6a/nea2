using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dribble : MonoBehaviour
{
  public Transform objectToFollow;
  public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

  public void dribbleActive()
    {
      transform.position = objectToFollow.position + offset;
      
    }

    // Update is called once per frame
    void Update()
    {
    }
}
