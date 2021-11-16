using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHp : MonoBehaviour
{
    public Hp hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp.hpValue < 0f)
        {
            SceneManager.LoadScene("Victory Screen");
        }
    }
}
