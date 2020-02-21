using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    

    public static GameManager instance; // which is mind to maintain kind of thing make sure it takes only one
   
    bool gameOver = false;
    public Text ScoringText;
    public Text ScoringTextPanel;
    public Text HighScore;

    public GameObject gameoverPanel;


    int score = 0;
    private void Awake() {

        if (instance == null)
        {
            instance = this ;
        }

    }


    public void Gameover() {

       

        gameOver = true;
        GameObject.Find("Enemyspawn").GetComponent<EnemySpawner>().CancelInvoke();
        print("game is over  ");
        ScoringTextPanel.text = "Score : " + score; 
        gameoverPanel.SetActive(true);



        }


    
    public void GameScore() {
        if (!gameOver)
        { 
        score++;
        print(score);
            ScoringText.text = score.ToString();
            
            // save score for highest score

        }
         
    }

   
    public void Restart() {

        SceneManager.LoadScene("GAME");

    }

    public void MainMenu() {
        SceneManager.LoadScene("Menu");

    }

}
