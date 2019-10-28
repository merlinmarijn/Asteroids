using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveNLoad : MonoBehaviour
{
    public string Player;
    public int Score;
    public float TimePlayed;
    private List<string> ScorePaths;
    private int lastRNG =99999;
    private int RNG;
    public List<int> sorted;
    public Text[] ScoreUI;

    private void Start()
    {
        SaveManager.MakeDirectory();
        ScorePaths = SaveManager.GetFileNames();
        foreach (string item in ScorePaths)
        {
            SaveVariables data = SaveManager.LoadScore(item);
            sorted.Add(int.Parse(data.Score));
            sorted.Sort();
        }
        List<int> finalscore = new List<int>();
        for (int i = sorted.Count; i --> 0;)
        {
            finalscore.Add(sorted[i]);
        }
        sorted = finalscore;
        ScoreUI[0].text = "Score: " + sorted[0].ToString();
        ScoreUI[1].text = "Score: " + sorted[1].ToString();
        ScoreUI[2].text = "Score: " + sorted[2].ToString();
        ScoreUI[3].text = "Score: " + sorted[3].ToString();
        ScoreUI[4].text = "Score: " + sorted[4].ToString();
    }

    private void Update()
    {
        Player = "tttttttttt";
        Score = GameObject.FindGameObjectWithTag("Player").GetComponent<ShipMovement>().score;
        TimePlayed += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.P))
        {
            SaveScore();
        }
    }

    public void SaveScore()
    {
        SaveManager.SaveScore(this);
    }

    public void LoadScore()
    {
        RNG = Random.Range(0, ScorePaths.Count - 1);
        if (ScorePaths.Count > 0 && RNG != lastRNG||ScorePaths.Count==1||ScorePaths.Count==2)
        {
                lastRNG = RNG;
                SaveVariables data = SaveManager.LoadScore(ScorePaths[RNG]);
        } else { if (ScorePaths.Count == 0) { Debug.Log("NO MORE Scores"); } LoadScore(); }
    }
}
