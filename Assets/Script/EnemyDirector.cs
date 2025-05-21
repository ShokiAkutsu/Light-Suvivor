using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDirector : MonoBehaviour
{
    [SerializeField] List<GameObject> enemyList;
    //[SerializeField] int maxEnemy = 10;

    int frame = 0;
    [SerializeField] int generateFrame = 30;
    [SerializeField] float radius = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frame++;

        if (frame > generateFrame) 
        {
            frame = 0;

			// ランダムな角度を生成
			float randomAngle = Random.Range(0f, 360f);

            // 極座標からデカルト座標に変換
            float x = Mathf.Cos(randomAngle * Mathf.Deg2Rad) * radius;
            float y = Mathf.Sin(randomAngle * Mathf.Deg2Rad) * radius;

            Instantiate(enemyList[0], new Vector2 (x, y), Quaternion.identity);
		}
	}
}
