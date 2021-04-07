using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameObject[] spawnLocations;

    public GameObject GoldCoin;
    private Vector3 respawnLocation;
    public float spawnDelay = 2f;
    public float spawnInterval = 1f;

    void Awake()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }
    // Start is called before the first frame update
    void Start()
    {
        GoldCoin = (GameObject)Resources.Load("GoldCoin", typeof(GameObject));

        respawnLocation = GoldCoin.transform.position;

        InvokeRepeating("SpawnGoldCoin", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnGoldCoin()
    {
        int spawn = Random.Range(0, spawnLocations.Length);
        GameObject.Instantiate(GoldCoin, spawnLocations[spawn].transform.position, Quaternion.identity);
    }
}
