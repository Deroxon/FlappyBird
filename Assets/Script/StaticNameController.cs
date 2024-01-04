using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticNameController : MonoBehaviour
{
    public static float globalVolume = 0.25f;
    public static float deadZone = -40;
    public static float highscore = 0;

    public static new List<int> highScores = new List<int>();
}
