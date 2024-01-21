using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SIMTEXT : MonoBehaviour
{
    // Start is called before the first frame update 
    public Text SIMName;
    public Text SIMDoB;
    public Text SIMGen;
    public Text SIMJob;
    public Text SIMExp;
    public Text SIMType;

    public void WriteToSIM(int ID, int valid, int ErrType){
        if(valid == 0){
            if(ID == 0){
                SIMName.text = "Nama: Lily Grace";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 15 February 2000";
                SIMGen.text = "Jenis Kelamin: Wanita";
                SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "7 December 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 1){
                SIMName.text = "Nama: Oliver Scott";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 10 May 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Barista";
                SIMExp.text = "19 April 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 2){
                SIMName.text = "Nama: Ruby Claire";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 5 August 1999";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "30 July 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 3){
                SIMName.text = "Nama: Thomas Blaine";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 20 November 2000";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "29 December 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 4){
                SIMName.text = "Nama: Madison Blaine";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 25 June 2004";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Guru";
                SIMExp.text = "11 November 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 5){
                SIMName.text = "Nama: Scarlett Rose";
                SIMDoB.text = "Tempat Tanggal Lahir: Zehpyrus, 12 April 1998";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pelayan";
                SIMExp.text = "26 October 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 6){
                SIMName.text = "Nama: Henry Blake";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 8 July 1997";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Videografer";
                SIMExp.text = "19 April 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 7){
                SIMName.text = "Nama: Sophia Mae";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 3 September 2002";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Barista";
                SIMExp.text = "3 March 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 8){
                SIMName.text = "Nama: Ethan James";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 14 March 2003";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Tukang Roti";
                SIMExp.text = "14 September 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 9){
                SIMName.text = "Nama: Ava Marie";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 7 October 2002";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "22 May 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 10){
                SIMName.text = "Nama: Lucas Alexander";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 19 January 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "8 February 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 11){
                SIMName.text = "Nama: Harper Grace";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 26 May 2003";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "5 June 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 12){
                SIMName.text = "Nama: Benjamin Cole";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 8 December 2003";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pelayan";
                SIMExp.text = "12 November 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 13){
                SIMName.text = "Nama: Emma Jade";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 2 February 2005";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "18 November 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 14){
                SIMName.text = "Nama: Liam Patrick";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 17 August 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "9 July 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 15){
                SIMName.text = "Nama: Isabella Faith";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 11 April 2003";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "25 April 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 16){
                SIMName.text = "Nama: Noah Harrison";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 30 July 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "30 October 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 17){
                SIMName.text = "Nama: Chloe Elizabeth";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 22 November 2002";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "21 December 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 18){
                SIMName.text = "Nama: Jackson Miles";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 14 June 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "13 April 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 19){
                SIMName.text = "Nama: Amelia Grace";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 9 September 2003";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "6 September 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 20){
                SIMName.text = "Nama: Grace Evelyn";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 5 March 2002";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "28 January 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 21){
                SIMName.text = "Nama: Samuel Ryan";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 18 July 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Koki";
                SIMExp.text = "19 March 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 22){
                SIMName.text = "Nama: Vania Violeta";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 29 October 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "1 November 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 23){
                SIMName.text = "Nama: Caleb Thomas";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 13 December 2002";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "7 July 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 24){
                SIMName.text = "Nama: Stella Claire";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 27 April 2000";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "23 November 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 25){
                SIMName.text = "Nama: Elijah Charles";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 10 January 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Videografer";
                SIMExp.text = "10 May 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 26){
                SIMName.text = "Nama: Janice Jane";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 3 June 2000";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "16 August 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 27){
                SIMName.text = "Nama: Nathan Alexander";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 16 September 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "2 June 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 28){
                SIMName.text = "Nama: Zoe Isabelle";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 20 February 2004";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "15 December 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 29){
                SIMName.text = "Nama: Gabriel Cole";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 23 August 2000";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Tukang Roti";
                SIMExp.text = "27 October 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 30){
                SIMName.text = "Nama: Abigail Rose";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 12 July 2001";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "14 February 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 31){
                SIMName.text = "Nama: William Jasper";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 4 May 2002";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "9 November 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 32){
                SIMName.text = "Nama: Aria Juliet";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 21 March 2004";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengacara";
                SIMExp.text = "5 April 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 33){
                SIMName.text = "Nama: Daniel Bryce";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 6 December 2000";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pelayan";
                SIMExp.text = "20 July 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 34){
                SIMName.text = "Nama: Ella Camilla";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 15 August 2003";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Guru";
                SIMExp.text = "11 March 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 35){
                SIMName.text = "Nama: Jack Oliver";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 28 November 1998";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "3 November 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 36){
                SIMName.text = "Nama: Ava Charlotte";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 9 February 1999";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Videografer";
                SIMExp.text = "24 January 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 37){
                SIMName.text = "Nama: Isaac Nathaniel";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 14 October 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pengacara";
                SIMExp.text = "8 May 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 38){
                SIMName.text = "Nama: Lily Anne";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 25 April 1999";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Tukang Roti";
                SIMExp.text = "16 January 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 39){
                SIMName.text = "Nama: Owen Michael";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 8 June 2003";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "29 August 2026";
                SIMType.text = "Tipe: Mobil";
            }

        }else{
            if(ErrType == 0){
            if(ID == 0){
                SIMName.text = "Nama: Lillie Grace";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 15 February 2000";
                SIMGen.text = "Jenis Kelamin: Wanita";
                SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "7 December 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 1){
                SIMName.text = "Nama: Oliver Scottie";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 10 May 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Barista";
                SIMExp.text = "19 April 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 2){
                SIMName.text = "Nama: Ruby Clara";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 5 August 1999";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "30 July 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 3){
                SIMName.text = "Nama: Thomas Brown";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 20 November 2000";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "29 December 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 4){
                SIMName.text = "Nama: Madisson Blaine";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 25 June 2004";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Guru";
                SIMExp.text = "11 November 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 5){
                SIMName.text = "Nama: Scarle Rose";
                SIMDoB.text = "Tempat Tanggal Lahir: Zehpyrus, 12 April 1998";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pelayan";
                SIMExp.text = "26 October 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 6){
                SIMName.text = "Nama: Henry Fred";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 8 July 1997";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Videografer";
                SIMExp.text = "19 April 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 7){
                SIMName.text = "Nama: Sofia Mae";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 3 September 2002";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Barista";
                SIMExp.text = "3 March 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 8){
                SIMName.text = "Nama: Ethen James";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 14 March 2003";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Tukang Roti";
                SIMExp.text = "14 September 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 9){
                SIMName.text = "Nama: Avarie Marie";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 7 October 2002";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "22 May 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 10){
                SIMName.text = "Nama: Lukas Alexander";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 19 January 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "8 February 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 11){
                SIMName.text = "Nama: Harlow Grace";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 26 May 2003";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "5 June 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 12){
                SIMName.text = "Nama: Benjamen Cole";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 8 December 2003";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pelayan";
                SIMExp.text = "12 November 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 13){
                SIMName.text = "Nama: Emmalyn Jade";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 2 February 2005";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "18 November 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 14){
                SIMName.text = "Nama: Liam Patrickson";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 17 August 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "9 July 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 15){
                SIMName.text = "Nama: Isabella Faithlyn";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 11 April 2003";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "25 April 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 16){
                SIMName.text = "Nama: Noah Harris";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 30 July 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "30 October 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 17){
                SIMName.text = "Nama: Khloe Elizabeth";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 22 November 2002";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "21 December 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 18){
                SIMName.text = "Nama: Jaxon Miles";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 14 June 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "13 April 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 19){
                SIMName.text = "Nama: Emelia Grace";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 9 September 2003";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "6 September 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 20){
                SIMName.text = "Nama: Gracie Evelyn";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 5 March 2002";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "28 January 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 21){
                SIMName.text = "Nama: Samual Ryan";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 18 July 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Koki";
                SIMExp.text = "19 March 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 22){
                SIMName.text = "Nama: Vanessa Violet";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 29 October 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "1 November 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 23){
                SIMName.text = "Nama: Kaleb Thomas";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 13 December 2002";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "7 July 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 24){
                SIMName.text = "Nama: Stella Clairey";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 27 April 2000";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "23 November 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 25){
                SIMName.text = "Nama: Elyjah Charles";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 10 January 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Videografer";
                SIMExp.text = "10 May 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 26){
                SIMName.text = "Nama: Janis Jane";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 3 June 2000";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "16 August 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 27){
                SIMName.text = "Nama: Nathen Alexander";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 16 September 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "2 June 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 28){
                SIMName.text = "Nama: Zoey Isabelle";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 20 February 2004";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "15 December 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 29){
                SIMName.text = "Nama: Gabrielle Cole";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 23 August 2000";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Tukang Roti";
                SIMExp.text = "27 October 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 30){
                SIMName.text = "Nama: Abigale Rose";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 12 July 2001";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "14 February 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 31){
                SIMName.text = "Nama: Willian Jasper";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 4 May 2002";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "9 November 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 32){
                SIMName.text = "Nama: Aria Juliette";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 21 March 2004";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengacara";
                SIMExp.text = "5 April 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 33){
                SIMName.text = "Nama: Danyel Bryce";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 6 December 2000";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pelayan";
                SIMExp.text = "20 July 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 34){
                SIMName.text = "Nama: Ella Camila";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 15 August 2003";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Guru";
                SIMExp.text = "11 March 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 35){
                SIMName.text = "Nama: Jake Oliver";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 28 November 1998";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "3 November 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 36){
                SIMName.text = "Nama: Ava Charlize";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 9 February 1999";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Videografer";
                SIMExp.text = "24 January 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 37){
                SIMName.text = "Nama: Izak Nathanael";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 14 October 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pengacara";
                SIMExp.text = "8 May 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 38){
                SIMName.text = "Nama: Lily Annabelle";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 25 April 1999";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Tukang Roti";
                SIMExp.text = "16 January 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 39){
                SIMName.text = "Nama: Owen Michaelson";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 8 June 2003";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "29 August 2026";
                SIMType.text = "Tipe: Mobil";
            }
            }else if(ErrType == 1){
            if(ID == 0){
                SIMName.text = "Nama: Lily Grace";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 15 February 2006";
                SIMGen.text = "Jenis Kelamin: Wanita";
                SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "7 December 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 1){
                SIMName.text = "Nama: Oliver Scott";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 10 May 2006";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Barista";
                SIMExp.text = "19 April 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 2){
                SIMName.text = "Nama: Ruby Claire";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 5 August 2007";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "30 July 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 3){
                SIMName.text = "Nama: Thomas Blaine";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 20 November 2006";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "29 December 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 4){
                SIMName.text = "Nama: Madison Blaine";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 25 June 2008";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Guru";
                SIMExp.text = "11 November 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 5){
                SIMName.text = "Nama: Scarlett Rose";
                SIMDoB.text = "Tempat Tanggal Lahir: Zehpyrus, 12 April 2006";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pelayan";
                SIMExp.text = "26 October 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 6){
                SIMName.text = "Nama: Henry Blake";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 8 July 2006";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Videografer";
                SIMExp.text = "19 April 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 7){
                SIMName.text = "Nama: Sophia Mae";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 3 September 2007";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Barista";
                SIMExp.text = "3 March 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 8){
                SIMName.text = "Nama: Ethan James";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 14 March 2006";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Tukang Roti";
                SIMExp.text = "14 September 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 9){
                SIMName.text = "Nama: Ava Marie";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 7 October 2008";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "22 May 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 10){
                SIMName.text = "Nama: Lucas Alexander";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 19 January 2007";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "8 February 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 11){
                SIMName.text = "Nama: Harper Grace";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 26 May 2008";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "5 June 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 12){
                SIMName.text = "Nama: Benjamin Cole";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 8 December 2005";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pelayan";
                SIMExp.text = "12 November 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 13){
                SIMName.text = "Nama: Emma Jade";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 2 February 2007";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "18 November 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 14){
                SIMName.text = "Nama: Liam Patrick";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 17 August 2008";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "9 July 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 15){
                SIMName.text = "Nama: Isabella Faith";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 11 April 2006";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "25 April 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 16){
                SIMName.text = "Nama: Noah Harrison";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 30 July 2006";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "30 October 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 17){
                SIMName.text = "Nama: Chloe Elizabeth";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 22 November 2005";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "21 December 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 18){
                SIMName.text = "Nama: Jackson Miles";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 14 June 2006";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "13 April 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 19){
                SIMName.text = "Nama: Amelia Grace";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 9 September 2007";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "6 September 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 20){
                SIMName.text = "Nama: Grace Evelyn";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 5 March 2008";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "28 January 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 21){
                SIMName.text = "Nama: Samuel Ryan";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 18 July 2006";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Koki";
                SIMExp.text = "19 March 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 22){
                SIMName.text = "Nama: Vania Violeta";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 29 October 2007";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "1 November 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 23){
                SIMName.text = "Nama: Caleb Thomas";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 13 December 2006";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "7 July 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 24){
                SIMName.text = "Nama: Stella Claire";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 27 April 2007";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "23 November 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 25){
                SIMName.text = "Nama: Elijah Charles";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 10 January 2021";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Videografer";
                SIMExp.text = "10 May 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 26){
                SIMName.text = "Nama: Janice Jane";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 3 June 2020";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "16 August 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 27){
                SIMName.text = "Nama: Nathan Alexander";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 16 September 2046";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "2 June 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 28){
                SIMName.text = "Nama: Zoe Isabelle";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 20 February 2006";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "15 December 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 29){
                SIMName.text = "Nama: Gabriel Cole";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 23 August 2006";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Tukang Roti";
                SIMExp.text = "27 October 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 30){
                SIMName.text = "Nama: Abigail Rose";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 12 July 2006";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "14 February 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 31){
                SIMName.text = "Nama: William Jasper";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 4 May 2007";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "9 November 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 32){
                SIMName.text = "Nama: Aria Juliet";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 21 March 2008";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengacara";
                SIMExp.text = "5 April 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 33){
                SIMName.text = "Nama: Daniel Bryce";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 6 December 2005";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pelayan";
                SIMExp.text = "20 July 2024";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 34){
                SIMName.text = "Nama: Ella Camilla";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 15 August 2006";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Guru";
                SIMExp.text = "11 March 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 35){
                SIMName.text = "Nama: Jack Oliver";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 28 November 2005";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "3 November 2026";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 36){
                SIMName.text = "Nama: Ava Charlotte";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 9 February 2006";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Videografer";
                SIMExp.text = "24 January 2028";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 37){
                SIMName.text = "Nama: Isaac Nathaniel";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 14 October 2006";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pengacara";
                SIMExp.text = "8 May 2027";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 38){
                SIMName.text = "Nama: Lily Anne";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 25 April 2008";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Tukang Roti";
                SIMExp.text = "16 January 2025";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 39){
                SIMName.text = "Nama: Owen Michael";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 8 June 2007";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "29 August 2026";
                SIMType.text = "Tipe: Mobil";
            }
            }else if(ErrType == 2){
            if(ID == 0){
                SIMName.text = "Nama: Lily Grace";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 15 February 2000";
                SIMGen.text = "Jenis Kelamin: Wanita";
                SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "7 December 2022";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 1){
                SIMName.text = "Nama: Oliver Scott";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 10 May 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Barista";
                SIMExp.text = "19 April 2022";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 2){
                SIMName.text = "Nama: Ruby Claire";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 5 August 1999";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "30 July 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 3){
                SIMName.text = "Nama: Thomas Blaine";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 20 November 2000";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "29 December 2021";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 4){
                SIMName.text = "Nama: Madison Blaine";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 25 June 2004";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Guru";
                SIMExp.text = "11 November 2022";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 5){
                SIMName.text = "Nama: Scarlett Rose";
                SIMDoB.text = "Tempat Tanggal Lahir: Zehpyrus, 12 April 1998";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pelayan";
                SIMExp.text = "26 October 2021";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 6){
                SIMName.text = "Nama: Henry Blake";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 8 July 1997";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Videografer";
                SIMExp.text = "19 April 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 7){
                SIMName.text = "Nama: Sophia Mae";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 3 September 2002";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Barista";
                SIMExp.text = "3 March 2020";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 8){
                SIMName.text = "Nama: Ethan James";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 14 March 2003";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Tukang Roti";
                SIMExp.text = "14 September 2019";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 9){
                SIMName.text = "Nama: Ava Marie";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 7 October 2002";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "22 May 2020";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 10){
                SIMName.text = "Nama: Lucas Alexander";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 19 January 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "8 February 2020";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 11){
                SIMName.text = "Nama: Harper Grace";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 26 May 2003";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "5 June 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 12){
                SIMName.text = "Nama: Benjamin Cole";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 8 December 2003";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pelayan";
                SIMExp.text = "12 November 2022";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 13){
                SIMName.text = "Nama: Emma Jade";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 2 February 2005";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "18 November 2022";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 14){
                SIMName.text = "Nama: Liam Patrick";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 17 August 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "9 July 2021";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 15){
                SIMName.text = "Nama: Isabella Faith";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 11 April 2003";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "25 April 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 16){
                SIMName.text = "Nama: Noah Harrison";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 30 July 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "30 October 2021";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 17){
                SIMName.text = "Nama: Chloe Elizabeth";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 22 November 2002";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "21 December 2021";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 18){
                SIMName.text = "Nama: Jackson Miles";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 14 June 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "13 April 2020";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 19){
                SIMName.text = "Nama: Amelia Grace";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 9 September 2003";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "6 September 2022";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 20){
                SIMName.text = "Nama: Grace Evelyn";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 5 March 2002";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "28 January 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 21){
                SIMName.text = "Nama: Samuel Ryan";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 18 July 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Koki";
                SIMExp.text = "19 March 2020";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 22){
                SIMName.text = "Nama: Vania Violeta";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 29 October 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Tukang Kebun";
                SIMExp.text = "1 November 2018";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 23){
                SIMName.text = "Nama: Caleb Thomas";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 13 December 2002";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "7 July 2021";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 24){
                SIMName.text = "Nama: Stella Claire";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 27 April 2000";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengusaha";
                SIMExp.text = "23 November 2021";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 25){
                SIMName.text = "Nama: Elijah Charles";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 10 January 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Videografer";
                SIMExp.text = "10 May 2019";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 26){
                SIMName.text = "Nama: Janice Jane";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 3 June 2000";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "16 August 2022";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 27){
                SIMName.text = "Nama: Nathan Alexander";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 16 September 2001";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "2 June 2020";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 28){
                SIMName.text = "Nama: Zoe Isabelle";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 20 February 2004";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Bartender";
                SIMExp.text = "15 December 2022";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 29){
                SIMName.text = "Nama: Gabriel Cole";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 23 August 2000";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Tukang Roti";
                SIMExp.text = "27 October 2021";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 30){
                SIMName.text = "Nama: Abigail Rose";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 12 July 2001";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pekerja Swasta";
                SIMExp.text = "14 February 2022";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 31){
                SIMName.text = "Nama: William Jasper";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 4 May 2002";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "9 November 2021";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 32){
                SIMName.text = "Nama: Aria Juliet";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 21 March 2004";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Pengacara";
                SIMExp.text = "5 April 2022";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 33){
                SIMName.text = "Nama: Daniel Bryce";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 6 December 2000";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pelayan";
                SIMExp.text = "20 July 2020";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 34){
                SIMName.text = "Nama: Ella Camilla";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 15 August 2003";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Guru";
                SIMExp.text = "11 March 2018";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 35){
                SIMName.text = "Nama: Jack Oliver";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 28 November 1998";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "3 November 2020";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 36){
                SIMName.text = "Nama: Ava Charlotte";
                SIMDoB.text = "Tempat Tanggal Lahir: Ascendron, 9 February 1999";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Videografer";
                SIMExp.text = "24 January 2022";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 37){
                SIMName.text = "Nama: Isaac Nathaniel";
                SIMDoB.text = "Tempat Tanggal Lahir: Solstice, 14 October 2004";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Pengacara";
                SIMExp.text = "8 May 2022";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 38){
                SIMName.text = "Nama: Lily Anne";
                SIMDoB.text = "Tempat Tanggal Lahir: Zephyrus, 25 April 1999";
                SIMGen.text = "Jenis Kelamin: Wanita";
  	            SIMJob.text = "Pekerjaan: Tukang Roti";
                SIMExp.text = "16 January 2023";
                SIMType.text = "Tipe: Mobil";
            }else if(ID == 39){
                SIMName.text = "Nama: Owen Michael";
                SIMDoB.text = "Tempat Tanggal Lahir: Verdantra, 8 June 2003";
                SIMGen.text = "Jenis Kelamin: Pria";
  	            SIMJob.text = "Pekerjaan: Petani";
                SIMExp.text = "29 August 2019";
                SIMType.text = "Tipe: Mobil";
            }    
            }else if(ErrType >= 3){
                WriteToSIM(ID, 0, 0);
            }
        }
    }
}
