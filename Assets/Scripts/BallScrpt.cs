using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScrpt : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float throwForce = 1;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        shiftRight(-1);
        rotateRight(22.5f);
        throwBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void throwBall()
    {
        m_Rigidbody.AddForce(transform.forward * throwForce, ForceMode.Impulse);
        foreach (SpriteRenderer guide in GetComponentsInChildren<SpriteRenderer>())
        {
            Destroy(guide);
        }
    }

    public void shiftRight(float distance = 1)
    {
        transform.position += transform.right * distance;
    }
    public void rotateRight(float degrees = 45)
    {
        transform.Rotate(transform.up, degrees);
    }
}
