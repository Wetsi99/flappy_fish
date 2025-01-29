using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PflanzenSpawn : MonoBehaviour
{
    public GameObject plant;
    public float spawnRate = 1f;
    public float heightOffset = 0f;

    private float timer = 0f;
    private float rateDecreaseTimer = 0f;
    private float decreaseInterval = 5f; // Alle 10 Sekunden verringern
    private float decreaseAmount = 0.1f; // Um 0.1 verringern

    // Start is called before the first frame update
    void Start()
    {
        spawnPlant();
    }

    // Update is called once per frame
    void Update()
    {
        // Timer für Spawn-Rate-Verringerung aktualisieren
        rateDecreaseTimer += Time.deltaTime;

        // Überprüfen, ob es Zeit ist, die Spawn-Rate zu verringern
        if (rateDecreaseTimer >= decreaseInterval)
        {
            // Verringere die Spawn-Rate
            spawnRate -= decreaseAmount;
            rateDecreaseTimer = 0f; // Timer zurücksetzen
        }

        // Timer für Spawn aktualisieren
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPlant();
            timer = 0;
        }
    }

    void spawnPlant()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(plant, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
    }
}

