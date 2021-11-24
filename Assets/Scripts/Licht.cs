using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Licht : MonoBehaviour
{
    private int i = 0;

    bool Flitsend = false;

    public GameObject Lichtje;
    private GameObject huidigLichtje;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Flitsend)
        {
            Flitsend = true;
            StartCoroutine(Flits());
        }
        huidigLichtje = GameObject.Find("Area Light");
    }
    IEnumerator Flits()
    {
        if(i == 0)
        {
            Destroy(huidigLichtje);
            yield return new WaitForSeconds(1.2f);
            Instantiate(Lichtje);
            i++;
        }
        else if (i == 1)
        {
            Destroy(huidigLichtje);
            yield return new WaitForSeconds(0.4f);
            Instantiate(Lichtje);
            yield return new WaitForSeconds(2.3f);
            Destroy(huidigLichtje);
            yield return new WaitForSeconds(1.8f);
            Instantiate(Lichtje);
            int a = Random.Range(-1, 2);
            i = i + a;
        }
        else
        {
            Destroy(huidigLichtje);
            yield return new WaitForSeconds(0.1f);
            Instantiate(Lichtje);
            yield return new WaitForSeconds(0.7f);
            Destroy(huidigLichtje);
            yield return new WaitForSeconds(3f);
            Instantiate(Lichtje);
            i--;
        }
        Flitsend = false;
    }
}
