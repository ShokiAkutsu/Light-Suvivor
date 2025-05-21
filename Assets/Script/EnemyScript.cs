using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Transform m_player;
    [SerializeField] float speed = 2f;
    [SerializeField] float destroyFrame = 5f;
    float damageFrame;

    // Start is called before the first frame update
    void Start()
    {
        damageFrame = 0f;
        m_player = GameObject.FindGameObjectWithTag("Player").transform;
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
            damageFrame++;

            if (damageFrame > destroyFrame)
            {
                Destroy(this.gameObject);
            }
		}
	}
}
