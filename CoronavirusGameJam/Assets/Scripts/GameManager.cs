using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        DontDestroyOnLoad(this.gameObject);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void PreloadManagers()
    {
       SceneManager.LoadScene("Managers", UnityEngine.SceneManagement.LoadSceneMode.Additive);
    }
}
