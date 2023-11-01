using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerRekabetçi : MonoBehaviour
{
    public int scoreMor;
    public int scoreTuruncu;
    public Text ScoreTextMor;
    public Text ScoreTextTuruncu;


    void Start()
    {

    }

    
    void Update()
    {

    }

    public void IncreaseScoreTuruncu()
    {
        scoreTuruncu++;
        ScoreTextTuruncu.text = "SCORE: " + scoreTuruncu.ToString();
    }

    public void DecreaseScoreTuruncu()
    {
        scoreTuruncu--;
        ScoreTextTuruncu.text = "SCORE: " + scoreTuruncu.ToString();

    }

    public void IncreaseScoreMor()
    {
        scoreMor++;
        ScoreTextMor.text = "SCORE: " + scoreMor.ToString();
    }

    public void DecreaseScoreMor()
    {
        scoreMor--;
        ScoreTextMor.text = "SCORE: " + scoreMor.ToString();

    }
}
