using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostKnoppen : MonoBehaviour
{
    public PlayerMovement PM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpringBoost()
    {
        PM.jumpPower = 600;
    }

    void Sneller()
    {
        PM.Speed = 20;
    }

    void Trager()
    {
        PM.Speed = 5;
    }
}
