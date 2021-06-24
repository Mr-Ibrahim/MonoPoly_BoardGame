using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    int current = 0;


    bool turn = false;

    public void Move()
    {
        StartCoroutine("MovePlayer");
    }


    IEnumerator MovePlayer()
    {

        var num = Dice_Script._instance.DiceRandomNumber();

        current = Board_Manager._instance.SetIndex(current);
        //50   52
        

        var positions = Board_Manager._instance.GetPositionsData(current, num);


        foreach (var item in positions)
        {
            yield return new WaitForSeconds(.5f);
            transform.position = item.position;

        }

            




        current += num;
        

    }



    IEnumerator WaitTime()
    {

        
            yield return new WaitForSeconds(30f);
            //

    }
}
public class ProOwnerD
{ 
    //Property 
    //Player
    //bool

}