using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveonClick : MonoBehaviour
{
    public GameObject gameObject;
    public Vector3 originalPosition;
    public Vector3 newPosition;
    private bool windowAtStart;
    private bool outerwallAtStart;
    private bool innerwallAtStart;
    private bool roofAtStart;
    private bool floorAtStart;

    private void Start()
    {
        gameObject.transform.position = originalPosition;
        windowAtStart = true;
        outerwallAtStart = true;
        innerwallAtStart = true;
        roofAtStart = true;
        floorAtStart = true;

    }
    


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit rayCastHit;
            Ray rayCast = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(rayCast, out rayCastHit))
            {

                if (rayCastHit.collider.CompareTag("window"))
                {
                    if (windowAtStart == true)
                    {
                        gameObject.transform.position = newPosition;
                        windowAtStart = false;
                    }
                    else if (windowAtStart == false)
                    {
                        gameObject.transform.position = originalPosition;
                        windowAtStart = true;
                    }
                }

                if (rayCastHit.collider.CompareTag("Outerwall"))
                {
                    if (outerwallAtStart == true)
                    {
                        gameObject.transform.position = newPosition;
                        outerwallAtStart = false;
                    }
                    else if (outerwallAtStart == false)
                    {
                        gameObject.transform.position = originalPosition;
                        outerwallAtStart = true;
                    }
                    
                }

                if (rayCastHit.collider.CompareTag("Innerwall"))
                {
                    if (innerwallAtStart == true)
                    {
                        gameObject.transform.position = newPosition;
                        innerwallAtStart = false;
                    }
                    
                    else if (innerwallAtStart == false)
                    {
                        gameObject.transform.position = originalPosition;
                        innerwallAtStart = true;
                    }
                }

                if (rayCastHit.collider.CompareTag("Roof"))
                {
                    if (roofAtStart == true)
                    {
                        
                        gameObject.transform.position = newPosition;
                        roofAtStart = false;
                    }
                    
                    else if (roofAtStart == false)
                    {
                        gameObject.transform.position = originalPosition;
                        roofAtStart = true;
                    }
                }

                if (rayCastHit.collider.CompareTag("Groundfloor"))
                {
                    if (floorAtStart == true)
                    {
                        gameObject.transform.position = newPosition;
                        floorAtStart = false;
                    }
                    
                    else if (floorAtStart == false)
                    {
                        gameObject.transform.position = originalPosition;
                        floorAtStart = true;
                    } 
                }
            }
        }
    }
}
