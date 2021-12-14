using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    [SerializeField] public GameObject m_gameOverPanel;
    [SerializeField] public GameObject m_gameSarterPanel;

    // Start is called before the first frame update
    void Start()
    {
        m_gameOverPanel.gameObject.SetActive(false);
    }

    public void GameStart()
    {
        m_gameSarterPanel.gameObject.SetActive(false);
    }
    
    public void GameOver()
    {
        m_gameOverPanel.gameObject.SetActive(true);
    }
    
    public void Play()
    {
        m_gameOverPanel.gameObject.SetActive(false);
    }
}
