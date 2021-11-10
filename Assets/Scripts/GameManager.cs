using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    float Tijd = 120;

    public TMP_Text tijdOver; 
    
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        tijdOver.text = Tijd.ToString();
        Tijd -= Time.deltaTime;
        if (Tijd < 0)
        {
            SceneManager.LoadScene("Defeat");
        }
    }
}
