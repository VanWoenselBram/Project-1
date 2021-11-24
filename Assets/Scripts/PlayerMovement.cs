using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool BuitenZ = false;
    bool BuitenX = false;
    bool Pow2Up = false;

    float Zkant1 = 965;
    float Zkant2 = 760;
    float Xkant1 = 270;
    float Xkant2 = 65;
    public float Draai;
    public float VoorAchter;
    public float Speed = 10;
    public float jumpPower = 300;
    private float TurnSpeed = 200;

    public Rigidbody playerRB;

    public GameObject player;

    public Camera spelerCamera;

    public Schiet schiet;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerRB = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Draai = Input.GetAxis("Horizontal");
        VoorAchter = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * VoorAchter * Time.deltaTime * Speed);
        transform.Rotate(Vector3.up * Time.deltaTime * TurnSpeed * Draai);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Pow2Up)
            {
                playerRB.AddForce(Vector3.up * 2 * jumpPower);
            }
            else
            {
                playerRB.AddForce(Vector3.up * jumpPower);
            }
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
        if (other.collider.CompareTag("Obstacle") || other.collider.CompareTag("Boss") || other.collider.CompareTag("SterkObstacle"))
        {
            SceneManager.LoadScene("Defeat");
        }
        else if (other.collider.CompareTag("Victory"))
        {
            SceneManager.LoadScene("Victory Screen");
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            schiet.PowerUp = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("PowerUp2"))
        {
            Pow2Up = true;
            Destroy(other.gameObject);
            StartCoroutine(PoweredUp());
        }
    }
    IEnumerator PoweredUp()
    {
        yield return new WaitForSeconds(10f);
        Pow2Up = false;
    }
}
