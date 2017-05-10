using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class par_con : MonoBehaviour {

    ParticleSystem particle;
    public string deb = "a";
    int check;
	// Use this for initialization
	void Start () {
        particle = GetComponent<ParticleSystem>();
        check = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.parent.transform.tag == "bhuman" && check ==0)
        {
            deb = transform.parent.transform.tag;
            particle.Play();
            check = 1;
        }
        else if( transform.parent.transform.tag == "human")
        {
            particle.Stop();
            particle.Clear();
            check = 0;
        }
	}
}
