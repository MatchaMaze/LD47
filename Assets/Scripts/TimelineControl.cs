using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class TimelineControl : MonoBehaviour
{

    public GameObject FirstSeedTimelineObj;
    public GameObject IntroTimelineObj;

    public GameObject PresAnyKeyObj;
    public GameObject PresEKeyObj;
    public GameObject PresMoveKeyObj;

    public GameObject SeedObject;

    Animator PressAnyKeyAnimator;
    Animator PressEKeyAnimator;
    Animator PressMoveKeyAnimator;

    public static int state = 0;

    void Start()
    {
        PressAnyKeyAnimator = PresAnyKeyObj.GetComponent<Animator>();
        PressEKeyAnimator = PresEKeyObj.GetComponent<Animator>();
        PressMoveKeyAnimator = PresMoveKeyObj.GetComponent<Animator>();
    }

    
    void Update()
    {
       // Debug.Log(state);
        switch(state)
        {
            case 0:
                if(Input.anyKey)
                {
                    PressAnyKeyAnimator.SetTrigger("FadeOut");
                    FirstSeedTimelineObj.SetActive(true);
                    //SeedObject.GetComponent<AudioSource>().Play();
                    state++;
                }                
                break;
            case 1:
                if(Input.GetKey(KeyCode.E) && FirstSeedTimelineObj.GetComponent<PlayableDirector>().time > 7.5f)
                {
                    PressEKeyAnimator.SetTrigger("FadeOut");
                    FirstSeedTimelineObj.SetActive(false);
                    IntroTimelineObj.SetActive(true);
                    state++;
                }                
                break;
            case 2:
                if(Input.GetAxis("Horizontal") != 0 && IntroTimelineObj.GetComponent<PlayableDirector>().time >= 3.99f)
                {
                    PressMoveKeyAnimator.SetTrigger("FadeOut");
                    IntroTimelineObj.SetActive(false);
                    state++;
                }
                break;
        }
    }

}
