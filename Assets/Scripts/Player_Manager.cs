using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Manager : MonoBehaviour
{
    public static Player_Manager Instance;
    private int CurrentPlayer = 0;
    public List<GameObject> Players  = new List<GameObject>();
    private PlayerMovement[] currentPlayerScript;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        currentPlayerScript = new PlayerMovement[Players.Count];
        for (int i = 0; i < Players.Count; i++)
        {
            currentPlayerScript[i] = Players[i].GetComponent<PlayerMovement>();
        }
        currentPlayerScript[CurrentPlayer].turn = true;
        
    }
    private void Update()
    {
        if (!currentPlayerScript[CurrentPlayer].turn)
        {
            CurrentPlayer++;
            if (CurrentPlayer >= Players.Count)
            {
                CurrentPlayer = 0;
            }
            currentPlayerScript[CurrentPlayer].turn = true;
        }
    }
}
