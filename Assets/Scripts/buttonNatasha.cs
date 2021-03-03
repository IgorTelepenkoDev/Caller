using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonNatasha : MonoBehaviour
{

    public GameObject pressedEvth;
    public GameObject unpressedEvth;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        

        pressedEvth.SetActive(true);

        unpressedEvth.SetActive(false);

    }
}
