using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Client.Sensors
{
    
    public class VirtualPlayersSensor: PlayersSensorInterface
    {   
        public static string idPlayer1;
        public static string idPlayer2;
        public static string idPlayer3;
        public static string idPlayer4;
        public static string Squadra1 = "Destra";
        public static string Squadra2 = "Sinistra";
        public static string idTavolo;
        public static string idPartita;
        
        public string toJson()
        {
            return "{\"players\": [{\"IdPlayer1\": " + "\""+ GetRandomPlayer1()+ "\""+ ", " +
                    "\"Squadra\": " +  "\""+ Squadra1 + "\""+  ", \"Ruolo\": \"Attaccante\"}, "+
                    "{\"IdPlayer2\": " + "\"" + GetRandomPlayer2()+ "\"" + "," +
                    "\"Squadra\": " + "\""+ Squadra1 + "\""+ ", \"Ruolo\": \"Difensore\"}, "+ 
                    "{\"IdPlayer3\": " + "\""+ GetRandomPlayer3()+ "\"" + "," +
                    "\"Squadra\": "+ "\""+ Squadra2 + "\""+  ", \"Ruolo\": \"Attaccante\"}, "+ 
                    "{\"IdPlayer4\": " +  "\""+ GetRandomPlayer4() + "\""+ "," +
                    "\"Squadra\": "+ "\""+ Squadra2 + "\""+ ", \"Ruolo\": \"Difensore\"}],"+ 
                "\"IdTavolo\": "+ "\""+"YYY"+ GetRandomTavolo() + "\""+ "," +
                "\"IdPartita\": " + "\""+"AAA" + GetRandomPartita() + "\"" + "," +
                "\"Data\": "+  "\""+ GetDateTime()+ "\"" + "}";
        }

        
        

        public string GetRandomPlayer1(){
         Guid uuid = Guid.NewGuid();
            idPlayer1 = uuid.ToString();
            return idPlayer1;
        }

        public string GetRandomPlayer2(){
         Guid uuid = Guid.NewGuid();
            idPlayer2 = uuid.ToString();
            return idPlayer2;
        }

        public string GetRandomPlayer3(){
         Guid uuid = Guid.NewGuid();
            idPlayer3 = uuid.ToString();
            return idPlayer3;
        }

        public string GetRandomPlayer4(){
         Guid uuid = Guid.NewGuid();
            idPlayer4 = uuid.ToString();
            return idPlayer4;
        }

        public string GetRandomTavolo(){
            var random1 = new Random().Next(100);
            idTavolo = random1.ToString();
            return idTavolo;
        }
        
        public string GetRandomPartita(){
            var random2 = new Random().Next(50);
            idPartita = random2.ToString();
            return idPartita;
        }

       
        public string GetDateTime()
        {
            DateTime date = DateTime.Now;
            return date.ToString();
        }

    }
}
