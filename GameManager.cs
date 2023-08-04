using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    [SerializeField]
    private TMP_Text scoreText;

    private int score;
    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
    public void ArtiSkor()
    {

        score = score + 1;
        scoreText.text = score.ToString();

    }
    
}
