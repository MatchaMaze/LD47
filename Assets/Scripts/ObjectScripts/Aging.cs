using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aging : MonoBehaviour
{

    public List<Sprite> Ages;

    float Born;
    float Age;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        Born = WorldTime.Time;
        Age = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Age = Mathf.RoundToInt(WorldTime.Time - Born);
        if(Age >= 0 && Age < Ages.Count)
        {
            spriteRenderer.enabled = true;
            spriteRenderer.sprite = Ages[Mathf.RoundToInt(Age)];
        }
        else
        {
            spriteRenderer.enabled = false;
        }
    }
}
