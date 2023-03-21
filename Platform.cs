using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject obstacles;
    public GameObject coin;
    void Start()
    {
        Spawnobstacle();
        SpawCoins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        PlatformSpawner.instance.Spawnplatform();
        Destroy(gameObject, 2f);
    }
    public void Spawnobstacle()
    {
        int rand = Random.Range(2, 5);
        Transform spawnpoint = transform.GetChild(rand).transform;
        Instantiate(obstacles, spawnpoint.position, Quaternion.identity, transform);
    }
    public void SpawCoins()
    {
        int rand = Random.Range(5,8);
        Transform spawnpoint = transform.GetChild(rand).transform;
        Instantiate(coin, spawnpoint.position, coin.transform.rotation, transform);

        int rand1 = Random.Range(8,11);
        Transform spawnpoint1 = transform.GetChild(rand).transform;
        Instantiate(coin, spawnpoint1.position, coin.transform.rotation, transform);
    }
}
