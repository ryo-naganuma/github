using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountHuman : MonoBehaviour
{
    public Text human_sum;
    public Text bhuman_sum;
    public Text scoreT;
    public int score = 5000;
    public Image image;
    private float time;
    public float fadetime;

    GameObject[] tagObjects;

    // Use this for initialization
    void Start()
    {
        
        time = fadetime;//初期化
        image = GetComponent<Image>();//Imageコンポネントを取得
    }

    // Update is called once per frame
    void Update()
    {
            bhuman_sum.text = "感染者数:" + Check2("bhuman");
            human_sum.text = "非感染者数:" + Check2("human");

       
        if (Check2("bhuman") != 0)
        {
             scoreT.text = "score:" + score--;
        }
        if (Check2("bhuman")==0) {
            /*
             time += Time.deltaTime;//時間更新(徐々に減らす)
             float a = time / fadetime;//徐々に0に近づける
             //Color color = image.color;//取得したimageのcolorを取得
             //color.a = a;//カラーのアルファ値(透明度合)を徐々に減らす
             image.color = new Color(1.0f,1.0f,1.0f,a);//取得したImageに適応させる

    */

        }



    }
    
    //シーン上のBlockタグが付いたオブジェクトを数える
    float Check2(string tagname)
    {
        tagObjects = GameObject.FindGameObjectsWithTag(tagname); //tagObjects.Lengthはオブジェクトの数
        return tagObjects.Length;
    }
}