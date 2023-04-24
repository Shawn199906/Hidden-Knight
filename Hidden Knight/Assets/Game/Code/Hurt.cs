using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour
{
    [HideInInspector]
    public Material m_body;

    public Material m_hurt;

    public GameObject m_blow;

    private SpriteRenderer m_sprite;

    void Start()
    {
        m_sprite = GetComponent<SpriteRenderer>();
        m_body = m_sprite.material;
    }

    public void BeHurt()
    {
        m_sprite.material = m_hurt;
        Instantiate(m_blow, m_sprite.transform.position, Quaternion.identity);
        Invoke("Back", 0.05f);
    }
    private void Back()
    {
        m_sprite.material = m_body;
    }
}
