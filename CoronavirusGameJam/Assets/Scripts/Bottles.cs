using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bottles : InteractableObjects
{
    //public Sprite2D spriteLetterInteractable;

    public void Start()
    {
        
    }
    
    public override void DoMiniGame()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(BottleMiniGame());
        }

    }

    IEnumerator BottleMiniGame()
    {
        yield return null;
    }
}
