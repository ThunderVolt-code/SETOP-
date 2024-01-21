using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulePopUp : MonoBehaviour
{
    bool BookUp = true;
    public float speed;
    
    public Transform top;
    public Transform bot;
    public Transform target;
    // Start is called before the first frame update

   
    public void MoveBook()
    {
        if(BookUp == false)
        {
            BookUp = true;
        }
        else if(BookUp == true)
        {
            BookUp = false;
        }
    }

    public void Update()
    {
        if(BookUp == false)
        {
            target.position = top.position;
        }
        else if(BookUp == true)
        {
            target.position = bot.position;
        }
        var stepspeeed = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, stepspeeed);
    }
}
