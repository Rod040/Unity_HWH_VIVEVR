using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class GameManager : MonoBehaviour
{
    [Header("籃球數量")]
    public Text textBallCount;
    [Header("分數")]
    public Text textScore;

    private int ballCount = 5;
    private int score;

    public void UseBall(GameObject ball)
    {
        Destroy(ball.GetComponent<Throwable>());
        Destroy(ball.GetComponent<Interactable>());

        ballCount--;
        textBallCount.text = "籃球數量:" + ballCount + "/5";
    }

    private void OnTriggerEnter(Collider other)
    {
        score+=2;
        textScore.text = "分數：" + score;
    }
}