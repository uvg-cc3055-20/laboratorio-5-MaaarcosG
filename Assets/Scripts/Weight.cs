using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * @author Marcos Gutierrez                 17909
 * @since 14/02/2018
 * Script the Weight
 * */

public class Weight : MonoBehaviour {
    /*Atributo de la clase*/
    LineRenderer line;
    DistanceJoint2D distanceJoint;

	// Use this for initialization
	void Start () {
        line = GetComponent<LineRenderer>();
        distanceJoint = GetComponent<DistanceJoint2D>();
	}
	
	// Update is called once per frame
	void Update () {
        line.SetPosition(0, transform.position);
        line.SetPosition(1, distanceJoint.connectedBody.transform.position);
	}
}
