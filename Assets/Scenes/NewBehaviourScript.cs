using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speedX = -1;
    float speedY = 0;
    float speedZ = 0;
    void Start()
    {
    }
    void Update()
    {
        transform.Translate(new Vector3(speedX, speedY, speedZ) * Time.deltaTime);
    }
}



