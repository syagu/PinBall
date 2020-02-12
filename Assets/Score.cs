using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score: MonoBehaviour {
    //Materialを入れる
    Material myMaterial;
    //scoreを表示するテキスト
    public GameObject ScoreText;
    
    private int score;
    //角度
    private int degree = 0;
    //速度
    private int speed = 10;


	// Use this for initialization
	void Start () {
        //シーン中のScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");

        //タグによって与える得点を変える
        if (tag == "SmallStarTag")
        {
            Debug.Log(10);
        }
        else if (tag == "LargeStarTag")
        {
            Debug.Log(20);
        }else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            Debug.Log(30);
        }
       
        
       
		
	}
	
	// Update is called once per frame
	void Update () {
        //ボールがオブジェクトに当たった場合
        if (this.degree >= 0)
        {
            //角度を180に設定
            this.degree -= this.speed;
        }
	}
    //衝突時に呼ばれる関数
    private void OnCollisionEnter(Collision other)
    {
        //角度を180に設定
        this.degree = 180;
    }
}



