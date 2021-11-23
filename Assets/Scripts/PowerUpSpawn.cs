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

    public GameObject PowerUp;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 Pos = new Vector3(Random.Range(Xkant2, Xkant1), 2, Random.Range(Zkant2, Zkant1));
        Instantiate(PowerUp, Pos, PowerUp.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Spawn == false)
        {
            SpawnPowUp();
        }
    }

    IEnumerator SpawnPowUp()
    {
        Spawn = true;
        yield return new WaitForSeconds(15);
        Spawn = false;
    }
}
