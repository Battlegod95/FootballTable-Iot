using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Sensors
{
    interface GoalSensorInterface
    {
        void SetGoalDone(bool goalDone);
        bool GetGoalDone();
        string RandomTeamGoal();
        string GetDateTime();
        //int GoalDX();
        //int GoalSX();
       
    }
}
