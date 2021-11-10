using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public GameObject player;
    private int Speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        gameObject.transform.LookAt(player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
