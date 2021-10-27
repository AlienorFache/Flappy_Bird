using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private int m_speed;

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.right / m_speed;
    }
}
