using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{

    private string obj_name;
    private bool CoinTrue;
    public void OnTriggerEnter(Collider other)
    {
       
        // only destory if object collided has "Collectable" Tag
        if (other.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
        } 

    }
}
