using UnityEngine;
using System.Collections;

public class DragonControl : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        GetComponent<Animation>().Play("Default Take");
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Animation>().Play("walk");
        } /*else
        {
            GetComponent<Animation>().Play("Default Take");
        }*/
    }
}
