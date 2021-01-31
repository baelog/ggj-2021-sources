using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.GetComponent<Slider>().value = 8;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
