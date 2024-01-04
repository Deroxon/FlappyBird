using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{

    private const string highScoreFilePath = "Assets/highScores.txt";

    private List<int> highScores = new List<int>();


    private void Start()
    {
        loadHighScores();
       
    }

    private void Update()
    {
        
    }


    public void loadHighScores()
    {
        if(File.Exists(highScoreFilePath))
        {
            string[] lines = File.ReadAllLines(highScoreFilePath);

            foreach (string line in lines)
            {
                if (int.TryParse(line, out int score))
                {
                    StaticNameController.highScores.Add(score);
                }
            }
            // 
            highScores = StaticNameController.highScores;

            // setting highscore to global
            StaticNameController.highscore = highScores[0];
        }

    }



    public void addHighScore(int score)
    {
        highScores.Add(score);

        highScores.Sort((a, b) => b.CompareTo(a));

        if (highScores.Count > 10)
        {
            highScores.RemoveAt(highScores.Count - 1);
        }
        saveHighScore();

    }

    private void saveHighScore()
    {

        using (StreamWriter writer = new StreamWriter(highScoreFilePath))
        {
            foreach (int score in StaticNameController.highScores)
            {
                writer.WriteLine(score);
            }
        }

        loadHighScores();
    }
   
}
