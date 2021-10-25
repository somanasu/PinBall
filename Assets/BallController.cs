using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるｚ軸の最大値
    private float visiblePosZ = -6.5f;
    private int score = 0;
    //ゲームオーバーを表示するテキスト
    private GameObject gameoverText;
    //スコアを表示するテキスト
    private GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバーを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over"; 
        }
        //ScoreTextにスコアを表示
        this.scoreText.GetComponent<Text>().text = "Score:" + score;
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            score += 5;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        { 
            this.score += 15;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 20;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 50;
        }
    }
}
