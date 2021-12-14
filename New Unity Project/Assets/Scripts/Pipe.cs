using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private int m_speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * m_speed * Time.deltaTime);
    }
}
