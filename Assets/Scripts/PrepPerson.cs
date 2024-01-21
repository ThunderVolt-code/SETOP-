using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepPerson : MonoBehaviour
{
    public Sprite Man1;
    public Sprite Man2;
    public Sprite Man3;
    public Sprite Man4;
    public Sprite Woman1;
    public Sprite Woman2;
    public Sprite Woman3;
    public Sprite Woman4;
    public SpriteRenderer SRend;
    // Start is called before the first frame update
    public void PreparePerson(int ID)
    {
        if(ID == 1 || ID == 3 || ID == 16 || ID == 23 || ID == 31){
            SRend.sprite = Man1;
        }else if(ID == 6 || ID == 8 || ID == 18 || ID == 25 || ID == 33){
            SRend.sprite = Man2;
        }else if(ID == 9 || ID == 10 || ID == 21 || ID == 27 || ID == 37){
            SRend.sprite = Man3;
        }else if(ID == 12 || ID == 14 || ID == 22 || ID == 29 || ID == 39){
            SRend.sprite = Man4;
        }else if(ID == 1 || ID == 2 || ID == 17 || ID == 26 || ID == 34){
            SRend.sprite = Woman1;
        }else if(ID == 4 || ID == 5 || ID == 19 || ID == 28 || ID == 35){
            SRend.sprite = Woman2;
        }else if(ID == 7 || ID == 11 || ID == 20 || ID == 30 || ID == 36){
            SRend.sprite = Woman3;
        }else if(ID == 13 || ID == 15 || ID == 24|| ID == 32 || ID == 38){
            SRend.sprite = Woman4;
        }
        
    }
}
