using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int points = 5;


    public void OnTriggerEnter(Collider other)
    {

        // only destory if object collided has "Collectable" Tag
        if (other.CompareTag("Trap"))
        {
            damage(1);
            Debug.Log(points + "points left");
        }
    }

    //To remove some health points
    private void damage(int value)
    {

        points = points - value;


        if ( points < 1 )
        {

            //Add a Respawn function (Resets player pos, Reset player Points) 
            //Destroy(gameObject);
        }


    }

}
