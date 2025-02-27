using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float transitionSpeed;

    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        offset = target.position -  transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        //Var that shows where to camera should go
        Vector3 targetPosition = target.position - offset;
        transform.position = Vector3.Lerp(transform.position,targetPosition,transitionSpeed*Time.deltaTime);

    }
}
