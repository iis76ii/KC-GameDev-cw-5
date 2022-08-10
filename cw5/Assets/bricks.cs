using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricks : MonoBehaviour
{
     void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
