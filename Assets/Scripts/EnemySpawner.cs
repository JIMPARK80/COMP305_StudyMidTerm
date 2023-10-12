using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Enemies; // 0, 1

    [SerializeField] private float leftSideSpawn;

    [SerializeField] private float rightSideSpawn;

    [SerializeField] private float EnemyInterval = 1f;

    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void StartSpawning()
    {
        StartCoroutine(SpawnEnemyRoutine());
    }

    private void StopSpawning()
    {
        StopCoroutine(SpawnEnemyRoutine());
    }

    IEnumerator SpawnEnemyRoutine()
    {
        yield return new WaitForSeconds(0.5f);
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(EnemyInterval);
        }
    }


    private void SpawnEnemy()
    {
        // float posX = Random.Range(leftSideSpawn, rightSideSpawn);
        Vector3 position = new Vector3(transform.position.x, transform.position.y, 0);
        int index = Random.Range(0, Enemies.Length);
        Instantiate(Enemies[index], position, Quaternion.identity);
    }
}
