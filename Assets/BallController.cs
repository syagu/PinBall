using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
    //scoreを表示するテキスト
    private GameObject scoreText;

    private object collision;

    //scoreを表示するテキスト


    private int score = 0;


    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        //シーン中のGameOverTextオブジェクトを取得
            this.scoreText = GameObject.Find("ScoreText");
        
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {

            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
     
    }
    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {

        Debug.Log(score);



        //タグによって与える得点を変える
        if (other.gameObject.tag == "SmallStarTag")


        {
            this.score += 10;

            //ScoreText獲得した点数を表示(追加)
            this.scoreText.GetComponent<Text>().text = "score " + this.score + "pt";

        }
        else if (other.gameObject.tag == "LargeStarTag")
        {


            this.score += 20;

            //ScoreText獲得した点数を表示(追加)
            this.scoreText.GetComponent<Text>().text = "score " + this.score + "pt";

        }
        else if (other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 30;

            //ScoreText獲得した点数を表示(追加)
            this.scoreText.GetComponent<Text>().text = "score " + this.score + "pt";

        }


    }

}