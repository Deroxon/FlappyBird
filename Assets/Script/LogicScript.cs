using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource audioSource;

    public void Start()
    {
        audioSource.volume = StaticNameController.globalVolume;
    }


    [ContextMenu("increase score")]
    public void addScore(int scoreToAdd)
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }




    // tasks: || maybe bonus speed after come 10 points || high score || make menu || 2 game modes like shooting the bird with eggs to open pipes or spawning collision enemys 


    

}
