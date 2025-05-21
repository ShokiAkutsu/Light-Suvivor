using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Transform m_player;
    [SerializeField] float speed = 2f;
    [SerializeField] float destroyFrame = 5f;
    
    float damageFrame;
    [SerializeField] float highLight_damage = 0.5f;
    [SerializeField] float lowLight_damage = 0.3f;

    GameObject m_highLight;
    GameObject m_lowLight;

    // Start is called before the first frame update
    void Start()
    {
        damageFrame = 0f;
        m_player = GameObject.FindGameObjectWithTag("Player").transform;
        m_highLight = GameObject.Find("HighLight");
        m_lowLight = GameObject.Find("LowLight");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position =
            Vector2.MoveTowards(this.transform.position, m_player.position, speed);
    }

	private void OnTriggerStay2D(Collider2D collision)
	{
        if (collision.tag == "Light")
        {
            if (collision.gameObject == m_highLight)
            {
                damageFrame += highLight_damage;
            }
            else if (collision.gameObject == m_lowLight)
            { 
                damageFrame += lowLight_damage; 
            }

            if (damageFrame > destroyFrame)
            {
                Destroy(this.gameObject);
            }
		}

        if (collision.tag == "Player") Destroy(this.gameObject);
	}
}
