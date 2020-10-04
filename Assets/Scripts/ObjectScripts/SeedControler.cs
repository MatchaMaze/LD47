using System.Collections.Generic;
using UnityEngine;

public class SeedControler:MonoBehaviour
{
    public List<GameObject> plants;

    private float Cooldown = 0.1f;
    private float counter = 0f;
    private List<Color> colors = new List<Color>();

    public static bool HasSeed = true;

    float deg;
    float layer;

    private void Start()
    {
        colors.Add(new Color(0, 0, 0));
        colors.Add(new Color(0.1f, 0.1f, 0.1f));
        colors.Add(new Color(0.2f, 0.2f, 0.2f));
        colors.Add(new Color(0.3f, 0.3f, 0.3f));
        colors.Add(new Color(0.4f, 0.4f, 0.4f));
    }

    private void Update()
    {
        if(HasSeed && TimelineControl.state == 3)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                HasSeed = false;
                counter = 0;
                deg = ( WorldTime.Time % 1f ) * Mathf.PI * 2f;                
                layer = Random.Range(-1, 5);

                GameObject newPlant = Instantiate(plants[Random.Range(0, plants.Count)], new Vector3(0f, -4.425f, 0f), Quaternion.Euler(0, 0, deg), transform);
                if(layer >= 0)
                {
                    newPlant.transform.position *= ( 1f - layer * 0.08f );
                    newPlant.transform.localScale *= ( 1f - layer * 0.08f );
                    newPlant.GetComponent<SpriteRenderer>().sortingOrder = 5 - (int)layer;
                    newPlant.GetComponent<SpriteRenderer>().color = colors[(int)layer];
                }
                else
                {
                    //newPlant.transform.position *= ( 1f - layer * 0.08f );
                    newPlant.transform.localScale *= ( 1.08f);
                    newPlant.GetComponent<SpriteRenderer>().sortingLayerName = "Loop";
                    //newPlant.GetComponent<SpriteRenderer>().sortingOrder = 5 - (int)layer;
                    newPlant.GetComponent<SpriteRenderer>().color = Color.black;
                }
            }
        }
        else
        {
            counter += Time.deltaTime;
            if(counter >= Cooldown)
            {
                HasSeed = true;
            }
        }
    }
}