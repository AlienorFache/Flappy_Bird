using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    [SerializeField] private float m_intervalGeneration;
    [SerializeField] private float m_minY;
    [SerializeField] private float m_maxY;
    [SerializeField] private float m_spawnX;
    [SerializeField] private GameObject m_pipePrefab;

    public void StartGame()
    {
        InvokeRepeating("LaunchSpawn", 0f, m_intervalGeneration);
    }
    public void StopInvoke()
    {
        Debug.Log("Stop invoke");
        CancelInvoke("LaunchSpawn");
    }

    void LaunchSpawn()
    {
        StartCoroutine(NodeSpawn());
    }

    IEnumerator NodeSpawn()
    {
        //hauteur de la pipe
        float randomY = Random.Range(m_minY, m_maxY);

        //Instanciation
        Instantiate(m_pipePrefab, new Vector3(m_spawnX, randomY, 0f), transform.rotation);

        yield return null;
    }
}
