using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class benten : MonoBehaviour
{
  

    float speedX = 0;
    float speedY = 0;
    float speedZ = -1;
    void Start()
    {
    }
    void Update()
    {
        transform.Translate(new Vector3(speedX, speedY, speedZ) * Time.deltaTime);
    }
}