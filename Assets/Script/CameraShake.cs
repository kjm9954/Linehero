using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] public float m_force;
    [SerializeField] private Vector2 m_offset = Vector2.zero;
    public float time;

    Quaternion m_originRot;
    void Start()
    {
        m_originRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void C_Shake()
    {
        StartCoroutine(Shake());

        Debug.Log("Shaek");

        Invoke("Clear", time);
    }

    void Clear()
    {
        StopAllCoroutines();
        StartCoroutine(Reset());
    }

    IEnumerator Shake()
    {
        Vector2 t_originEuler = transform.eulerAngles;
        while(true)
        {
            float t_rotX = Random.Range(-m_offset.x, m_offset.x);
            float t_rotY = Random.Range(-m_offset.y, m_offset.y);

            Vector2 t_randomRot = t_originEuler + new Vector2(t_rotX, t_rotY);
            Quaternion t_rot = Quaternion.Euler(t_randomRot);

            while(Quaternion.Angle(transform.rotation, t_rot) > 0.1f)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, t_rot, m_force * Time.deltaTime);
                yield return null;
            }
            yield return null;
        }
    }

    IEnumerator Reset()
    {
        while (Quaternion.Angle(transform.rotation, m_originRot) > 0f)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, m_originRot, m_force * Time.deltaTime);
            yield return null;
        }
    }
}
