using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1_Score : MonoBehaviour
{
    public Text scoretext;
    private int score;

    void Start()
    {
        score = 00;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int add)
    {
        score += add;
        scoretext.text = score.ToString();
    }

    public int GetScore()
    {
        return score;
    }
}
