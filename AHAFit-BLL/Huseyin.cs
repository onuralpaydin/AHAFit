﻿using AHAFit_Data;
using AHAFit_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_BLL
{
    public class Huseyin
    {
        public static void MealAndGoalDataLoad()
        {
            Context db = new Context();
            if (!db.Meals.Any())
            {
                db.Meals.AddRange(new List<Meal> {
                    new Meal() { Name = "Breakfast"},
                    new Meal() { Name = "Lunch"},
                    new Meal() { Name = "Dinner"},
                });

                db.SaveChanges();
            }

            if (!db.Goals.Any())
            {
                db.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Goals', RESEED, 0)");
                db.Goals.AddRange(new List<Goal> {
                    new Goal() { Name = "Lose Weight", GoalId = 1},
                    new Goal() { Name = "Gain Weight", GoalId = 2},
                    new Goal() { Name = "Maintain Your Weight", GoalId = 3},
                });
                db.SaveChanges();
            }else
            {
                foreach (var item in db.Goals)
                {
                    db.Goals.Remove(item);
                }
                db.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Goals', RESEED, 0)");
                db.Goals.AddRange(new List<Goal> {
                    new Goal() { Name = "Lose Weight", GoalId = 1},
                    new Goal() { Name = "Gain Weight", GoalId = 2},
                    new Goal() { Name = "Maintain Your Weight", GoalId = 3},
                });
                db.SaveChanges();
            }

        }

        public static void AutoAdminMember()
        {
            Context db = new Context();
            Member newMember = new Member();
            newMember.Email = "admin@admin.com";
            newMember.Name = "admin";
            newMember.Surname = "admin";
            newMember.Password = "admin";
            newMember.Weight = 91.50m;
            newMember.Gender = "Male";
            newMember.Height = 185;
            newMember.BirthDate = new DateTime(2002, 5, 1);
            newMember.GoalId = 1;

            if(!db.Members.Any(x=>x.Email == newMember.Email))
            {
                db.Members.Add(newMember);
                db.SaveChanges();
            }
           
        }

        public static bool MemberLoginControl(string email, string password)
        {
            Context db = new Context();
            if(!db.Members.Any(x=>x.Email == email))
            {
                return false;

            }else if(db.Members.FirstOrDefault(x=>x.Email == email).Password != password)
            {
                return false;
            }else
            {
                return true;
            }
        }

        public static int MemberIdFounder(string email)
        {
            Context db = new Context();
            return db.Members.FirstOrDefault(x => x.Email == email).MemberId;

        }
    }
}
