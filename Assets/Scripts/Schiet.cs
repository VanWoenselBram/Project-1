using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schiet : MonoBehaviour
{
    public bool PowerUp = false;

    public Camera spelerCamera;

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
        if (collider.CompareTag("Obstacle"))
        {
            Destroy(collider.gameObject);
        }
        else if (collider.gameObject.CompareTag("Boss"))
        {
            if (PowerUp == true)
            {
                hp.loseHP(0.05f);
            }
            else
            {
                hp.loseHP(0.01f);
            }
            
        }
        else if (collider.gameObject.CompareTag("SterkObstacle") && PowerUp)
        { 
            Destroy(collider.gameObject);
        }
        else if (collider.gameObject.CompareTag("Enemy"))
        {
            hp.loseHP(0.334f);
        }
    }
    IEnumerator PoweredUp()
    {
        yield return new WaitForSeconds(3.5f);
        PowerUp = false;
    }
}
