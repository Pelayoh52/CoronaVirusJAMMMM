using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower : InteractableObjects
{
    public override void DoMiniGame()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(ShowerMiniGame());
        }
        
    }

    IEnumerator ShowerMiniGame()
    {
        yield return null;
    }
}
