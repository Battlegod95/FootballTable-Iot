using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


namespace Client.Sensors
{
    
    public class VirtualGoalSensor : GoalSensorInterface
    {   
        public static bool goalDone;
        public static int totGoalDX = 0;
        public static int totGoalSX = 0;
        public string vincente;


        public string[] TeamArray = { VirtualPlayersSensor.Squadra1, VirtualPlayersSensor.Squadra2};
        public string toJson()
        {
            return "{\"idPartita\": AAA" + VirtualPlayersSensor.idPartita + ", \"goalDone\": " + "\"" + GetGoalDone() +  "\"" 
            + ", \"SegnatoDa\": "  + "\"" +  RandomTeamGoal() +  "\"" 
            //+ ", \"totGoalDX\": "  + "\"" +  GoalDX() + "\"" 
            //+ ", \"totGoalSX\": "  + "\"" + GoalSX()  + "\"" 
            +   ", \"Data\": "+ "\"" + GetDateTime()+ "\"" + "}";
        }

        public void SetGoalDone(bool goalDone)
        {
        }
        
        public bool GetGoalDone()
        {
            var random = new Random();
            int r = random.Next(2);
            if (r == 1)
                return true;
            else
                return false;
            
            
        }

        public string RandomTeamGoal()
        {
            var random = new Random();
            vincente = TeamArray[random.Next(TeamArray.Length)];
            //Console.Out.WriteLine(vincente);
            return vincente;
        }
        

        public string GetDateTime()
        {
            DateTime date = DateTime.Now;
            return date.ToString();
        }

        
    }
}
