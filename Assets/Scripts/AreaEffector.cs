using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * @author Marcos Gutierrez                 17909
 * @since 14/02/2018
 * Script the AreaEffector
 * */
public class AreaEffector : MonoBehaviour {
    public float time = 0f;
    public GameObject child;
    public bool active = true;

    /*Use this for initialization*/
    void Start () {
        //time = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        /*Calculo para sumar los frame*/
        time = time + Time.deltaTime;

        /*Condicion para desactivar el AreaEffector*/
        if(time >= 1.9f)
        {
            active = !active;
            child.gameObject.SetActive(active);
            time = 0;
        }
        
	}
}
