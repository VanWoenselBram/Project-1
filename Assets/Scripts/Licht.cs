using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Licht : MonoBehaviour
{
    bool Flitsend = false;

    public GameObject Lichtje;
    public GameObject huidigLichtje;

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
    }
    IEnumerator Flits()
    {
        Destroy(huidigLichtje);
        yield return new WaitForSeconds(Random.Range(0.5f, 3f));
        huidigLichtje = Instantiate(Lichtje);
        Flitsend = false;
    }
}
