using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private BlockDescription[] _blockDescriptions;
    private int score = 0;
    public static GameManager instance = null;

    void Start () {
        if (instance == null) {
            instance = this;
        } else if(instance == this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        InitializeManager();
    }
    private void InitializeManager(){
        
    }

    public void AddScore(int _score)
    {
        score += _score;
        scoreText.text = "SCORE: " + score.ToString();
    }
}
