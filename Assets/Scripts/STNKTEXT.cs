using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STNKTEXT : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Name;
    public Text Tipe;
    public Text Plat;
    public Text Exp;
    public Text Color;

    public void WriteToSTNK(int ID, int valid, int ErrType){
        if(valid == 0){
            if(ID == 0){
                Name.text = "Nama: Lily Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 579";
                Exp.text = "BERLAKU SAMPAI: 01-03-2026";
                Color.text = "Merah";
            }else if(ID == 1){
                Name.text = "Nama: Oliver Scott";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 1185";
                Exp.text = "BERLAKU SAMPAI: 15-07-2025";
                Color.text = "Putih";
            }else if(ID == 2){
                Name.text = "Nama: Ruby Claire";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 9141";
                Exp.text = "BERLAKU SAMPAI: 10-10-2025";
                Color.text = "Abu-abu";
            }else if(ID == 3){
                Name.text = "Nama: Thomas Blaine";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 36439";
                Exp.text = "BERLAKU SAMPAI: 05-01-2024";
                Color.text = "Merah";
            }else if(ID == 4){
                Name.text = "Nama: Madison Blaine";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 87819";
                Exp.text = "BERLAKU SAMPAI: 20-09-2026";
                Color.text = "Abu-abu";
            }else if(ID == 5){
                Name.text = "Nama: Scarlett Rose";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 5591";
                Exp.text = "BERLAKU SAMPAI: 25-05-2026";
                Color.text = "Putih";
            }else if(ID == 6){
                Name.text = "Nama: Henry Blake";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 67891";
                Exp.text = "BERLAKU SAMPAI: 30-08-2024";
                Color.text = "Merah";
            }else if(ID == 7){
                Name.text = "Nama: Sophia Mae";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 7384";
                Exp.text = "BERLAKU SAMPAI: 09-03-2025";
                Color.text = "Biru";
            }else if(ID == 8){
                Name.text = "Nama: Ethan James";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 5692";
                Exp.text = "BERLAKU SAMPAI: 17-07-2024";
                Color.text = "Merah";
            }else if(ID == 9){
                Name.text = "Nama: Ava Marie";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 48296";
                Exp.text = "BERLAKU SAMPAI: 05-11-2023";
                Color.text = "Merah";
            }else if(ID == 10){
                Name.text = "Nama: Lucas Alexander";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 3729";
                Exp.text = "BERLAKU SAMPAI: 22-01-2026";
                Color.text = "Putih";
            }else if(ID == 11){
                Name.text = "Nama: Harper Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 572";
                Exp.text = "BERLAKU SAMPAI: 14-09-2027";
                Color.text = "Merah";
            }else if(ID == 12){
                Name.text = "Nama: Benjamin Cole";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 1248";
                Exp.text = "BERLAKU SAMPAI: 03-04-2024";
                Color.text = "Putih";
            }else if(ID == 13){
                Name.text = "Nama: Emma Jade";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 76541";
                Exp.text = "BERLAKU SAMPAI: 19-06-2028";
                Color.text = "Biru";
            }else if(ID == 14){
                Name.text = "Nama: Liam Patrick";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 683";
                Exp.text = "BERLAKU SAMPAI: 28-12-2023";
                Color.text = "Putih";
            }else if(ID == 15){
                Name.text = "Nama: Isabella Faith";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 6851";
                Exp.text = "BERLAKU SAMPAI: 07-08-2025";
                Color.text = "Merah";
            }else if(ID == 16){
                Name.text = "Nama: Noah Harrison";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 23857";
                Exp.text = "BERLAKU SAMPAI: 12-02-2028";
                Color.text = "Abu-abu";
            }else if(ID == 17){
                Name.text = "Nama: Chloe Elizabeth";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 8935";
                Exp.text = "BERLAKU SAMPAI: 25-10-2024";
                Color.text = "Merah";
            }else if(ID == 18){
                Name.text = "Nama: Jackson Miles";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 9143";
                Exp.text = "BERLAKU SAMPAI: 10-05-2027";
                Color.text = "Putih";
            }else if(ID == 19){
                Name.text = "Nama: Amelia Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 941";
                Exp.text = "BERLAKU SAMPAI: 02-03-2026";
                Color.text = "Biru";
            }else if(ID == 20){
                Name.text = "Nama: Grace Evelyn";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 91462";
                Exp.text = "BERLAKU SAMPAI: 18-04-2026";
                Color.text = "Merah";
            }else if(ID == 21){
                Name.text = "Nama: Samuel Ryan";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 6023";
                Exp.text = "BERLAKU SAMPAI: 11-07-2028";
                Color.text = "Biru";
            }else if(ID == 22){
                Name.text = "Nama: Vania Violeta";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 826";
                Exp.text = "BERLAKU SAMPAI: 04-11-2024";
                Color.text = "Merah";
            }else if(ID == 23){
                Name.text = "Nama: Caleb Thomas";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 5268";
                Exp.text = "BERLAKU SAMPAI: 21-04-2026";
                Color.text = "Putih";
            }else if(ID == 24){
                Name.text = "Nama: Stella Claire";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 4159";
                Exp.text = "BERLAKU SAMPAI: 16-08-2027";
                Color.text = "Biru";
            }else if(ID == 25){
                Name.text = "Nama: Elijah Charles";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 63924";
                Exp.text = "BERLAKU SAMPAI: 08-01-2025";
                Color.text = "Putih";
            }else if(ID == 26){
                Name.text = "Nama: Janice Jane";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 4391";
                Exp.text = "BERLAKU SAMPAI: 30-06-2026";
                Color.text = "Merah";
            }else if(ID == 27){
                Name.text = "Nama: Nathan Alexander";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 395";
                Exp.text = "BERLAKU SAMPAI: 06-05-2025";
                Color.text = "Abu-abu";
            }else if(ID == 28){
                Name.text = "Nama: Zoe Isabelle";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 37189";
                Exp.text = "BERLAKU SAMPAI: 23-08-2024";
                Color.text = "Putih";
            }else if(ID == 29){
                Name.text = "Nama: Gabriel Cole";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 2875";
                Exp.text = "BERLAKU SAMPAI: 15-01-2027";
                Color.text = "Merah";
            }else if(ID == 30){
                Name.text = "Nama: Abigail Rose";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 1873";
                Exp.text = "BERLAKU SAMPAI: 30-10-2023";
                Color.text = "Merah";
            }else if(ID == 31){
                Name.text = "Nama: William Jasper";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 174";
                Exp.text = "BERLAKU SAMPAI: 09-10-2026";
                Color.text = "Putih";
            }else if(ID == 32){
                Name.text = "Nama: Aria Juliet";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 50472";
                Exp.text = "BERLAKU SAMPAI: 01-02-2025";
                Color.text = "Merah";
            }else if(ID == 33){
                Name.text = "Nama: Daniel Bryce";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 6912";
                Exp.text = "BERLAKU SAMPAI: 20-07-2028";
                Color.text = "Abu-abu";
            }else if(ID == 34){
                Name.text = "Nama: Ella Camilla";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 9537";
                Exp.text = "BERLAKU SAMPAI: 11-11-2023";
                Color.text = "Merah";
            }else if(ID == 35){
                Name.text = "Nama: Jack Oliver";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 269";
                Exp.text = "BERLAKU SAMPAI: 03-10-2025";
                Color.text = "Abu-abu";
            }else if(ID == 36){
                Name.text = "Nama: Ava Charlotte";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 23857";
                Exp.text = "BERLAKU SAMPAI: 18-03-2028";
                Color.text = "Putih";
            }else if(ID == 37){
                Name.text = "Nama: Isaac Nathaniel";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 6142";
                Exp.text = "BERLAKU SAMPAI: 29-10-2024";
                Color.text = "Merah";
            }else if(ID == 38){
                Name.text = "Nama: Lily Anne";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 8341";
                Exp.text = "BERLAKU SAMPAI: 14-07-2027";
                Color.text = "Abu-abu";
            }else if(ID == 39){
                Name.text = "Nama: Owen Michael";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 548";
                Exp.text = "BERLAKU SAMPAI: 07-03-2026";
                Color.text = "Merah";
            }

        }else{
            if(ErrType <= 2){
                WriteToSTNK(ID, 0, 0);
            }else if(ErrType ==  3){
                if(ID == 0){
                Name.text = "Nama: Lillie Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 579";
                Exp.text = "BERLAKU SAMPAI: 01-03-2026";
                Color.text = "Merah";
            }else if(ID == 1){
                Name.text = "Nama: Oliver Scottie";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 1185";
                Exp.text = "BERLAKU SAMPAI: 15-07-2025";
                Color.text = "Putih";
            }else if(ID == 2){
                Name.text = "Nama: Ruby Clara";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 9141";
                Exp.text = "BERLAKU SAMPAI: 10-10-2025";
                Color.text = "Abu-abu";
            }else if(ID == 3){
                Name.text = "Nama: Thomas Brown";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 36439";
                Exp.text = "BERLAKU SAMPAI: 05-01-2024";
                Color.text = "Merah";
            }else if(ID == 4){
                Name.text = "Nama: Madisson Blaine";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 87819";
                Exp.text = "BERLAKU SAMPAI: 20-09-2026";
                Color.text = "Abu-abu";
            }else if(ID == 5){
                Name.text = "Nama: Scarle Rose";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 5591";
                Exp.text = "BERLAKU SAMPAI: 25-05-2026";
                Color.text = "Putih";
            }else if(ID == 6){
                Name.text = "Nama: Henry Fred";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 67891";
                Exp.text = "BERLAKU SAMPAI: 30-08-2024";
                Color.text = "Merah";
            }else if(ID == 7){
                Name.text = "Nama: Sofia Mae";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 7384";
                Exp.text = "BERLAKU SAMPAI: 09-03-2025";
                Color.text = "Biru";
            }else if(ID == 8){
                Name.text = "Nama: Ethen James";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 5692";
                Exp.text = "BERLAKU SAMPAI: 17-07-2024";
                Color.text = "Merah";
            }else if(ID == 9){
                Name.text = "Nama: Averie Marie";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 48296";
                Exp.text = "BERLAKU SAMPAI: 05-11-2023";
                Color.text = "Merah";
            }else if(ID == 10){
                Name.text = "Nama: Lukas Alexander";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 3729";
                Exp.text = "BERLAKU SAMPAI: 22-01-2026";
                Color.text = "Putih";
            }else if(ID == 11){
                Name.text = "Nama: Harlow Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 572";
                Exp.text = "BERLAKU SAMPAI: 14-09-2027";
                Color.text = "Merah";
            }else if(ID == 12){
                Name.text = "Nama: Benjamen Cole";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 1248";
                Exp.text = "BERLAKU SAMPAI: 03-04-2024";
                Color.text = "Putih";
            }else if(ID == 13){
                Name.text = "Nama: Emmalyn Jade";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 76541";
                Exp.text = "BERLAKU SAMPAI: 19-06-2028";
                Color.text = "Biru";
            }else if(ID == 14){
                Name.text = "Nama: Liam Patrickson";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 683";
                Exp.text = "BERLAKU SAMPAI: 28-12-2023";
                Color.text = "Putih";
            }else if(ID == 15){
                Name.text = "Nama: Isabella Faithlyn";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 6851";
                Exp.text = "BERLAKU SAMPAI: 07-08-2025";
                Color.text = "Merah";
            }else if(ID == 16){
                Name.text = "Nama: Noah Harris";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 23857";
                Exp.text = "BERLAKU SAMPAI: 12-02-2028";
                Color.text = "Abu-abu";
            }else if(ID == 17){
                Name.text = "Nama: Khloe Elizabeth";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 8935";
                Exp.text = "BERLAKU SAMPAI: 25-10-2024";
                Color.text = "Merah";
            }else if(ID == 18){
                Name.text = "Nama: Jaxon Miles";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 9143";
                Exp.text = "BERLAKU SAMPAI: 10-05-2027";
                Color.text = "Putih";
            }else if(ID == 19){
                Name.text = "Nama: Emelia Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 941";
                Exp.text = "BERLAKU SAMPAI: 02-03-2026";
                Color.text = "Biru";
            }else if(ID == 20){
                Name.text = "Nama: Gracie Evelyn";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 91462";
                Exp.text = "BERLAKU SAMPAI: 18-04-2026";
                Color.text = "Merah";
            }else if(ID == 21){
                Name.text = "Nama: Samual Ryan";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 6023";
                Exp.text = "BERLAKU SAMPAI: 11-07-2028";
                Color.text = "Biru";
            }else if(ID == 22){
                Name.text = "Nama: Vanessa Violet";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 826";
                Exp.text = "BERLAKU SAMPAI: 04-11-2024";
                Color.text = "Merah";
            }else if(ID == 23){
                Name.text = "Nama: Kaleb Thomas";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 5268";
                Exp.text = "BERLAKU SAMPAI: 21-04-2026";
                Color.text = "Putih";
            }else if(ID == 24){
                Name.text = "Nama: Stella Clairey";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 4159";
                Exp.text = "BERLAKU SAMPAI: 16-08-2027";
                Color.text = "Biru";
            }else if(ID == 25){
                Name.text = "Nama: Elyjah Charles";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 63924";
                Exp.text = "BERLAKU SAMPAI: 08-01-2025";
                Color.text = "Putih";
            }else if(ID == 26){
                Name.text = "Nama: Janis Jane";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 4391";
                Exp.text = "BERLAKU SAMPAI: 30-06-2026";
                Color.text = "Merah";
            }else if(ID == 27){
                Name.text = "Nama: Nathen Alexander";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 395";
                Exp.text = "BERLAKU SAMPAI: 06-05-2025";
                Color.text = "Abu-abu";
            }else if(ID == 28){
                Name.text = "Nama: Zoey Isabelle";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 37189";
                Exp.text = "BERLAKU SAMPAI: 23-08-2024";
                Color.text = "Putih";
            }else if(ID == 29){
                Name.text = "Nama: Gabrielle Cole";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 2875";
                Exp.text = "BERLAKU SAMPAI: 15-01-2027";
                Color.text = "Merah";
            }else if(ID == 30){
                Name.text = "Nama: Abigale Roselyn";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 1873";
                Exp.text = "BERLAKU SAMPAI: 30-10-2023";
                Color.text = "Merah";
            }else if(ID == 31){
                Name.text = "Nama: Willian Jasper";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 174";
                Exp.text = "BERLAKU SAMPAI: 09-10-2026";
                Color.text = "Putih";
            }else if(ID == 32){
                Name.text = "Nama: Aria Juliette";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 50472";
                Exp.text = "BERLAKU SAMPAI: 01-02-2025";
                Color.text = "Merah";
            }else if(ID == 33){
                Name.text = "Nama: Danyel Bryce";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 6912";
                Exp.text = "BERLAKU SAMPAI: 20-07-2028";
                Color.text = "Abu-abu";
            }else if(ID == 34){
                Name.text = "Nama: Ella Camila";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 9537";
                Exp.text = "BERLAKU SAMPAI: 11-11-2023";
                Color.text = "Merah";
            }else if(ID == 35){
                Name.text = "Nama: Jake Oliver";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 269";
                Exp.text = "BERLAKU SAMPAI: 03-10-2025";
                Color.text = "Abu-abu";
            }else if(ID == 36){
                Name.text = "Nama: Ava Charlize";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 23857";
                Exp.text = "BERLAKU SAMPAI: 18-03-2028";
                Color.text = "Putih";
            }else if(ID == 37){
                Name.text = "Nama: Izak Nathanael";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 6142";
                Exp.text = "BERLAKU SAMPAI: 29-10-2024";
                Color.text = "Merah";
            }else if(ID == 38){
                Name.text = "Nama: Lily Annabelle";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 8341";
                Exp.text = "BERLAKU SAMPAI: 14-07-2027";
                Color.text = "Abu-abu";
            }else if(ID == 39){
                Name.text = "Nama: Owen Michaelson";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 548";
                Exp.text = "BERLAKU SAMPAI: 07-03-2026";
                Color.text = "Merah";
            }
            }else if(ErrType == 4){
            if(ID == 0){
                Name.text = "Nama: Lily Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 579";
                Exp.text = "BERLAKU SAMPAI: 01-03-2026";
                Color.text = "Merah";
            }else if(ID == 1){
                Name.text = "Nama: Oliver Scott";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 0185";
                Exp.text = "BERLAKU SAMPAI: 15-07-2025";
                Color.text = "Putih";
            }else if(ID == 2){
                Name.text = "Nama: Ruby Claire";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 9191";
                Exp.text = "BERLAKU SAMPAI: 10-10-2025";
                Color.text = "Abu-abu";
            }else if(ID == 3){
                Name.text = "Nama: Thomas Blaine";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 3439";
                Exp.text = "BERLAKU SAMPAI: 05-01-2024";
                Color.text = "Merah";
            }else if(ID == 4){
                Name.text = "Nama: Madison Blaine";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 819";
                Exp.text = "BERLAKU SAMPAI: 20-09-2026";
                Color.text = "Abu-abu";
            }else if(ID == 5){
                Name.text = "Nama: Scarlett Rose";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 5590";
                Exp.text = "BERLAKU SAMPAI: 25-05-2026";
                Color.text = "Putih";
            }else if(ID == 6){
                Name.text = "Nama: Henry Blake";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 69891";
                Exp.text = "BERLAKU SAMPAI: 30-08-2024";
                Color.text = "Merah";
            }else if(ID == 7){
                Name.text = "Nama: Sophia Mae";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 4384";
                Exp.text = "BERLAKU SAMPAI: 09-03-2025";
                Color.text = "Biru";
            }else if(ID == 8){
                Name.text = "Nama: Ethan James";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 5592";
                Exp.text = "BERLAKU SAMPAI: 17-07-2024";
                Color.text = "Merah";
            }else if(ID == 9){
                Name.text = "Nama: Ava Marie";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 296";
                Exp.text = "BERLAKU SAMPAI: 05-11-2023";
                Color.text = "Merah";
            }else if(ID == 10){
                Name.text = "Nama: Lucas Alexander";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 37295";
                Exp.text = "BERLAKU SAMPAI: 22-01-2026";
                Color.text = "Putih";
            }else if(ID == 11){
                Name.text = "Nama: Harper Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 5721";
                Exp.text = "BERLAKU SAMPAI: 14-09-2027";
                Color.text = "Merah";
            }else if(ID == 12){
                Name.text = "Nama: Benjamin Cole";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 12481";
                Exp.text = "BERLAKU SAMPAI: 03-04-2024";
                Color.text = "Putih";
            }else if(ID == 13){
                Name.text = "Nama: Emma Jade";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 7541";
                Exp.text = "BERLAKU SAMPAI: 19-06-2028";
                Color.text = "Biru";
            }else if(ID == 14){
                Name.text = "Nama: Liam Patrick";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 685";
                Exp.text = "BERLAKU SAMPAI: 28-12-2023";
                Color.text = "Putih";
            }else if(ID == 15){
                Name.text = "Nama: Isabella Faith";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 681";
                Exp.text = "BERLAKU SAMPAI: 07-08-2025";
                Color.text = "Merah";
            }else if(ID == 16){
                Name.text = "Nama: Noah Harrison";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 2857";
                Exp.text = "BERLAKU SAMPAI: 12-02-2028";
                Color.text = "Abu-abu";
            }else if(ID == 17){
                Name.text = "Nama: Chloe Elizabeth";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 935";
                Exp.text = "BERLAKU SAMPAI: 25-10-2024";
                Color.text = "Merah";
            }else if(ID == 18){
                Name.text = "Nama: Jackson Miles";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 91438";
                Exp.text = "BERLAKU SAMPAI: 10-05-2027";
                Color.text = "Putih";
            }else if(ID == 19){
                Name.text = "Nama: Amelia Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 940";
                Exp.text = "BERLAKU SAMPAI: 02-03-2026";
                Color.text = "Biru";
            }else if(ID == 20){
                Name.text = "Nama: Grace Evelyn";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 9462";
                Exp.text = "BERLAKU SAMPAI: 18-04-2026";
                Color.text = "Merah";
            }else if(ID == 21){
                Name.text = "Nama: Samuel Ryan";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 6022";
                Exp.text = "BERLAKU SAMPAI: 11-07-2028";
                Color.text = "Biru";
            }else if(ID == 22){
                Name.text = "Nama: Vania Violeta";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 92645";
                Exp.text = "BERLAKU SAMPAI: 04-11-2024";
                Color.text = "Merah";
            }else if(ID == 23){
                Name.text = "Nama: Caleb Thomas";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 5298";
                Exp.text = "BERLAKU SAMPAI: 21-04-2026";
                Color.text = "Putih";
            }else if(ID == 24){
                Name.text = "Nama: Stella Claire";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 4119";
                Exp.text = "BERLAKU SAMPAI: 16-08-2027";
                Color.text = "Biru";
            }else if(ID == 25){
                Name.text = "Nama: Elijah Charles";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 6324";
                Exp.text = "BERLAKU SAMPAI: 08-01-2025";
                Color.text = "Putih";
            }else if(ID == 26){
                Name.text = "Nama: Janice Jane";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 4301";
                Exp.text = "BERLAKU SAMPAI: 30-06-2026";
                Color.text = "Merah";
            }else if(ID == 27){
                Name.text = "Nama: Nathan Alexander";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 385";
                Exp.text = "BERLAKU SAMPAI: 06-05-2025";
                Color.text = "Abu-abu";
            }else if(ID == 28){
                Name.text = "Nama: Zoe Isabelle";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 379";
                Exp.text = "BERLAKU SAMPAI: 23-08-2024";
                Color.text = "Putih";
            }else if(ID == 29){
                Name.text = "Nama: Gabriel Cole";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 275";
                Exp.text = "BERLAKU SAMPAI: 15-01-2027";
                Color.text = "Merah";
            }else if(ID == 30){
                Name.text = "Nama: Abigail Rose";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 1783";
                Exp.text = "BERLAKU SAMPAI: 30-10-2023";
                Color.text = "Merah";
            }else if(ID == 31){
                Name.text = "Nama: William Jasper";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 1740";
                Exp.text = "BERLAKU SAMPAI: 09-10-2026";
                Color.text = "Putih";
            }else if(ID == 32){
                Name.text = "Nama: Aria Juliet";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 4472";
                Exp.text = "BERLAKU SAMPAI: 01-02-2025";
                Color.text = "Merah";
            }else if(ID == 33){
                Name.text = "Nama: Daniel Bryce";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 65912";
                Exp.text = "BERLAKU SAMPAI: 20-07-2028";
                Color.text = "Abu-abu";
            }else if(ID == 34){
                Name.text = "Nama: Ella Camilla";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 9637";
                Exp.text = "BERLAKU SAMPAI: 11-11-2023";
                Color.text = "Merah";
            }else if(ID == 35){
                Name.text = "Nama: Jack Oliver";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 2069";
                Exp.text = "BERLAKU SAMPAI: 03-10-2025";
                Color.text = "Abu-abu";
            }else if(ID == 36){
                Name.text = "Nama: Ava Charlotte";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 82514";
                Exp.text = "BERLAKU SAMPAI: 18-03-2028";
                Color.text = "Putih";
            }else if(ID == 37){
                Name.text = "Nama: Isaac Nathaniel";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 642";
                Exp.text = "BERLAKU SAMPAI: 29-10-2024";
                Color.text = "Merah";
            }else if(ID == 38){
                Name.text = "Nama: Lily Anne";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 83941";
                Exp.text = "BERLAKU SAMPAI: 14-07-2027";
                Color.text = "Abu-abu";
            }else if(ID == 39){
                Name.text = "Nama: Owen Michael";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 5488";
                Exp.text = "BERLAKU SAMPAI: 07-03-2026";
                Color.text = "Merah";
            }    
            }else if(ErrType == 5){
            if(ID == 0){
                Name.text = "Nama: Lily Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 579";
                Exp.text = "BERLAKU SAMPAI: 01-03-2023";
                Color.text = "Merah";
            }else if(ID == 1){
                Name.text = "Nama: Oliver Scott";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 1185";
                Exp.text = "BERLAKU SAMPAI: 15-07-2022";
                Color.text = "Putih";
            }else if(ID == 2){
                Name.text = "Nama: Ruby Claire";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 9141";
                Exp.text = "BERLAKU SAMPAI: 10-10-2023";
                Color.text = "Abu-abu";
            }else if(ID == 3){
                Name.text = "Nama: Thomas Blaine";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 36439";
                Exp.text = "BERLAKU SAMPAI: 05-01-2021";
                Color.text = "Merah";
            }else if(ID == 4){
                Name.text = "Nama: Madison Blaine";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 87819";
                Exp.text = "BERLAKU SAMPAI: 20-09-2022";
                Color.text = "Abu-abu";
            }else if(ID == 5){
                Name.text = "Nama: Scarlett Rose";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 5591";
                Exp.text = "BERLAKU SAMPAI: 25-05-2023";
                Color.text = "Putih";
            }else if(ID == 6){
                Name.text = "Nama: Henry Blake";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 67891";
                Exp.text = "BERLAKU SAMPAI: 30-08-2022";
                Color.text = "Merah";
            }else if(ID == 7){
                Name.text = "Nama: Sophia Mae";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 7384";
                Exp.text = "BERLAKU SAMPAI: 09-03-2023";
                Color.text = "Biru";
            }else if(ID == 8){
                Name.text = "Nama: Ethan James";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 5692";
                Exp.text = "BERLAKU SAMPAI: 17-07-2021";
                Color.text = "Merah";
            }else if(ID == 9){
                Name.text = "Nama: Ava Marie";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 48296";
                Exp.text = "BERLAKU SAMPAI: 05-11-2020";
                Color.text = "Merah";
            }else if(ID == 10){
                Name.text = "Nama: Lucas Alexander";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 3729";
                Exp.text = "BERLAKU SAMPAI: 22-01-2022";
                Color.text = "Putih";
            }else if(ID == 11){
                Name.text = "Nama: Harper Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 572";
                Exp.text = "BERLAKU SAMPAI: 14-09-2019";
                Color.text = "Merah";
            }else if(ID == 12){
                Name.text = "Nama: Benjamin Cole";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 1248";
                Exp.text = "BERLAKU SAMPAI: 03-04-2022";
                Color.text = "Putih";
            }else if(ID == 13){
                Name.text = "Nama: Emma Jade";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 76541";
                Exp.text = "BERLAKU SAMPAI: 19-06-2022";
                Color.text = "Biru";
            }else if(ID == 14){
                Name.text = "Nama: Liam Patrick";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 683";
                Exp.text = "BERLAKU SAMPAI: 28-12-2022";
                Color.text = "Putih";
            }else if(ID == 15){
                Name.text = "Nama: Isabella Faith";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 6851";
                Exp.text = "BERLAKU SAMPAI: 07-08-2021";
                Color.text = "Merah";
            }else if(ID == 16){
                Name.text = "Nama: Noah Harrison";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 23857";
                Exp.text = "BERLAKU SAMPAI: 12-02-2020";
                Color.text = "Abu-abu";
            }else if(ID == 17){
                Name.text = "Nama: Chloe Elizabeth";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 8935";
                Exp.text = "BERLAKU SAMPAI: 25-10-2021";
                Color.text = "Merah";
            }else if(ID == 18){
                Name.text = "Nama: Jackson Miles";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 9143";
                Exp.text = "BERLAKU SAMPAI: 10-05-2021";
                Color.text = "Putih";
            }else if(ID == 19){
                Name.text = "Nama: Amelia Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 941";
                Exp.text = "BERLAKU SAMPAI: 02-03-2022";
                Color.text = "Biru";
            }else if(ID == 20){
                Name.text = "Nama: Grace Evelyn";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 91462";
                Exp.text = "BERLAKU SAMPAI: 18-04-2020";
                Color.text = "Merah";
            }else if(ID == 21){
                Name.text = "Nama: Samuel Ryan";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 6023";
                Exp.text = "BERLAKU SAMPAI: 11-07-2020";
                Color.text = "Biru";
            }else if(ID == 22){
                Name.text = "Nama: Vania Violeta";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 826";
                Exp.text = "BERLAKU SAMPAI: 04-11-2019";
                Color.text = "Merah";
            }else if(ID == 23){
                Name.text = "Nama: Caleb Thomas";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 5268";
                Exp.text = "BERLAKU SAMPAI: 21-04-2018";
                Color.text = "Putih";
            }else if(ID == 24){
                Name.text = "Nama: Stella Claire";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 4159";
                Exp.text = "BERLAKU SAMPAI: 16-08-2022";
                Color.text = "Biru";
            }else if(ID == 25){
                Name.text = "Nama: Elijah Charles";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 63924";
                Exp.text = "BERLAKU SAMPAI: 08-01-2020";
                Color.text = "Putih";
            }else if(ID == 26){
                Name.text = "Nama: Janice Jane";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 4391";
                Exp.text = "BERLAKU SAMPAI: 30-06-2022";
                Color.text = "Merah";
            }else if(ID == 27){
                Name.text = "Nama: Nathan Alexander";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 395";
                Exp.text = "BERLAKU SAMPAI: 06-05-2021";
                Color.text = "Abu-abu";
            }else if(ID == 28){
                Name.text = "Nama: Zoe Isabelle";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 37189";
                Exp.text = "BERLAKU SAMPAI: 23-08-2023";
                Color.text = "Putih";
            }else if(ID == 29){
                Name.text = "Nama: Gabriel Cole";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 2875";
                Exp.text = "BERLAKU SAMPAI: 15-01-2023";
                Color.text = "Merah";
            }else if(ID == 30){
                Name.text = "Nama: Abigail Rose";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 1873";
                Exp.text = "BERLAKU SAMPAI: 30-10-2020";
                Color.text = "Merah";
            }else if(ID == 31){
                Name.text = "Nama: William Jasper";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 174";
                Exp.text = "BERLAKU SAMPAI: 09-10-2023";
                Color.text = "Putih";
            }else if(ID == 32){
                Name.text = "Nama: Aria Juliet";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 50472";
                Exp.text = "BERLAKU SAMPAI: 01-02-2020";
                Color.text = "Merah";
            }else if(ID == 33){
                Name.text = "Nama: Daniel Bryce";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 6912";
                Exp.text = "BERLAKU SAMPAI: 20-07-2022";
                Color.text = "Abu-abu";
            }else if(ID == 34){
                Name.text = "Nama: Ella Camilla";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 9537";
                Exp.text = "BERLAKU SAMPAI: 11-11-2022";
                Color.text = "Merah";
            }else if(ID == 35){
                Name.text = "Nama: Jack Oliver";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 269";
                Exp.text = "BERLAKU SAMPAI: 03-10-2021";
                Color.text = "Abu-abu";
            }else if(ID == 36){
                Name.text = "Nama: Ava Charlotte";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 23857";
                Exp.text = "BERLAKU SAMPAI: 18-03-2020";
                Color.text = "Putih";
            }else if(ID == 37){
                Name.text = "Nama: Isaac Nathaniel";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 6142";
                Exp.text = "BERLAKU SAMPAI: 29-10-2022";
                Color.text = "Merah";
            }else if(ID == 38){
                Name.text = "Nama: Lily Anne";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 8341";
                Exp.text = "BERLAKU SAMPAI: 14-07-2019";
                Color.text = "Abu-abu";
            }else if(ID == 39){
                Name.text = "Nama: Owen Michael";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 548";
                Exp.text = "BERLAKU SAMPAI: 07-03-2018";
                Color.text = "Merah";
            }    
            }else if(ErrType == 6){
            if(ID == 0){
                Name.text = "Nama: Lily Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 579";
                Exp.text = "BERLAKU SAMPAI: 01-03-2026";
                Color.text = "Abu-Abu";
            }else if(ID == 1){
                Name.text = "Nama: Oliver Scott";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 1185";
                Exp.text = "BERLAKU SAMPAI: 15-07-2025";
                Color.text = "Biru";
            }else if(ID == 2){
                Name.text = "Nama: Ruby Claire";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 9141";
                Exp.text = "BERLAKU SAMPAI: 10-10-2025";
                Color.text = "Merah";
            }else if(ID == 3){
                Name.text = "Nama: Thomas Blaine";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 36439";
                Exp.text = "BERLAKU SAMPAI: 05-01-2024";
                Color.text = "Biru";
            }else if(ID == 4){
                Name.text = "Nama: Madison Blaine";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 87819";
                Exp.text = "BERLAKU SAMPAI: 20-09-2026";
                Color.text = "Merah";
            }else if(ID == 5){
                Name.text = "Nama: Scarlett Rose";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 5591";
                Exp.text = "BERLAKU SAMPAI: 25-05-2026";
                Color.text = "Abu-abu";
            }else if(ID == 6){
                Name.text = "Nama: Henry Blake";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 67891";
                Exp.text = "BERLAKU SAMPAI: 30-08-2024";
                Color.text = "Biru";
            }else if(ID == 7){
                Name.text = "Nama: Sophia Mae";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 7384";
                Exp.text = "BERLAKU SAMPAI: 09-03-2025";
                Color.text = "Abu-abu";
            }else if(ID == 8){
                Name.text = "Nama: Ethan James";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 5692";
                Exp.text = "BERLAKU SAMPAI: 17-07-2024";
                Color.text = "Putih";
            }else if(ID == 9){
                Name.text = "Nama: Ava Marie";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 48296";
                Exp.text = "BERLAKU SAMPAI: 05-11-2023";
                Color.text = "Biru";
            }else if(ID == 10){
                Name.text = "Nama: Lucas Alexander";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 3729";
                Exp.text = "BERLAKU SAMPAI: 22-01-2026";
                Color.text = "Merah";
            }else if(ID == 11){
                Name.text = "Nama: Harper Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 572";
                Exp.text = "BERLAKU SAMPAI: 14-09-2027";
                Color.text = "Biru";
            }else if(ID == 12){
                Name.text = "Nama: Benjamin Cole";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 1248";
                Exp.text = "BERLAKU SAMPAI: 03-04-2024";
                Color.text = "Merah";
            }else if(ID == 13){
                Name.text = "Nama: Emma Jade";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 76541";
                Exp.text = "BERLAKU SAMPAI: 19-06-2028";
                Color.text = "Merah";
            }else if(ID == 14){
                Name.text = "Nama: Liam Patrick";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 683";
                Exp.text = "BERLAKU SAMPAI: 28-12-2023";
                Color.text = "Abu-abu";
            }else if(ID == 15){
                Name.text = "Nama: Isabella Faith";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 6851";
                Exp.text = "BERLAKU SAMPAI: 07-08-2025";
                Color.text = "Biru";
            }else if(ID == 16){
                Name.text = "Nama: Noah Harrison";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 23857";
                Exp.text = "BERLAKU SAMPAI: 12-02-2028";
                Color.text = "Putih";
            }else if(ID == 17){
                Name.text = "Nama: Chloe Elizabeth";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 8935";
                Exp.text = "BERLAKU SAMPAI: 25-10-2024";
                Color.text = "Biru";
            }else if(ID == 18){
                Name.text = "Nama: Jackson Miles";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 9143";
                Exp.text = "BERLAKU SAMPAI: 10-05-2027";
                Color.text = "Abu-abu";
            }else if(ID == 19){
                Name.text = "Nama: Amelia Grace";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 941";
                Exp.text = "BERLAKU SAMPAI: 02-03-2026";
                Color.text = "Merah";
            }else if(ID == 20){
                Name.text = "Nama: Grace Evelyn";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 91462";
                Exp.text = "BERLAKU SAMPAI: 18-04-2026";
                Color.text = "Abu-abu";
            }else if(ID == 21){
                Name.text = "Nama: Samuel Ryan";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 6023";
                Exp.text = "BERLAKU SAMPAI: 11-07-2028";
                Color.text = "Putih";
            }else if(ID == 22){
                Name.text = "Nama: Vania Violeta";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 826";
                Exp.text = "BERLAKU SAMPAI: 04-11-2024";
                Color.text = "Biru";
            }else if(ID == 23){
                Name.text = "Nama: Caleb Thomas";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 5268";
                Exp.text = "BERLAKU SAMPAI: 21-04-2026";
                Color.text = "Merah";
            }else if(ID == 24){
                Name.text = "Nama: Stella Claire";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 4159";
                Exp.text = "BERLAKU SAMPAI: 16-08-2027";
                Color.text = "Putih";
            }else if(ID == 25){
                Name.text = "Nama: Elijah Charles";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 63924";
                Exp.text = "BERLAKU SAMPAI: 08-01-2025";
                Color.text = "Merah";
            }else if(ID == 26){
                Name.text = "Nama: Janice Jane";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 4391";
                Exp.text = "BERLAKU SAMPAI: 30-06-2026";
                Color.text = "Biru";
            }else if(ID == 27){
                Name.text = "Nama: Nathan Alexander";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 395";
                Exp.text = "BERLAKU SAMPAI: 06-05-2025";
                Color.text = "Merah";
            }else if(ID == 28){
                Name.text = "Nama: Zoe Isabelle";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 37189";
                Exp.text = "BERLAKU SAMPAI: 23-08-2024";
                Color.text = "Abu-abu";
            }else if(ID == 29){
                Name.text = "Nama: Gabriel Cole";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 2875";
                Exp.text = "BERLAKU SAMPAI: 15-01-2027";
                Color.text = "Putih";
            }else if(ID == 30){
                Name.text = "Nama: Abigail Rose";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 1873";
                Exp.text = "BERLAKU SAMPAI: 30-10-2023";
                Color.text = "Biru";
            }else if(ID == 31){
                Name.text = "Nama: William Jasper";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 174";
                Exp.text = "BERLAKU SAMPAI: 09-10-2026";
                Color.text = "Abu-abu";
            }else if(ID == 32){
                Name.text = "Nama: Aria Juliet";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 50472";
                Exp.text = "BERLAKU SAMPAI: 01-02-2025";
                Color.text = "Abu-abu";
            }else if(ID == 33){
                Name.text = "Nama: Daniel Bryce";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 6912";
                Exp.text = "BERLAKU SAMPAI: 20-07-2028";
                Color.text = "Biru";
            }else if(ID == 34){
                Name.text = "Nama: Ella Camilla";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 9537";
                Exp.text = "BERLAKU SAMPAI: 11-11-2023";
                Color.text = "Putih";
            }else if(ID == 35){
                Name.text = "Nama: Jack Oliver";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 269";
                Exp.text = "BERLAKU SAMPAI: 03-10-2025";
                Color.text = "Merah";
            }else if(ID == 36){
                Name.text = "Nama: Ava Charlotte";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: A 23857";
                Exp.text = "BERLAKU SAMPAI: 18-03-2028";
                Color.text = "Biru";
            }else if(ID == 37){
                Name.text = "Nama: Isaac Nathaniel";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: S 6142";
                Exp.text = "BERLAKU SAMPAI: 29-10-2024";
                Color.text = "Putih";
            }else if(ID == 38){
                Name.text = "Nama: Lily Anne";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: Z 8341";
                Exp.text = "BERLAKU SAMPAI: 14-07-2027";
                Color.text = "Merah";
            }else if(ID == 39){
                Name.text = "Nama: Owen Michael";
                Tipe.text = "Jenis: Mobil";
                Plat.text = "Nomor Kendaraan: V 548";
                Exp.text = "BERLAKU SAMPAI: 07-03-2026";
                Color.text = "Putih";
            }
            }
        }
    }
}
