using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrepCar : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite White;
    public Sprite Red;
    public Sprite Blue;
    public Sprite Grey;
    public SpriteRenderer SRend;
    public Text LPlate;
    
    public void Prepare(int ID){
        if(ID == 0 || ID == 3 || ID == 6 || ID == 8 || ID == 9 || ID == 11 || ID == 15 || ID == 17 || ID == 20 || ID == 22 || ID == 26 || ID == 29 || ID == 30 || ID == 32 || ID == 34 || ID == 37 || ID == 39){
            SRend.sprite = Red;
        }else if(ID == 1 || ID == 5 || ID == 10 || ID == 12 || ID == 14 || ID == 18 || ID == 23 || ID == 25 || ID == 28 || ID == 31 || ID == 36){
            SRend.sprite = White;
        }else if(ID == 7 || ID == 13 || ID == 19 || ID == 21 || ID == 24){
            SRend.sprite = Blue;
        }else if(ID == 2 || ID == 4 || ID == 16 || ID == 27 || ID == 33 || ID == 35 || ID == 38){
            SRend.sprite = Grey;
        }

        if(ID == 0)
        {
            LPlate.text = "V 579";
        }else if(ID == 1)
        {
            LPlate.text = "S 1185";
        }else if(ID == 2)
        {
            LPlate.text = "Z 9141";
        }else if(ID == 3)
        {
            LPlate.text = "A 36439";
        }else if(ID == 4)
        {
            LPlate.text = "A 87819";
        }else if(ID == 5)
        {
            LPlate.text = "Z 5591";
        }else if(ID == 6)
        {
            LPlate.text = "A 67891";
        }else if(ID == 7)
        {
            LPlate.text = "Z 7384";
        }else if(ID == 8)
        {
            LPlate.text = "Z 5692";
        }else if(ID == 9)
        {
            LPlate.text = "A 48296";
        }else if(ID == 10)
        {
            LPlate.text = "S 3729";
        }else if(ID == 11)
        {
            LPlate.text = "V 572";
        }else if(ID == 12)
        {
            LPlate.text = "Z 1248";
        }else if(ID == 13)
        {
            LPlate.text = "A 76541";
        }else if(ID == 14)
        {
            LPlate.text = "V 683";
        }else if(ID == 15)
        {
            LPlate.text = "S 6851";
        }else if(ID == 16)
        {
            LPlate.text = "A 23857";
        }else if(ID == 17)
        {
            LPlate.text = "Z 8935";
        }else if(ID == 18)
        {
            LPlate.text = "S 9143";
        }else if(ID == 19)
        {
            LPlate.text = "V 941";
        }else if(ID == 20)
        {
            LPlate.text = "A 91462";
        }else if(ID == 21)
        {
            LPlate.text = "Z 6023";
        }else if(ID == 22)
        {
            LPlate.text = "V 826";
        }else if(ID == 23)
        {
            LPlate.text = "S 5268";
        }else if(ID == 24)
        {
            LPlate.text = "Z 4159";
        }else if(ID == 25)
        {
            LPlate.text = "A 63924";
        }else if(ID == 26)
        {
            LPlate.text = "S 4391";
        }else if(ID == 27)
        {
            LPlate.text = "V 395";
        }else if(ID == 28)
        {
            LPlate.text = "A 37189";
        }else if(ID == 29)
        {
            LPlate.text = "Z 2875";
        }else if(ID == 30)
        {
            LPlate.text = "S 1873";
        }else if(ID == 31)
        {
            LPlate.text = "V 174";
        }else if(ID == 32)
        {
            LPlate.text = "A 50472";
        }else if(ID == 33)
        {
            LPlate.text = "Z 6912";
        }else if(ID == 34)
        {
            LPlate.text = "S 9537";
        }else if(ID == 35)
        {
            LPlate.text = "V 269";
        }else if(ID == 36)
        {
            LPlate.text = "A 23857";
        }else if(ID == 37)
        {
            LPlate.text = "S 6142";
        }else if(ID == 38)
        {
            LPlate.text = "Z 8341";
        }else if(ID == 39)
        {
            LPlate.text = "V 548";
        }
    }

    

    // private void update(){
    //     if(active = false)
    //     {
    //         Target.position = Right.position;
    //     }else if(active = true)
    //     {
    //         Target.position = Mid.position;
    //     }
    //     var CarSpeed = Cspeed * Time.deltaTime;
    //     transform.position = Vector3.MoveTowards(transform.position, Target.position, CarSpeed);
    // }
}
