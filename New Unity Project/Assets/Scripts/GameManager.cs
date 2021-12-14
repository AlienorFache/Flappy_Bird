using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int m_highScore;
    private Vector3 m_firstPosition;
    public bool m_onPlay;

    [SerializeField] public GameObject m_player;
    public Rigidbody2D m_rbPlayer;
    [SerializeField] public PipeGenerator m_pipeGenerator;
    [SerializeField] public Score m_scoreManager;
    [SerializeField] private TextMeshProUGUI m_textHighscore;

    private void Start()
    {
        m_firstPosition = m_player.transform.position;
        m_rbPlayer = m_player.GetComponent<Rigidbody2D>();
        m_rbPlayer.bodyType = RigidbodyType2D.Kinematic;
        m_onPlay = false;
    }

    public void LoadGame()
    {
        m_onPlay = true;
        m_rbPlayer.bodyType = RigidbodyType2D.Dynamic;
        m_pipeGenerator.StartGame();
    }

    public void GameOver()
    {
        //sauvegarde du score
        if (m_scoreManager.m_score > m_highScore) m_highScore = m_scoreManager.m_score;
        m_textHighscore.text = "Highscore : " + m_highScore.ToString();

        m_onPlay = false;
        m_rbPlayer.bodyType = RigidbodyType2D.Kinematic;
    }

    public void ReloadGame()
    {
        //remise a zero des positions et score
        m_player.transform.position = m_firstPosition;
        m_scoreManager.Reset();

        //relance le jeu
        LoadGame();

        //enleve l'ecran gameover
        FindObjectOfType<UImanager>().Play();
    }
}
