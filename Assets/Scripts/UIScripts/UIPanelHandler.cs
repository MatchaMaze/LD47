using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanelHandler : MonoBehaviour
{
    public GameObject OptionsPanel;

    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            OptionsPanel.SetActive(!OptionsPanel.activeSelf);
        }
    }
}
