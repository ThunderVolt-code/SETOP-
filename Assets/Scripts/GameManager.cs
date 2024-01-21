using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int Person;
    int health = 3;
    public SIMTEXT SimTextController;
    public STNKTEXT STNKTextController;
    public Text RulesText;
    public Text UIText;
    public RulePopUp GameOverPop;
    public Text GoverText;
    public PrepCar Car;
    public PrepPerson Avatar;
    public AudioClip Correct;
    public AudioClip Wrong;
    public AudioClip Lose;
    public AudioSource Adios;
    public AudioSource BGM;
    int[] numbers = new int[40]; // People ID's
    int[] result = new int[20];
    int valid;
    int score = 0;
    int HScore = 0;
    bool GOver = false;
    bool pause = false;

    public void Start (){
        GenerateLevel();
    }

    public void GenerateLevel()
    {
        Person = 20;
        for (int i = 0; i< numbers.Length; i++ )
            {
                numbers[i] = i;
            }
        for (int i = 0; i < numbers.Length; i++ )
            {
                int tmp = numbers[i];
                int r = Random.Range(i, numbers.Length);
                numbers[i] = numbers[r];
                numbers[r] = tmp;
            }

        for(int j = 0; j<result.Length; j++)
        {
            result[j] = numbers[j];
        }
        //RulesText.text = "Prosedur Hari Ini:\n 1. Nama pada kedua surat harus sama\n 2. Semua info pada kedua surat tidak boleh bertanda bintang (*)\n 3. Tanggal expiry harus berformat Y dan bukan X.\n\n\nScore: " + score + "\nLevel Baru, skor reset.";
        FillCard(result[Person-1]);
    }
    public void Lepas()
    {
        if(GOver == false && pause == false){

        Person--;
        if(valid == 0){
            score++;
            Adios.PlayOneShot(Correct, 1.0f);
            if(score> HScore) HScore = score;
            UIText.text = "Score: " + score + "\nHealth: " + health + "\nDate: 23 Oct 2023";
        } else{
            health--;
            if(health != 0)Adios.PlayOneShot(Wrong, 1.0f);
            UIText.text = "Score: " + score + "\nHealth: " + health + "\nDate: 23 Oct 2023";
            if(health <= 0) GameOver();
        }

        if(Person == 0)
        {
            GenerateLevel();
        }
        FillCard(result[Person-1]);
        }
    }
    public void Peringatan()
    {
        if(GOver == false && pause == false){
        Person--;
        if(valid == 1){
            score++;
            Adios.PlayOneShot(Correct, 1.0f);
            if(score> HScore) HScore = score;
            UIText.text = "Score: " + score + "\nHealth: " + health + "\nDate: 23 Oct 2023";
        } else{
            health--;
            if(health !=0) Adios.PlayOneShot(Wrong, 1.0f);
            UIText.text = "Score: " + score + "\nHealth: " + health + "\nDate: 23 Oct 2023";
            if(health <= 0) GameOver();
        }

        if(Person == 0)
        {
            GenerateLevel();
        }
        FillCard(result[Person-1]);
        }
    }
    // public void Tilang()
    // {
    //     Person--;
    //     RulesText.text = "Prosedur Hari Ini:\n 1. Nama pada kedua surat harus sama\n 2. Semua info pada kedua surat tidak boleh bertanda bintang (*)\n 3. Tanggal expiry harus berformat Y dan bukan X.\n\n\nScore:" + score + "\n Respons Salah.";
    //     if(Person == 0)
    //     {
    //         GenerateLevel();
    //     }
    //     FillCard(result[Person-1]);
    // }
    // public void Tangkap()
    // {
    //     Person--;
    //     RulesText.text = "Prosedur Hari Ini:\n 1. Nama pada kedua surat harus sama\n 2. Semua info pada kedua surat tidak boleh bertanda bintang (*)\n 3. Tanggal expiry harus berformat Y dan bukan X.\n\n\nScore:" + score + "\n Respons Salah.";
    //     if(Person == 0)
    //     {
    //         GenerateLevel();
    //     }
    //     FillCard(result[Person-1]);
    // }

    private void FillCard(int ID)
    {
        valid = Random.Range(0, 2);
        int ErrType = Random.Range(0, 7);
        /*0 = Nama SIM
        1 = DoB
        2 = Expiry of Sim
        3 = Nama STNK
        4 = Plate Number
        5 = STNK Expiry
        6 = Vehicle Color
        */
        SimTextController.WriteToSIM(ID, valid, ErrType);
        STNKTextController.WriteToSTNK(ID, valid, ErrType);
        Car.Prepare(ID);
        Avatar.PreparePerson(ID);
        

        Debug.Log("Validitas: " + valid + ", Tipe: " + ErrType);
    }

    private void GameOver()
    {
        Adios.PlayOneShot(Lose, 1.0f);
        BGM.volume = 0.5f;
        GOver = true;
        GoverText.text = "Game Over!\nScore: " + score + "\nHigh Score: " + HScore + "\nClick to Restart!";
        GameOverPop.MoveBook();
    }

    public void RestartGame()
    {
        if(GOver == true){
            BGM.volume = 1.0f;
            GOver = false;
            score = 0;
            health = 3;
            GameOverPop.MoveBook();
            UIText.text = "Score: " + score + "\nHealth: " + health + "\nDate: 23 Oct 2023";
            GenerateLevel();
        }else if(pause == true)
        {
            BGM.volume = 1.0f;
            pause = false;
            GameOverPop.MoveBook();
        }
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log("Open pause menu!");
            //Adios.PlayOneShot(Lose, 1.0f);
            BGM.volume = 0.5f;
            pause = true;
            GoverText.text = "Score: " + score + "\nHigh Score: " + HScore + "\nClick to Resume!";
            GameOverPop.MoveBook();
        }
    }
}
