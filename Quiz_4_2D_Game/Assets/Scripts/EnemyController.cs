using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
   public int score;
   //public TextMeshProUGUI scoreText;
    void Start()
    {
        score = 0;
        //scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        UpdateScore();
    }
    void UpdateScore()
    {
        score += 5;
    }
}
