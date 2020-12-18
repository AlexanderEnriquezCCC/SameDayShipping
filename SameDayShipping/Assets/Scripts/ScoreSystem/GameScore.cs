using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class GameScore : MonoBehaviour
{
    public static int Score;
   void OnGUI()
    {
        GUI.Box(new Rect(120, 80, 80, 120), Score.ToString());

    }
}
