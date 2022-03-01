using System;
using AHAFit_Data;
using AHAFit_Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_BLL
{
    public class Onur
    {

        Context db = new Context();
        public Onur()
        {

        }
        public bool SignUpDataControl(string password, string email)
        {
            string specialCharacters = "";
            string numericCharacters = "";
            string UpperCharacters = "";
            string LowerCharacters = "";
            string emailCharacter = "";
            




            try
            {
                if (password.Length >= 8 && password.Length <= 16)
                {
                    for (int i = 33; i < 48; i++)
                    {
                        specialCharacters += Convert.ToChar(i);
                    }
                    for (int i = 58; i < 65; i++)
                    {
                        specialCharacters += Convert.ToChar(i);
                    }
                    for (int i = 123; i < 127; i++)
                    {
                        specialCharacters += Convert.ToChar(i);
                    }
                    for (int i = 48; i < 58; i++)
                    {
                        numericCharacters += Convert.ToChar(i);
                    }
                    for (int i = 65; i < 91; i++)
                    {
                        UpperCharacters += Convert.ToChar(i);
                    }
                    for (int i = 97; i < 123; i++)
                    {
                        LowerCharacters += Convert.ToChar(i);
                    }
                    for (int i = 40; i < 41; i++)
                    {
                        emailCharacter += Convert.ToChar(i);
                    }
                    foreach (var item in specialCharacters)
                    {

                        if (!password.Contains(item))
                        {
                            return false;
                        }
                      
                    }
                    foreach (var item in numericCharacters)
                    {
                        if (!password.Contains(item))
                        {
                            return false;
                        }
                    }
                    foreach (var item in UpperCharacters)
                    {
                        if (!password.Contains(item))
                        {
                            return false;
                        }
                    }
                    foreach (var item in LowerCharacters )
                    {
                        if (!password.Contains(item))
                        {
                            return false;
                        }
                       
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public int GoalFinder(string goalName)
        {
            return db.Goals.FirstOrDefault(x => x.Name == goalName).GoalId;


        }


        public bool LoginControl(string email, string password)
        {


            if (db.Members.Any(x => x.Email == email))
            {
                if (db.Members.FirstOrDefault(x => x.Email == email).Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
                return false;
        }


        public void CreateNewMember(string email, string password, string name, string surname, double weight, int height, string gender, DateTime birthdate, int goalID, string activityLevel)
        {
            Member newMember = new Member();
            newMember.Email = email;
            newMember.Password = password;
            newMember.Name = name;
            newMember.Surname = surname;
            newMember.Weight = weight;
            newMember.Gender = gender;
            newMember.Height = height;
            newMember.BirthDate = birthdate;
            newMember.GoalId = goalID;
            newMember.ActivityLevel = activityLevel;

            if (!db.Members.Any(x => x.Email == newMember.Email))
            {
                db.Members.Add(newMember);
                db.SaveChanges();
            }
            else
            {

            }


        }
        public bool MemberControl(string email)
        {

            if (db.Members.Any(x => x.Email == email))
            {
                return false;
            }
            else
                return true;

        }

    }
}
