using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{
    public GameObject hpBar;
    public Slider hp;
    public float hpValue = 1;

    // Start is called before the first frame update
    void Start()
    {
        hpBar = GameObject.Find("HP");
        hp = hpBar.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        hp.value = hpValue;
        if (hp.value == hp.minValue || hpValue <= 0)
        {
            SceneManager.LoadScene("Victory Screen");
        }
    }

    public void loseHP(float dmg)
    {
        hpValue -= dmg;
    }
}
