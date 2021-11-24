using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject rotation;

    bool Spawn;
    bool Spawning = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Spawning)
        {
            Spawning = true;
            StartCoroutine(SpawnEnemy());
        }
    }
    IEnumerator SpawnEnemy()
    {
        int Z = Random.Range(840, 910);
        Vector3 Pos = new Vector3(255, 0, Z);
        if (Spawn)
        {
            Instantiate(obstacle, Pos, rotation.transform.rotation);
            Spawn = false;
            Spawning = false;
        }
        else
        {
            Spawn = true;
            yield return new WaitForSeconds(2.6f);
            Spawning = false;
        }
    }
}
