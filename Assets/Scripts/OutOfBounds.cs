using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    float Zkant1 = 965;
    float Zkant2 = 760;
    float Xkant1 = 270;
    float Xkant2 = 65;

    bool BuitenZ = false;
    bool BuitenX = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.z > Zkant1 || gameObject.transform.position.z < Zkant2)
        {
            BuitenZ = true;
        }
        else if (gameObject.transform.position.x > Xkant1 || gameObject.transform.position.x < Xkant2)
        {
            BuitenX = true;
        }
        if (BuitenX || BuitenZ)
        {
            Destroy(gameObject);
        }
    }
}
