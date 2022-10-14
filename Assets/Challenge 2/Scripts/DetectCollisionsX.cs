using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    // upon entering the collider trigger of "other", destroy this gameObject
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
