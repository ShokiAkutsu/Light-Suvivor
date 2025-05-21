using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] int playerLife = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Enemy")
        {
            if(0 >= (--playerLife))
            {
				Destroy(this.gameObject);
			}

            Debug.Log(playerLife);
		}
	}
}
