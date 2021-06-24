using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
    public static MoveManager _instance;
    public List<Transform> waypoints = new List<Transform>();
    public int index = 0;

    public int randomNum;
    public int DiceValue;

    [Header("Players")]
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;
    [Header("Players Bool")]
    public bool Player1bool;
    public bool Player2bool;
    public bool Player3bool;
    public bool Player4bool;



    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
        Player1bool = true;
    }




    public int DiceRandomNumber(int maxInt)
    {
        randomNum = Random.Range(1, maxInt + 1);
        print(randomNum);
        PlayerMov.Instance.playerMove(randomNum);
        return randomNum;

    }
}
