using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    //scoreを表示するテキスト


    private int score = 0;

    //scoreを表示するテキスト
    private GameObject scoreText;
    private object collision;








    // Use this for initialization
    void Start()
    

        { //シーン中のGameOverTextオブジェクトを取得
            this.scoreText = GameObject.Find("ScoreText");
        }
        

        
        

    





    // Update is called once per frame
    void Update()
    {
       
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {

        Debug.Log(score);



        //タグによって与える得点を変える
        if (other.gameObject.tag == "SmallStarTag")
           

        {
            this.score += 10;

           

        }
        else if (other.gameObject.tag == "LargeStarTag")
        {


            this.score += 20;


        }
        else if(other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 30;

            

        }

       
    }

}



