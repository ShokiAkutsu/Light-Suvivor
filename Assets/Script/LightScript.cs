using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    //[SerializeField] GameObject player = default;
    [SerializeField] float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        if (h != 0) this.gameObject.transform.Rotate(0, 0, h * speed);
    }
}
