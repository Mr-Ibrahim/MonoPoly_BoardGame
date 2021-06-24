using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    private static PlayerMov _instance;
    public static PlayerMov Instance
    { 
    get
        {
            if (_instance == null)
            {
                _instance = new PlayerMov();
            }
            return _instance;
        }    
    }


    //Vector3 pos;
    public Vector3 pos;
    public float speed = 10f;
    public int DiceValue;
    public int index = 0;
    public int randomNum;
    void Start()
    {
        
        //pos = MoveManager._instance.waypoints[0].position;
        //foreach (var item in MoveManager._instance.waypoints)
        //{
        //    if (Vector3.Distance(transform.position, item.position) < Vector3.Distance(pos, transform.position))
        //    {
        //        pos = item.position;
        //        MoveManager._instance.index = MoveManager._instance.waypoints.IndexOf(item);
        //    }
        //}
    }

    
    public void playerMove(int DiceValue)
    {
        DiceValue = DiceRandomNumber(6);
        if (DiceValue == 1)
        {
            
            //1
            pos = MoveManager._instance.waypoints[(MoveManager._instance.index+=1) % MoveManager._instance.waypoints.Count].position;
            transform.position = pos;

        }



        else if (DiceValue == 2)
        {
            
            pos = MoveManager._instance.waypoints[(MoveManager._instance.index+=2) % MoveManager._instance.waypoints.Count].position;
            transform.position = pos;
        }


        else if (DiceValue == 3)
        {
            
            pos = MoveManager._instance.waypoints[(MoveManager._instance.index += 3) % MoveManager._instance.waypoints.Count].position;
            transform.position = pos;
        }


        else if (DiceValue == 4)
        {
            
            pos = MoveManager._instance.waypoints[(MoveManager._instance.index += 4) % MoveManager._instance.waypoints.Count].position;
            transform.position = pos;
        }


        else if (DiceValue == 5)
        {
            
            pos = MoveManager._instance.waypoints[(MoveManager._instance.index += 5) % MoveManager._instance.waypoints.Count].position;
            transform.position = pos;
        }


        else if (DiceValue == 6)
        {
            
            pos = MoveManager._instance.waypoints[(MoveManager._instance.index += 6) % MoveManager._instance.waypoints.Count].position;
            transform.position = pos;
        }


        //else
        //{
        //    //transform.Rotate(waypoints[(index) % waypoints.Count].position * speed * Time.deltaTime);
        //    //transform.LookAt(waypoints[(index) % waypoints.Count].position);
        //    transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
        //}

    }
    public int DiceRandomNumber(int maxInt)
    {
        randomNum = Random.Range(1, maxInt + 1);
        print(randomNum);
        return randomNum;
    }

    //private int name;

    //public int Name
    //{
    //    get { return name; }
    //    set { name = value; }
    //}
    //public PlayerMov()
    //{

    //}


}



//1
//Vector3 dir = waypoints[index].position - transform.position;
//transform.position += dir * Time.deltaTime * speed;
////if (dir.magnitude <= reachDistance)
////{
//index++;
////}
//if (index > waypoints.Count)
//{
//    index = 0;
//}
