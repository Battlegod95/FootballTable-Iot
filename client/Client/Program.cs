using System;
using System.Collections.Generic;
using Client.Sensors;
using System.Net;
using System.IO;
using System.Collections;

namespace Client
{
    class Program
    {
         
        public static int totGoalSX = 0;
   
        static void Main(string[] args)
        {

            // init sensors
            List<SensorInterface> sensors = new List<SensorInterface>();
            
            sensors.Add(new VirtualPlayersSensor());
            
            VirtualGoalSensor goalS = new VirtualGoalSensor();
            int totGoalDX = 0;
            int totGoalSX  =  0;
            int goalMancati = 0;
            
            

              
            while((totGoalSX<10) && (totGoalDX<10)){

                
                  //while ((totGoalSX<10) && (totGoalDX<10))
                    //{ 
                    for (int i = 0; i < totGoalSX; i++)
			        {
                    sensors.Add(new VirtualGoalSensor());
                                      
                    }
                        if(!(goalS.sorte == true))
                        {
                        totGoalSX++;
                        }
			    //}
                /*
                if(totGoalSX<10)
                { sensors.Add(new VirtualGoalSensor());
                    if(goalS.sorte== true)
                    {
                        totGoalSX++;
                    }
                }

                if(totGoalDX<10)
                {
                    sensors.Add(new VirtualGoalSensor());
                    if(!goalS.sorte== true)
                    {
                        totGoalDX++;
                    }
                }*/
                    
                foreach (SensorInterface sensor in sensors)
                {
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8011/tables/AB123");
                    httpWebRequest.ContentType = "text/json";
                    httpWebRequest.Method = "POST";

                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        streamWriter.Write(sensor.toJson());
                    }

                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                    Console.Out.WriteLine(httpResponse.StatusCode);

                    
                    //Console.Out.WriteLine(goalS.sorte);
                    Console.Out.WriteLine(totGoalSX);

                    httpResponse.Close();

                    System.Threading.Thread.Sleep(5000);

                }
                
            }

            

        }

    }

}
