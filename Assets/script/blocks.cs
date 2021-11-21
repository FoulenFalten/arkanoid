using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks : MonoBehaviour
{ 


     void OnCollisionEnter2D(Collision2D collisionInof)
        {
        Destroy(gameObject);
        }
}
