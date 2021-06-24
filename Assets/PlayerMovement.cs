using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    int currentIndex = 0;
    bool turn = false;
    [SerializeField]
    Button DiceBtn;
    void Start()
    {
        DiceBtn= GetComponent<Button>(); //Grabs the button component
        
    }

    public void Update()
    {
        if (turn)
        {
            StartCoroutine("WaitTime");
            DiceBtn.onClick.AddListener(TaskOnClick); //Adds a listner on the button  
        }
    }
    void TaskOnClick()
    {
        StartCoroutine("MovePlayer");
        StopCoroutine("WaitTime");
    }



    IEnumerator MovePlayer()
    {

        var num = Dice_Script._instance.DiceRandomNumber();

        currentIndex = Board_Manager._instance.SetIndex(currentIndex);
        var positions = Board_Manager._instance.GetPositionsData(currentIndex, num);
        foreach (var item in positions)
        {
            yield return new WaitForSeconds(.5f);
            transform.position = item.position;

        }
        currentIndex += num;


    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(30f);
        StopAllCoroutines();
        turn = false;

    }
}
public class ProOwnerD
{
    //Property 
    //Player
    //bool

}
