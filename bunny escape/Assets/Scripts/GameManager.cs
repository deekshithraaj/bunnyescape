using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //  _the_kdr in the house yo ! 
    // Start is called before the first frame update
    // game manger is more like a friend who is more about tranferring messages here and there .
    // which is bad in real life but good in coding life  what it does is just get into the codes yo !

    public static GameManager instance; // which is mind to maintain kind of thing make sure it takes only one
    //game manger is separate class not a game object .. remind yourself..

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

        //rules to game over when and why then decide 
        //enemy touches the player    yo this game over
        // i have to know what enemy is doing so i call them using code yo


        gameOver = true;
        GameObject.Find("Enemyspawn").GetComponent<EnemySpawner>().CancelInvoke();
        print("game is over  ");
        ScoringTextPanel.text = "Score : " + score; 
        gameoverPanel.SetActive(true);

// check for high score and display

        }


    // take note to score it down 
    public void GameScore() {
        if (!gameOver)
        { 
        score++;
        print(score);
            ScoringText.text = score.ToString();
            
            // save score for highest score

        }
         // whenever the bunny dies you must make sure game over panel comes and says some thing to you!! 

        //call canvas  and say set active your gameover apanel active or you will die!! indian things !!

    }

    // all ui integrations 
    
    public void Restart() {

        SceneManager.LoadScene("GAME");

    }

    public void MainMenu() {
        SceneManager.LoadScene("Menu");

    }

}
