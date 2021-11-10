using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    float Zkant1 = 965;
    float Zkant2 = 760;
    float Xkant1 = 270;
    float Xkant2 = 65;

    bool wachten = false;
    bool Beweeg;

    public Hp hp;
    public GameObject Boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp.hpValue <= 0.5 && !wachten)
        {
            wachten = true;
            StartCoroutine(WachtBeweeg());
        }
    }

    IEnumerator WachtBeweeg()
    {
        if (Beweeg)
        {
            float Z = Random.Range(Zkant2, Zkant1);
            float X = Random.Range(Xkant2, Xkant1);
            Boss.transform.position = new Vector3(X,3,Z);
            Beweeg = false;
            wachten = false;
        }
        else
        {
            Beweeg = true;
            yield return new WaitForSeconds(2.5f);
            wachten = false;
        }
    }
}
