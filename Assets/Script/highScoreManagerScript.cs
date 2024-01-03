using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class highScoreManager : MonoBehaviour
{

    private const string highScoreFilePath = "Assets/highScores.txt";

    private List<int> highscores = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        LoadHighScores();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Przykład dodawania wyniku po wciśnięciu spacji (możesz dostosować do swoich potrzeb)
        {
            AddHighscore(Random.Range(1, 1000)); // Dodaj losowy wynik do listy
            SaveHighscores(); // Zapisz listę wyników po dodaniu nowego wyniku
        }
    }

    void SaveHighscores()
    {
        using (StreamWriter writer = new StreamWriter(highScoreFilePath))
        {
            foreach (int score in highscores)
            {
                writer.WriteLine(score);
            }
        }
    }

    void AddHighscore(int newScore)
    {
        Debug.Log(newScore);
        highscores.Add(newScore);
        highscores.Sort((a, b) => b.CompareTo(a)); // Sortuj malejąco
        if (highscores.Count > 10) // Przykład ograniczenia do 10 wyników
        {
            highscores.RemoveAt(highscores.Count - 1);
        }
    }


    private void LoadHighScores()
    {
        if (File.Exists(highScoreFilePath))
        {
            string[] lines = File.ReadAllLines(highScoreFilePath);

            foreach (string line in lines)
            {
                if (int.TryParse(line, out int score))
                {
                    highscores.Add(score);
                }
            }
        }

    }
}
