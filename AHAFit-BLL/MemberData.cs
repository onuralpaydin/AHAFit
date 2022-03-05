using AHAFit_Data;
using AHAFit_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_BLL
{
    public class MemberData
    {
        Context db = new Context();
        public bool MemberLoginControl(string email, string password)
        {
            if (!db.Members.Any(x => x.Email == email))
            {
                return false;

            }
            else if (db.Members.FirstOrDefault(x => x.Email == email).Password != password)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int MemberIdFounder(string email)
        {
            return db.Members.FirstOrDefault(x => x.Email == email).MemberId;
        }
        public string GetMemberName(int memberId)
        {
            return db.Members.FirstOrDefault(x => x.MemberId == memberId).Name;
        }
        public void ChangeMembersGoal(int memberId, string newGoal)
        {
            int newGoalId = db.Goals.FirstOrDefault(x => x.Name == newGoal).GoalId;

            db.Members.FirstOrDefault(x => x.MemberId == memberId).GoalId = newGoalId;

            db.SaveChanges();
        }
        public Member getMemberInformations(int memberId)
        {
            return db.Members.FirstOrDefault(x => x.MemberId == memberId);
        }
        public void ChangeMemberInformation(int memberId, string email, string name, string surname, string password, double weight, string gender, int height, DateTime birthDate, string activityLevel)
        {
            var member = db.Members.FirstOrDefault(x => x.MemberId == memberId);

            member.Email = email;
            member.Name = name;
            member.Surname = surname;
            member.Password = password;
            member.Weight = weight;
            member.Gender = gender;
            member.Height = height;
            member.BirthDate = birthDate;
            member.ActivityLevel = activityLevel;

            db.SaveChanges();
        }
        public string GetMemberGoal(int memberId)
        {
            return db.Goals.FirstOrDefault(x => x.GoalId == db.Members.FirstOrDefault(y => y.MemberId == memberId).GoalId).Name;
        }
        public ActivityLevel GetMemberActivityLevel(int memberId)
        {
            return (ActivityLevel)Enum.Parse(typeof(ActivityLevel), (db.Members.FirstOrDefault(x => x.MemberId == memberId).ActivityLevel));
        }
        public bool IsEmailAddressExist(string email, int memberId)
        {
            return (db.Members.Any(x => x.Email == email) && db.Members.FirstOrDefault(x => x.Email == email).MemberId != memberId);
        }
        public string GetMemberPassword(int memberId)
        {
            return db.Members.FirstOrDefault(x => x.MemberId == memberId).Password;
        }
        public bool RecurringMailControl(string email)
        {
            return db.Members.Any(x => x.Email == email);
        }
        public void NewMember(string email, string name, string surname, string password, double weight, string gender, int height, DateTime birthDate, string activityLevel, int goalId)
        {
            Member newMember = new Member();
            newMember.Email = email;
            newMember.Name = name;
            newMember.Surname = surname;
            newMember.Password = password;
            newMember.Weight = weight;
            newMember.Gender = gender;
            newMember.Height = height;
            newMember.BirthDate = birthDate;
            newMember.ActivityLevel = activityLevel;
            newMember.GoalId = goalId;

            db.Members.Add(newMember);
            db.SaveChanges();
        }
        public Dictionary<string, double> CalorieChampUserFinder(int daysBack)
        {
            Dictionary<int, double> memberAndCalories = memberAndCalorieListBuilder(daysBack);

            var memberId = memberAndCalories.FirstOrDefault(y => y.Value == memberAndCalories.Values.Max()).Key;

            var selectedMember = db.Members.FirstOrDefault(x => x.MemberId == memberId);

            var userName = selectedMember.Name;
            var userSurname = selectedMember.Surname;

            Dictionary<string, double> caloriChampUser = new Dictionary<string, double>();
            caloriChampUser.Add($"{userName} {userSurname}", memberAndCalories.Values.Max());
            return caloriChampUser;
        }
        public List<MembersInComparision> MemberCompare(int daysBack)
        {
            Dictionary<int, double> memberAndCalories = memberAndCalorieListBuilder(daysBack);

            List<MembersInComparision> lastMemberList = new List<MembersInComparision>();

            foreach (var memberAndCalorie in memberAndCalories)
            {
                MembersInComparision newMember = new MembersInComparision();
                var member = db.Members.FirstOrDefault(x => x.MemberId == memberAndCalorie.Key);
                newMember.Name = member.Name;
                newMember.Surname = member.Surname;
                newMember.TotalCalorie = String.Format("{0:n}", memberAndCalorie.Value);
                newMember.Age = DateTime.Now.Year - member.BirthDate.Year;
                newMember.Gender = member.Gender;
                lastMemberList.Add(newMember);
            }
            return lastMemberList;
        }
        public Dictionary<int, double> memberAndCalorieListBuilder(int daysBack)
        {
            Dictionary<int, double> memberAndCalories = new Dictionary<int, double>();

            foreach (var member in db.Members.ToList())
            {
                var totalCal = 0.0;
                var memberAllFoods = new List<int>();
                if (daysBack == 0)
                {
                    memberAllFoods = db.MembersFoods.Where(x => x.MemberId == member.MemberId).Select(y => y.FoodId).ToList();
                }
                else
                {
                    memberAllFoods = db.MembersFoods.Where(x => x.MemberId == member.MemberId && x.CreateDateTime >= System.Data.Entity.DbFunctions.AddDays(DateTime.Now, -daysBack)).Select(y => y.FoodId).ToList();
                }

                foreach (var foodId in memberAllFoods)
                {
                    totalCal += db.Foods.FirstOrDefault(x => x.FoodId == foodId).Calorie;
                }

                memberAndCalories.Add(member.MemberId, totalCal);
            }

            return memberAndCalories;
        }

        //BAKILACAK
        public List<string> BMIUser(int memberId)
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
        public bool BMIEntryCheck(string weightInput, string heightInput)
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
        public double BMIValue(double weight, double height)
        {
            double bmi = Math.Round((weight / Math.Pow(height, 2) * 10000), 2);

            return bmi;
        }
    }
}

public class MembersInComparision
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string TotalCalorie { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
}
