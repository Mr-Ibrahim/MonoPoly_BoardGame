using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    int currentIndex = 0;
    public bool turn = false;
    [SerializeField]
    Button DiceBtn;

    private void Start()
    {
        DiceBtn = GameObject.FindObjectOfType<Button>();
    }
    public void Update()
    {
        if (turn)
        {
            StartCoroutine("WaitTime");
        }
    }
    public void TaskOnClick()
    {

        if (turn)
        {
            if (DiceBtn.IsInteractable())
            {
                DiceBtn.interactable = false;
            }
            StartCoroutine("MovePlayer");
            StopCoroutine("WaitTime");
        }
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
        if (!DiceBtn.IsInteractable())
        {
            DiceBtn.interactable = true;
        }
        else
        {
            print("Kuttay ka bacha change nahi ho rraha");
        }
        print("I moved " + gameObject.name);
        currentIndex += num;
        turn = false;


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
