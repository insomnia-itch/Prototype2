using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosZ = 20;
    private float spawnRangeX = 10;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnLeftRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRightRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        GameObject randomAnimal = animalPrefabs[animalIndex];
        Instantiate(randomAnimal, spawnPos, randomAnimal.transform.rotation);
    }

    void SpawnLeftRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(-spawnRangeX - 5, 0, Random.Range(-spawnRangeX, spawnRangeX));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        GameObject randomAnimal = animalPrefabs[animalIndex];
        //randomAnimal.transform.Rotate(0, 90, 0);

        //GameObject tmp = Instantiate(randomAnimal, spawnPos, randomAnimal.transform.rotation);
        //tmp.transform.Rotate(0, 90, 0);
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(randomAnimal, spawnPos, Quaternion.Euler(rotation));
    }

    void SpawnRightRandomAnimal()
    {
        Vector3 spawnPos = new Vector3( spawnRangeX + 5, 0, Random.Range(-spawnRangeX, spawnRangeX));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        GameObject randomAnimal = animalPrefabs[animalIndex];
        //randomAnimal.transform.Rotate(0, -90, 0);

        //GameObject tmp = Instantiate(randomAnimal, spawnPos, randomAnimal.transform.rotation);
        //tmp.transform.Rotate(0, -90, 0);
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(randomAnimal, spawnPos, Quaternion.Euler(rotation));

    }

}
