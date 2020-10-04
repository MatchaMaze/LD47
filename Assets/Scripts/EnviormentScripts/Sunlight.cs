using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Sunlight : MonoBehaviour
{
    public static float SunlightIntesity;

    Light2D Sun;
    List<Color> Seasons = new List<Color>();

    void Start()
    {
        Sun = GetComponent<Light2D>();
        Seasons.Add(new Color(0f, 0.85f, 0f));
        Seasons.Add(new Color(0.95f, 0.85f, 0f));
        Seasons.Add(new Color(0.85f, 0.33f, 0f));
        Seasons.Add(new Color(0f, 0.40f, 0.85f));
    }
    
    void Update()
    {
        SunlightIntesity = (Mathf.Cos(WorldTime.Time*Mathf.PI*2f/3f)+1f)/ 2f;
        int season = Mathf.FloorToInt((WorldTime.Time % 24f)/6);
        float seasonT = (WorldTime.Time % 6f )/6f;        
        Sun.color = ColorLerp(Seasons[season], Seasons[(season+1) % 4], seasonT);
        Sun.intensity = SunlightIntesity;
    }

    Color ColorLerp(Color A, Color B, float t)
    {
        return ( 1 - t ) * A + t * B;
    }
}
