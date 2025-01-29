using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public ScholleScript scholleScript;
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen; 


    public void addScore()
    {

           playerScore++;
           scoreText.text = playerScore.ToString();

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
