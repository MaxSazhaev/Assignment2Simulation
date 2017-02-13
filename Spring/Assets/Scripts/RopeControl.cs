using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeControl : MonoBehaviour {

    public GameObject ropeShooter;
    

    private SpringJoint2D rope;
    public int maxRopeFrameCount;
    private int ropeFrameCount;

    public LineRenderer lineRenderer;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		
	}
    void LateUpdate()
    {

        lineRenderer.enabled = true;
        //lineRenderer.SetVortexCount(2);
        lineRenderer.SetPosition(0, ropeShooter.transform.position);
        lineRenderer.SetPosition(1, rope.connectedAnchor);
        

    }


}
