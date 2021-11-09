using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float Draai;
    public float VoorAchter;
    bool BuitenZ = false;
    bool BuitenX = false;

    public float Speed = 10;
    private float TurnSpeed = 150;
    public float jumpPower = 300;
    float Zkant1 = 965;
    float Zkant2 = 760;
    float Xkant1 = 270;
    float Xkant2 = 65;

    public Rigidbody playerRB;
    public GameObject player;
    public Camera spelerCamera;
    public Hp hp;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerRB = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var scene = SceneManager.GetSceneAt(0);
        Draai = Input.GetAxis("Horizontal");
        VoorAchter = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * VoorAchter * Time.deltaTime * Speed);
        transform.Rotate(Vector3.up * Time.deltaTime * TurnSpeed * Draai);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector3.up * jumpPower);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Schiet();
        }
        if (player.transform.position.x > Xkant1 || player.transform.position.x < Xkant2)
        {
            BuitenX = true;
        }
        if (player.transform.position.z > Zkant1 || player.transform.position.z < Zkant2)
        {
            BuitenZ = true;
        }
        if (BuitenX || BuitenZ)
        {
            SceneManager.LoadScene("Defeat");
        }
    }
    public void OnCollisionEnter(Collision other)
    {
        
        if (other.collider.CompareTag("Obstacle") || other.collider.CompareTag("Boss"))
        {
            SceneManager.LoadScene("Defeat");
        }
        else if (other.collider.CompareTag("Victory"))
        {
            SceneManager.LoadScene("Victory Screen");
        }
    }

    void Schiet()
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
