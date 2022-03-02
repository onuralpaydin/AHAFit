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
        public bool SignUpEmailCheck(string password)
        {
            string emailCharacter = "";
            for (int i = 40; i < 41; i++)
            {
                emailCharacter += Convert.ToChar(i);
            }
            if (password.Contains(emailCharacter))
                return true;

            else
                return false;
        }
        public bool SignUpDataControl(string password)
        {
            string specialCharacters = "";
            string numericCharacters = "";
            string UpperCharacters = "";
            string LowerCharacters = "";
          
            for (int i = 33; i <= 47; i++)
            {
                specialCharacters += Convert.ToChar(i);
            }
            for (int i = 58; i <= 64; i++)
            {
                specialCharacters += Convert.ToChar(i);
            }
            for (int i = 123; i <= 126; i++)
            {
                specialCharacters += Convert.ToChar(i);
            }
            for (int i = 48; i <= 57; i++)
            {
                numericCharacters += Convert.ToChar(i);
            }
            //for (int i = 65; i <= 90; i++)
            //{
            //    UpperCharacters += Convert.ToChar(i);
            //}
            for (int i = 97; i <= 122; i++)
            {
                LowerCharacters += Convert.ToChar(i);
                
            }

            UpperCharacters = LowerCharacters.ToUpper();

            //if (password.Length < 8 && password.Length > 16)
            //{
            //    return false;
            //}
            //else if (!password.Contains(UpperCharacters))
            //{
            //    if (!password.Contains(LowerCharacters))
            //    {
            //        if (!password.Contains(numericCharacters))
            //        {
            //            if (!password.Contains(specialCharacters))
            //            {
            //                if (password.Length > 7 && password.Length < 17)
            //                {
            //                    return true;
            //                }
            //                return false;
            //            }
            //            return false;
            //        }
            //        return false;
            //    }
            //    return false;
            //}
            //return false;

            if (password.Length > 7 && password.Length < 17)
            {
                foreach (var item in specialCharacters)
                {
                    if (password.Contains(item))
                    {
                        foreach (var item1 in numericCharacters)
                        {
                            if (password.Contains(item1))
                            {
                                foreach (var item2 in UpperCharacters)
                                {
                                    if (password.Contains(item2))
                                    {
                                        foreach (var item3 in LowerCharacters)
                                        {
                                            if (password.Contains(item3))
                                            {
                                                return true;
                                            }
                                            return false;
                                        }

                                    }
                                    return false;
                                }

                            }
                            return false;
                        }
                    }
                    return false;
                }

            }
            return false;

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
