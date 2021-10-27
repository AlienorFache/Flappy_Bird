using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    [SerializeField] public GameObject m_gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        m_gameOverPanel.gameObject.SetActive(false);
    }

 public void GameOver()
    {
        m_gameOverPanel.gameObject.SetActive(true);
    }
}
