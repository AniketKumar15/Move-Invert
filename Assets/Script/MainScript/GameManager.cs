using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Releted with Player")]
    public GameObject gameOverScreen; //Get game over screen to activate and deactivate by conditions
    public Transform player; //Get the player position and convet it into score

    [Space]

    [Header("Score")]
    public Text scoreText; //Text to show current score on gamePlay Screen
    public Text highScoreText; //Text to show High Score score on gamePlay Screen
    public int score; //A integer type dataType to check score

    [Header("PowerUP")]
    public Text powerUpName;

    private void Start()
    {
        gameOverScreen.SetActive(false); //Deactivate the game over screen when the game is start
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString() + "m"; //Set the high Score 
        
    }

    private void Update()
    {
        Score(); //Call the score method every frame  
    }

    public void GameOver()
    {
        Invoke("gameOverScreenActive", 3f); //when game is over then wait for second and then active the gameover screen
        AudioManager.instance.Play("GameOver"); //When the game is over the play the gameOver Sound
        HighScore(); //when game is over then update the highScore
        
    }

    public void gameOverScreenActive() //Activate the game over Screen
    {
        gameOverScreen.SetActive(true);
    }

    public void LoadScene(int index) //Load the Main Menu 
    {
        SceneManager.LoadScene(index);
    }

    public void Score() //Add the score by checking the player Z axis positon / checking the distance cover by player and make it score
    {

        score = ((int)player.position.z); //convet vector into int so it able to update score. 
        scoreText.text = score.ToString("0") + "m"; //Update the score text
    }

    public void HighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore", 0)) //Checking if the score is greater than high Score then make it new highScore
        {
            PlayerPrefs.SetInt("HighScore", score); //Save the new high Score
            highScoreText.text = "High Score: " + score.ToString() + "m"; //Update the highScore text when score is geater than highScore
        }
        
    }
}
