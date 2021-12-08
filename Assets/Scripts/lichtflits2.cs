using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lichtflits2 : MonoBehaviour
{
    bool flits = false;

    public GameObject Licht;
    public GameObject huidigLicht;
    // Start is called before the first frame update
    void Start()
    {
        huidigLicht = GameObject.Find("Area Light");
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (!flits)
            {
                flits = true;
                StartCoroutine(Flits());
            }
        }
        IEnumerator Flits()
        {
            Destroy(huidigLicht);
            yield return new WaitForSeconds(Random.Range(1.8f, 7f));
            huidigLicht = Instantiate(Licht);
            yield return new WaitForSeconds(Random.Range(0.2f, 0.8f));
            flits = false;
        }
    }
}
