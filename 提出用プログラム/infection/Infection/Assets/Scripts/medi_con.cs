using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medi_con : MonoBehaviour {
    public int counter = 60;
	// Use this for initialization
	void Start () {
        counter = 60;
    }
	
	// Update is called once per frame
	void Update () {
        counter--;
        if(counter == 0)
        {
            Destroy(this.gameObject);
        }
	}

}
