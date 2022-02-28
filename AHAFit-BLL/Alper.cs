using System;
using AHAFit_Model;
using System.Collections.Generic;
using System.Linq;

namespace AHAFit_BLL
{
    public class Alper
    {
        private readonly int memberId;
        Context db = new Context();
        public Alper(int memberId)
        {
            this.memberId = memberId;

        }
        public List<string> BMIUser()
        {

            var user = db.Members.Where(u => u.MemberId == memberId).ToList();
            List<string> result = new List<string>();
            string userName = "", height = "", weight = "";

            foreach (var prop in user)
            {
                userName = $"{prop.Name}  {prop.Surname}";
                height = prop.Height.ToString();
                weight = prop.Weight.ToString();
            }
            result.Add(userName);
            result.Add(height);
            result.Add(weight);

            return result;
        }
        public bool BMIEntryCheck(string weightInput,string heightInput)
        {
            double weight, height;
            bool isWeight = double.TryParse(weightInput, out weight);
            bool isHeight = double.TryParse(heightInput, out height);
            if (isHeight && isWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double BMIValue(double weight,double height)
        {
            double bmi = Math.Round((weight / Math.Pow(height, 2) * 10000), 2);
            return bmi;
        }
    }
    
}
