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
    }
}
