using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slingshotrope : MonoBehaviour
{
    public Transform LeftPoint;
    public Transform RightPoint;
    public Transform CenterPoint;
     LineRenderer lineRenderer;
    public Rigidbody birdRigidbody;


 
    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }
    private void Update()
    {
          lineRenderer.SetPositions(new Vector3[3] { LeftPoint.position, CenterPoint.position, RightPoint.position });
       
    }

   
    
}

