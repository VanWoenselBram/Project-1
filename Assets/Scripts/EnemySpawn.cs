using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public bool Spawn = true;
    public bool Spawning = false;
    public GameObject Boss;
    public GameObject obstacle;
    public Hp hp;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hp.hpValue <= 0.75 && !Spawning)
        {
            Spawning = true;
            StartCoroutine(SpawnEnemy());
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
            yield return new WaitForSeconds(2.6f);
            Spawning = false;
        }
    }
}
