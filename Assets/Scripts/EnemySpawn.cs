using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }
}
