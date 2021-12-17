using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public int scoreNum;

    void Update()
    {
        score.text = "0" + scoreNum.ToString();
    }
}