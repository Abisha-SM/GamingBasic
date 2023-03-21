using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    Vector3 nextspawnpoint;
    public static PlatformSpawner instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            Spawnplatform();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Spawnplatform()
    {
        GameObject temp = Instantiate(platform, nextspawnpoint, Quaternion.identity);
        nextspawnpoint = temp.transform.GetChild(1).transform.position;
    }
}
