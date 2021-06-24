using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board_Manager : MonoBehaviour
{
    public static Board_Manager _instance;

    internal int SetIndex(int current)
    {
        return current % waypoints.Count;
    }



    //public static Board_Manager Instance
    //{
    //    get
    //    {
    //        if (_instance == null)
    //        {
    //            _instance = new Board_Manager();
    //        }
    //        return _instance;
    //    }
    //}


    private void Awake()
    {
        _instance = this;
    }


    public List<Transform> waypoints = new List<Transform>();
    public int index = 0;
    public Vector3 pos;

    //public void StartLocation(GameObject Player)
    //{
    //    Player.transform.position = waypoints[0].position;
    //}
    //public void getLocation(GameObject Player,int DiceValue)
    //{
    //    int tempIndex = 0;
    //    do
    //    {
    //        if(Player.transform.position == waypoints[tempIndex].position)
    //        {
    //            index = tempIndex;
    //        }
    //        else
    //        {
    //            tempIndex++;
    //        }
    //    } while (Player.transform.position != waypoints[tempIndex].position);
    //    Vector3 templocation;
    //    for (int i = 0; i < DiceValue; i++)
    //    {
    //        templocation = waypoints[(index += DiceValue) % waypoints.Count].position;
    //        Player.transform.position=templocation;
    //    }

    //}


        [ContextMenu("Work")]
    public void DoesItWork()
    {
        print(GetPositionsData(33, 7));
    }


    internal List<Transform> GetPositionsData(int current, int num)
    {

        if (current + num >= waypoints.Count)
        { 
            var list = new List<Transform>(waypoints.GetRange(current, waypoints.Count - current - 1));
            var rem = num - list.Count;
            list.AddRange(waypoints.GetRange(0, rem));
            return list;
        }

        return new List<Transform>(waypoints.GetRange(current, num));
    }
}
