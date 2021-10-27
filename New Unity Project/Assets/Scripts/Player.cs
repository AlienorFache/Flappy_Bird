using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float m_maxSpeedY_Up;
    [SerializeField] private float m_maxSpeedY_Down;
    [SerializeField] private float m_thrustForce;

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rigid = GetComponent<Rigidbody2D>();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector2.up * m_thrustForce, ForceMode2D.Force);
        }

        if( rigid.velocity.y > m_maxSpeedY_Up)
        {
            rigid.velocity = new Vector2(rigid.velocity.y, m_maxSpeedY_Up);
        }

        if (rigid.velocity.y < m_maxSpeedY_Down)
        {
            rigid.velocity = new Vector2(rigid.velocity.y, m_maxSpeedY_Down);
        }

    }

}
