using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //�{�[����������\���̂��邚���̍ő�l
    private float visiblePosZ = -6.5f;
    private int score = 0;
    //�Q�[���I�[�o�[��\������e�L�X�g
    private GameObject gameoverText;
    //�X�R�A��\������e�L�X�g
    private GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");
        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o�[��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over"; 
        }
        //ScoreText�ɃX�R�A��\��
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
