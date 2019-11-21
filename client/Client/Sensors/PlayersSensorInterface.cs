using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Sensors
{
    interface PlayersSensorInterface: SensorInterface
    {
        string toJson();
        string GetRandomPlayer1();
        string GetRandomPlayer2();
        string GetRandomPlayer3();
        string GetRandomPlayer4();
        string GetRandomTavolo();
        string GetRandomPartita();
        string GetDateTime();
    }
}
