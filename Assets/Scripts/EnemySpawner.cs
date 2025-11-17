using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //enemy types
    [SerializeField] private GameObject normalEnemy;
    [SerializeField] private GameObject tankEnemy;
    [SerializeField] private GameObject speedyEnemy;
    //enemy spawn intervals
    [SerializeField] private float normalInterval = 4f;
    [SerializeField] private float tankInterval = 5.5f;
    [SerializeField] private float speedyInterval = 6.5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawnEnemy(normalInterval, normalEnemy));
        StartCoroutine(spawnEnemy(tankInterval, tankEnemy));
        StartCoroutine(spawnEnemy(speedyInterval, speedyEnemy));


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);

        Vector3 spawnPosition;
        int maxAttempts = 10;
        int attempts = 0;
        float minDistance = 2f; // Minimum distance from spawner/player

        do
        {
            spawnPosition = new Vector3(Random.Range(-8f, 8f), Random.Range(-8f, 8f), 0);
            attempts++;
        }
        while (Vector3.Distance(spawnPosition, transform.position) < minDistance && attempts < maxAttempts);

        Instantiate(enemy, spawnPosition, Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }

}
