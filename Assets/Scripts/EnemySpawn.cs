using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public bool Spawn = true;
    public bool Spawning = false;

    public GameObject Boss;
    public GameObject obstacle;
    public GameObject obstacle2;

    public Hp hp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hp.hpValue <= 0.75f && !Spawning && hp.hpValue > 0.35f)
        {
            Spawning = true;
            StartCoroutine(SpawnEnemy());
        }
        if (hp.hpValue <= 0.3f && !Spawning)
        {
            Spawning = true;
            StartCoroutine(SpawnStrongEnemy());
        }
    }

    IEnumerator SpawnEnemy()
    {
        if (Spawn)
        {
            Instantiate(obstacle, Boss.transform.position, Boss.transform.rotation);
            Spawn = false;
            Spawning = false;
        }
        else
        {
            Spawn = true;
            yield return new WaitForSeconds(2.7f);
            Spawning = false;
        }
    }
    IEnumerator SpawnStrongEnemy()
    {
        if (Spawn)
        {
            Instantiate(obstacle2, Boss.transform.position, Boss.transform.rotation);
            Spawn = false;
            Spawning = false;
        }
        else
        {
            Spawn = true;
            yield return new WaitForSeconds(2f);
            Spawning = false;
        }
    }
}
