using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCard : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    void Start()
    {
        int x = -2;
        for (int i = -6; i < -6 + 3 * 5; i += 3)
            Instantiate(obj, new Vector3(i, x, 0), Quaternion.identity);
        x += 4;
        for (int i = -6; i < -6 + 3 * 5; i += 3)
            Instantiate(obj, new Vector3(i, x, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
