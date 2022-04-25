/*
* Gerard Lamoureux
* Assignment 8
* Handles Destruction of objects
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }
}
