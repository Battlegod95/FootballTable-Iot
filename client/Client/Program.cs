using System;
using System.Collections.Generic;
using Client.Sensors;
using System.Net;
using System.IO;
using System.Collections;
using System.Threading;

namespace Client
{
    class Program
    {
         public static VirtualGoalSensor VirtualGoal = new VirtualGoalSensor();
         public static VirtualPlayersSensor VirtualPlayer = new VirtualPlayersSensor();
        public static int totGoalSX = 0;
        public static int totGoalDX = 0;
        public static int totGoalMancati = 0;
        static void Main(string[] args)
        {
            var program = new Program();

            // init sensors
            List<PlayersSensorInterface> Playersensors = new List<PlayersSensorInterface>();
            List<GoalSensorInterface> Goalsensors = new List<GoalSensorInterface>();

            Playersensors.Add(new VirtualPlayersSensor());
            Goalsensors.Add(new VirtualGoalSensor());

            program.InvioDati(VirtualPlayer.toJson());
            
            Console.Out.WriteLine("PARTITA INIZIATA"); 

            while ((totGoalSX<10) && (totGoalDX<10)){

                foreach (GoalSensorInterface sensor in Goalsensors)
                {
                    string val = VirtualGoal.toJson();
                    if(val.Contains("Sinistra"))
                    {
                        if (val.Contains("True"))
                        {
                            totGoalSX++;
                        }
                    }

                    if (val.Contains("Destra"))
                    {
                        if (val.Contains("True"))
                        {
                            totGoalDX++;
                        }
                    }

                    if (val.Contains("False"))
                    {
                        totGoalMancati++;
                    }
                    Console.Out.WriteLine("Goal Squadra Sinistra: " + totGoalSX);
                    Console.Out.WriteLine("Goal Squadra Destra: " + totGoalDX);
                    Console.Out.WriteLine("Goal Mancati: " + totGoalMancati);

                    program.InvioDati(val);
                }

            }
            Console.Out.WriteLine("PARTITA FINITA");
            Thread.Sleep(5000);
        }

        public void InvioDati(string StringaJSON)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8011/tables/AB123");
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(StringaJSON);

            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            //Console.Out.WriteLine(httpResponse.StatusCode);
            Console.Out.WriteLine("_____");

            httpResponse.Close();

            System.Threading.Thread.Sleep(5000);
        }

    }

}


