using AHAFit_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_BLL
{
    public class GoalData
    {
        Context db = new Context();
        public int GoalIdFounder(string goal)
        {
            return db.Goals.FirstOrDefault(x => x.Name == goal).GoalId;
        }
        public List<string> GoalNamesToList()
        {
            List<string> goalList = new List<string>();
            foreach (var goal in db.Goals.ToList())
            {
                goalList.Add(goal.Name);
            }
            return goalList;
        }
    }
}
