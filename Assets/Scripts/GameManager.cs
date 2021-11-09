using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float Tijd = 60;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tijd -= Time.deltaTime;
        if (Tijd < 0)
        {
            SceneManager.LoadScene("Defeat");
        }
    }
}
