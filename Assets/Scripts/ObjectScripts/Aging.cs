using System.Collections.Generic;
using UnityEngine;

public class Aging:MonoBehaviour
{
    public List<Sprite> Ages;

    private float Born;
    
    private float AgeF;
    private int AgeI;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        Born = WorldTime.Time;
        AgeF = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        AgeF = WorldTime.Time - Born;
        AgeI = Mathf.RoundToInt(AgeF);
        if(AgeI >= 0 && AgeI < Ages.Count)
        {
            spriteRenderer.sprite = Ages[AgeI];
        }
        else
        {
            Destroy(gameObject);
        }

        if(AgeF % 1 > 0.3f && AgeF % 1 < 0.7f)
        {
            spriteRenderer.enabled = false;
        }
        else
        {
            spriteRenderer.enabled = true;
        }
    }
}