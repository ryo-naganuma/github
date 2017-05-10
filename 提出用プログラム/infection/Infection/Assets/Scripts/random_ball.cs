using UnityEngine;
using System.Collections;

public class random_ball : MonoBehaviour {

   
    Vector3 moveDirection = new Vector3(0.0f,0.0f,0.0f);
    Rigidbody balla;
    AudioSource audioSource;
    public AudioClip audioClip1;

    float a = 0;
    public int condition = 0;

	// Use this for initialization
	void Start () {
        balla = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if(gameObject.tag == "bhuman")
        {

            condition = 1;
            //particle.Play() ;
        }
        else
        {
            //particle.Stop();
            //particle.Clear();
            
        }


        int xr = Random.Range(-50, 50);
        int xz = Random.Range(-50, 50);
        if (a <= 40)
        {
            a = 0;
            moveDirection.x = xr;
            moveDirection.z = xz;
            balla.AddForce(moveDirection);
        }
        a++;
    }

    private void OnCollisionEnter(Collision hit)
    {
       if(gameObject.tag == "bhuman" && hit.gameObject.tag == "human")
        {//もし自分が感染者でぶつかった相手が非感染者なら、50%の確率で相手を関せ者にする。
            if (5 < Random.Range(0, 10))
            {
                hit.gameObject.tag = "bhuman";
            }
            
           
        }
       if(gameObject.tag=="bhuman" && hit.gameObject.tag == "medicine")
        {
            transform.tag = "human";
            audioSource.clip = audioClip1;
            audioSource.Play();
            Destroy(hit.gameObject);
        }
    }
}
