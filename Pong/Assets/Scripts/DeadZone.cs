using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DeadZone : MonoBehaviour
{

    public Text scoreTextP1;
    public Text scoreTextP2;

    private int scoreP1 = 0;
    private int scoreP2 = 0;

    public SceneChange sceneChanger;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "RightGoal")
        {
            Debug.Log("punto para P2");
            scoreP2++;
            UpdateScoreLabel(scoreTextP2, scoreP2);
        }
        else if(gameObject.tag == "LeftGoal")
        {
            Debug.Log("punto para P1");
            scoreP1++;
            UpdateScoreLabel(scoreTextP1, scoreP1);
        }

        collision.GetComponent<BallBehavior>().gameStarted = false;
        CheckScore();

        gameObject.GetComponent<AudioSource>().Play();


    }

    void CheckScore()
    {
        if(scoreP1 >= 3)
        {
            sceneChanger.ChangeSceneTo("WinScene");  
        }
        else if(scoreP2 >= 3)
        {
            sceneChanger.ChangeSceneTo("LooseScene");
        }
    }


    void UpdateScoreLabel(Text label, int score)
    {
        label.text = score.ToString();

    }


}
