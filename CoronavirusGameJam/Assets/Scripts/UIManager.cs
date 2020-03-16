using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    public Image hungryBar;
    public Image thirstBar;
    public Image madnessBar;
    public Image radiatonBar;

    public Text dayIndicatorText;

    

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {

    }


    void Update()
    {

    }
}
