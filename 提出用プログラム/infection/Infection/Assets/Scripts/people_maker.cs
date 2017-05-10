using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people_maker : MonoBehaviour {

    public int humanpopulation;
    public int bhumanpopulation;
    public float stagerange_x1 = -20f;
    public float stagerange_x2 = 20f;
    public float stagerange_z1 = -20f;
    public float stagerange_z2 = 20f;

    Vector3 pos; 
    public GameObject humanprefab;
    public GameObject bhumanprefab;
	// Use this for initialization
	void Start () {
        pos.y = 2;
        for(int i = 0; i < humanpopulation; i++)
        {
            pos.x= Random.Range(stagerange_x1,stagerange_x2);
            pos.z = Random.Range(stagerange_z1, stagerange_z2);
            GameObject humanP = (GameObject)Instantiate(humanprefab,pos, Quaternion.identity);
        }
        for(int i = 0; i < bhumanpopulation; i++)
        {
            pos.x = Random.Range(stagerange_x1, stagerange_x2);
            pos.z = Random.Range(stagerange_z1, stagerange_z2);
            GameObject bhumanP = (GameObject)Instantiate(bhumanprefab, pos, Quaternion.identity);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
