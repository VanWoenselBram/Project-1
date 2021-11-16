using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schiet : MonoBehaviour
{

    public Camera spelerCamera;
    public Hp hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            schiet();
        }
    }
    void schiet()
    {
        RaycastHit schot;
        Physics.Raycast(spelerCamera.transform.position, spelerCamera.transform.forward, out schot);
        Collider collider = schot.collider;
        if (collider.CompareTag("Obstacle"))
        {
            Destroy(collider.gameObject);
        }
        else if (collider.gameObject.CompareTag("Boss"))
        {
            hp.loseHP(0.01f);
        }
    }
}
