using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Schiet schiet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            schiet.PowerUp = true;
        }
    }
}
