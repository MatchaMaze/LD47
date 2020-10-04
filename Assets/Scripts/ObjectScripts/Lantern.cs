using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;


public class Lantern : MonoBehaviour
{
    Light2D lantern;
    Color BaseColor;

    void Start()
    {
        lantern = GetComponent<Light2D>();
        BaseColor = lantern.color;
    }
    
    void Update()
    {

        lantern.color = BaseColor * new Vector4(Random.Range(0.98f, 1.02f), Random.Range(0.98f, 1.02f), Random.Range(0.98f, 1.02f),1);
        lantern.intensity = (1 - Sunlight.SunlightIntesity)*Random.Range(0.98f, 1.02f);
        transform.localPosition = new Vector3(Random.Range(-0.02f, 0.02f), Random.Range(-0.02f, 0.02f), 10);
    }
}
