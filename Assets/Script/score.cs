using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public TMP_Text scoreText;
    int myScore = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = myScore.ToString(); 
    }
    public void addScore(int score)
    {
        myScore += score;
    }
}
