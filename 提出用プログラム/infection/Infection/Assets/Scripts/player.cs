using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {

    public Text leftmed; //残り薬量
    public GameObject med; //薬のプレファブ
    public int MAXmedicine; //薬最大保有量
    int medicine; //薬の残数
    float gravity = 3;
    CharacterController controller;
    Vector3 mD = Vector3.zero;
    public float speedZ;
	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
        medicine = MAXmedicine;
    }
	
	// Update is called once per frame
	void Update () {
        leftmed.text = "残治療薬:" + medicine;

        mD.z = Input.GetAxis("Vertical") * speedZ;
        mD.y -= gravity * Time.deltaTime;
        if (Input.GetButtonDown("Fire1")) {
            Medicine();
        }
        transform.Rotate(0, Input.GetAxis("Horizontal") * 3, 0);
        Vector3 globalDirection = transform.TransformDirection(mD);
        controller.Move(globalDirection * Time.deltaTime);

        
	}

    void Medicine()
    {
        if (medicine > 0)
        {
            mD.x = 0;mD.y = 0; mD.z = 0;
            medicine--;
            controller.Move(transform.TransformDirection(mD));
            Vector3 shooter = new Vector3(transform.position.x + transform.forward.x * 0.5f, transform.position.y+0.3f, transform.position.z + transform.forward.z * 0.5f);
            GameObject meds = (GameObject)Instantiate(med, shooter, Quaternion.identity);
            Rigidbody medBody = meds.GetComponent<Rigidbody>();
            medBody.AddForce(transform.forward * 600);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "HealPoint")
        {
            medicine = MAXmedicine; //HEALPointで全回復
        }
    }
}
