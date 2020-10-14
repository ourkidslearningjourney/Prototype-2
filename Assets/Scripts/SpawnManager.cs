using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private int spawnXRange = 15;
    private int spawnZRange = 20;

    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int animalX = Random.Range(-spawnXRange, spawnXRange);

        Instantiate(
            animalPrefabs[animalIndex],
            new Vector3(animalX, 0, spawnZRange),
            animalPrefabs[animalIndex].transform.rotation);
    }
}
