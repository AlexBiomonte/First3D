using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCollision : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {

        Debug.Log("Death");
        Destroy(other.gameObject);
    }
}
