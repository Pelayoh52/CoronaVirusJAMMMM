using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    int madness;
    int hunger;
    int thirst;
    int radiation;

    int day;
    int numberActions;

    private void Awake()
    {
        Instance = this;
    }
}
