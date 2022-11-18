using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject enemy;

    private float spawnEnemyInterval;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            spawnEnemyInterval = Random.Range(1, 4);
            yield return new WaitForSeconds(spawnEnemyInterval);
            Instantiate(enemy,new Vector3(transform.position.x,transform.position.y +2,transform.position.z),enemy.transform.rotation);

        }
    }
}
