using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameManager instance { get; private set; }

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    public Player player;

    private void Awake()
    {
        instance = this;
    }
}
