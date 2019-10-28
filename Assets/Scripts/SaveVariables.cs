using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class SaveVariables
{
    public string Player, Score, Time;

    public SaveVariables(SaveNLoad SD)
    {
        Player = SD.Player;
        Score = SD.Score.ToString();
        Time = SD.TimePlayed.ToString();
    }

}
