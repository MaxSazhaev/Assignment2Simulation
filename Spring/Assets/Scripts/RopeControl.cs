using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeControl : MonoBehaviour {

    public GameObject ropeShooter;
    public LineRenderer lineRenderer;

	// Update is called once per frame
	void Update () {
		
	}
    void LateUpdate()
    {
        lineRenderer.enabled = true;
        lineRenderer.SetPosition(0, ropeShooter.transform.position);
    }


}
