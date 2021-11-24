using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{
    float Zkant1 = 960;
    float Zkant2 = 750;
    float Xkant1 = 260;
    float Xkant2 = 60;

    bool Spawn = false;

    public GameObject[] PowUps;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(PowUps[0], player.transform.position, player.transform.rotation);
        Instantiate(PowUps[1], player.transform.position, player.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Spawn == false)
        {
            StartCoroutine(SpawnPowUp());
        }
    }

    IEnumerator SpawnPowUp()
    {
        int i = Random.Range(0, 2);
        Spawn = true; 
        Vector3 Pos = new Vector3(Random.Range(Xkant2, Xkant1), 2, Random.Range(Zkant2, Zkant1));
        if (i == 0)
        {
            Instantiate(PowUps[i], Pos, PowUps[i].transform.rotation);
        }
        else if (i == 1)
        {
            Instantiate(PowUps[i], Pos, PowUps[i].transform.rotation);
        }
        yield return new WaitForSeconds(10);
        Spawn = false;
    }
}
