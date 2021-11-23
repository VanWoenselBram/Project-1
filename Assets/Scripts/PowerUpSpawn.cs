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
    public GameObject PowerUp2;
    // Start is called before the first frame update
    void Start()
    {
        
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
        int i = Random.Range(1, 3);
        Spawn = true; 
        Vector3 Pos = new Vector3(Random.Range(Xkant2, Xkant1), 2, Random.Range(Zkant2, Zkant1));
        if (i == 1)
        {
            Instantiate(PowerUp, Pos, PowerUp.transform.rotation);
        }
        else if (i == 2)
        {
            Instantiate(PowerUp2, Pos, PowerUp2.transform.rotation);
        }
        yield return new WaitForSeconds(10);
        Spawn = false;
    }
}
