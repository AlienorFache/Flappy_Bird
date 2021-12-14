using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int m_score;
    private TextMeshProUGUI m_textScore;

    private void Start()
    {
        m_textScore = this.GetComponent<TextMeshProUGUI>();
    }

    public void AddScore()
    {
        m_score++;
        m_textScore.text = m_score.ToString();
    }

    public void Reset()
    {
        m_score = 0;
        m_textScore.text = m_score.ToString();
    }

}
