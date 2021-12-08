using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schiet : MonoBehaviour
{
    public bool PowerUp = false;

    public Hp hp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PowerUp == true)
        {
            StartCoroutine(PoweredUp());
        }
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
        if (schot.collider.CompareTag("Player"))
        {
            Scenemanager.loadscene("Game Over");
        }
    }
}
