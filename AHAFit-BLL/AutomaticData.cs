using AHAFit_Data;
using AHAFit_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_BLL
{
    public class AutomaticData
    {
        Context db = new Context();
        public void MealAndGoalDataLoad()
        {
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
                db.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Goals', RESEED, 1)");
                db.Goals.AddRange(new List<Goal> {
                    new Goal() { Name = "Lose Weight"},
                    new Goal() { Name = "Gain Weight"},
                    new Goal() { Name = "Maintain Your Weight"},
                });
                db.SaveChanges();
            }
        }
        public void AutoAdminMember()
        {
            Member newMember = new Member();
            newMember.Email = "admin@admin.com";
            newMember.Name = "admin";
            newMember.Surname = "admin";
            newMember.Password = "asdfghH1.";
            newMember.Weight = 91.50;
            newMember.Gender = "Male";
            newMember.Height = 185;
            newMember.ActivityLevel = ActivityLevel.ModeratelyActive.ToString();
            newMember.BirthDate = new DateTime(2002, 5, 1);
            newMember.GoalId = 1;

            if (!db.Members.Any(x => x.Email == newMember.Email))
            {
                db.Members.Add(newMember);
                db.SaveChanges();
            }

        }
        public void AddWaterToFoods()
        {
            if (!db.Foods.Any(x => x.Name == "water"))
            {
                Food water = new Food();
                water.Name = "water";
                water.Calorie = 0;
                water.Carbohydrate = 0;
                water.Protein = 0;
                water.Fat = 0;
                water.PhotoURL = "asda";
                water.FoodType = "Water";
                db.Foods.Add(water);
                db.SaveChanges();
            }
        }
        public void AutoMembers()
        {
            List<Member> autoMembers = new List<Member>();

            autoMembers.Add(new Member()
            {
                Email = "pbrittlebank0@omniture.com",
                Name = "Philippine",
                Surname = "Brittlebank",
                Password = "K6aNpK.",
                Weight = 67.4,
                Gender = "Female",
                Height = 159,
                ActivityLevel = ActivityLevel.LightlyActive.ToString(),
                BirthDate = new DateTime(1956, 9, 26),
                GoalId = 1
            });
            autoMembers.Add(new Member()
            {
                Email = "zlongrigg1@drupal.org",
                Name = "Zabrina",
                Surname = "Longrigg",
                Password = "I1jiAkNEd.",
                Weight = 65.3,
                Gender = "Female",
                Height = 154,
                ActivityLevel = ActivityLevel.Sedentary.ToString(),
                BirthDate = new DateTime(1981, 11, 2),
                GoalId = 1
            });
            autoMembers.Add(new Member()
            {
                Email = "egurley2@google.de",
                Name = "Elisa",
                Surname = "Gurley",
                Password = "YKesAp1.",
                Weight = 99.4,
                Gender = "Male",
                Height = 197,
                ActivityLevel = ActivityLevel.VeryActive.ToString(),
                BirthDate = new DateTime(1930, 7, 14),
                GoalId = 2
            });
            autoMembers.Add(new Member()
            {
                Email = "opycock3@google.de",
                Name = "Olga",
                Surname = "Pycock",
                Password = "fuzJERECVp1.",
                Weight = 101.5,
                Gender = "Male",
                Height = 171,
                ActivityLevel = ActivityLevel.VeryActive.ToString(),
                BirthDate = new DateTime(1954, 2, 22),
                GoalId = 3
            });
            autoMembers.Add(new Member()
            {
                Email = "ejurewicz4@china.com.cn",
                Name = "Elston",
                Surname = "Jurewicz",
                Password = "qsdhimwe1.A",
                Weight = 113.8,
                Gender = "Male",
                Height = 170,
                ActivityLevel = ActivityLevel.Sedentary.ToString(),
                BirthDate = new DateTime(1956, 2, 7),
                GoalId = 1
            });
            autoMembers.Add(new Member()
            {
                Email = "hiacomelli5@si.edu",
                Name = "Helga",
                Surname = "Iacomelli",
                Password = "NGYXWJIw.a1",
                Weight = 65.5,
                Gender = "Male",
                Height = 151,
                ActivityLevel = ActivityLevel.ModeratelyActive.ToString(),
                BirthDate = new DateTime(1962, 11, 21),
                GoalId = 1
            });
            autoMembers.Add(new Member()
            {
                Email = "mmilhench6@nyu.edu",
                Name = "Moss",
                Surname = "Milhench",
                Password = "pdKFVy3KyjhU.",
                Weight = 71.5,
                Gender = "Male",
                Height = 189,
                ActivityLevel = ActivityLevel.VeryActive.ToString(),
                BirthDate = new DateTime(1948, 12, 31),
                GoalId = 1
            });
            autoMembers.Add(new Member()
            {
                Email = "amcconway7@is.gd",
                Name = "Alfredo",
                Surname = "McConway",
                Password = "lRV2GgwHEY.",
                Weight = 50.9,
                Gender = "Male",
                Height = 169,
                ActivityLevel = ActivityLevel.Sedentary.ToString(),
                BirthDate = new DateTime(1993, 11, 28),
                GoalId = 2
            });
            autoMembers.Add(new Member()
            {
                Email = "gbygraves8@patch.com",
                Name = "Gray",
                Surname = "Bygraves",
                Password = "GM2o7YQaL.",
                Weight = 63.2,
                Gender = "Female",
                Height = 183,
                ActivityLevel = ActivityLevel.ModeratelyActive.ToString(),
                BirthDate = new DateTime(1968, 1, 15),
                GoalId = 2
            });
            autoMembers.Add(new Member()
            {
                Email = "aremirez9@nyu.edu",
                Name = "Abramo",
                Surname = "Remirez",
                Password = "ZkrVTZI1P.",
                Weight = 80.3,
                Gender = "Male",
                Height = 166,
                ActivityLevel = ActivityLevel.ModeratelyActive.ToString(),
                BirthDate = new DateTime(1988, 3, 22),
                GoalId = 3
            });
            autoMembers.Add(new Member()
            {
                Email = "eperforda@businessweek.com",
                Name = "Emera",
                Surname = "Perford",
                Password = "HTWsgZ6DZ8z6.",
                Weight = 54.1,
                Gender = "Male",
                Height = 170,
                ActivityLevel = ActivityLevel.VeryActive.ToString(),
                BirthDate = new DateTime(1951, 12, 26),
                GoalId = 2
            });
            autoMembers.Add(new Member()
            {
                Email = "lescheb@spiegel.de",
                Name = "Linnell",
                Surname = "Esche",
                Password = "umSgfrel0.",
                Weight = 75.4,
                Gender = "Male",
                Height = 176,
                ActivityLevel = ActivityLevel.LightlyActive.ToString(),
                BirthDate = new DateTime(1947, 11, 17),
                GoalId = 2
            });
            autoMembers.Add(new Member()
            {
                Email = "vhapgoodc@histats.com",
                Name = "Vladimir",
                Surname = "Hapgood",
                Password = "LGp0HTomW.",
                Weight = 99.9,
                Gender = "Male",
                Height = 164,
                ActivityLevel = ActivityLevel.Sedentary.ToString(),
                BirthDate = new DateTime(1992, 8, 9),
                GoalId = 3
            });
            autoMembers.Add(new Member()
            {
                Email = "nmcgoochd@creativecommons.org",
                Name = "Nicoli",
                Surname = "McGooch",
                Password = "aShzAfPKnkAT.",
                Weight = 59.5,
                Gender = "Male",
                Height = 178,
                ActivityLevel = ActivityLevel.VeryActive.ToString(),
                BirthDate = new DateTime(1937, 9, 26),
                GoalId = 1
            });
            autoMembers.Add(new Member()
            {
                Email = "lrutiglianoe@etsy.com",
                Name = "Lyndsey",
                Surname = "Rutigliano",
                Password = "fs8hey719m.",
                Weight = 94.7,
                Gender = "Male",
                Height = 161,
                ActivityLevel = ActivityLevel.ModeratelyActive.ToString(),
                BirthDate = new DateTime(1974, 2, 22),
                GoalId = 1
            });
            autoMembers.Add(new Member()
            {
                Email = "mcowdroyf@howstuffworks.com",
                Name = "Mord",
                Surname = "Cowdroy",
                Password = "FuwJPyX0ss12.",
                Weight = 74.2,
                Gender = "Male",
                Height = 188,
                ActivityLevel = ActivityLevel.Sedentary.ToString(),
                BirthDate = new DateTime(1988, 12, 24),
                GoalId = 1
            });
            autoMembers.Add(new Member()
            {
                Email = "acurryerg@nyu.edu",
                Name = "Ainslie",
                Surname = "Curryer",
                Password = "ciDFV4G7E.",
                Weight = 119.7,
                Gender = "Male",
                Height = 180,
                ActivityLevel = ActivityLevel.Sedentary.ToString(),
                BirthDate = new DateTime(1985, 9, 27),
                GoalId = 2
            });
            autoMembers.Add(new Member()
            {
                Email = "dminshawh@pinterest.com",
                Name = "Dedra",
                Surname = "Minshaw",
                Password = "tLQfm93yY.",
                Weight = 116.0,
                Gender = "Female",
                Height = 162,
                ActivityLevel = ActivityLevel.VeryActive.ToString(),
                BirthDate = new DateTime(2002, 5, 1),
                GoalId = 1
            });
            autoMembers.Add(new Member()
            {
                Email = "ldunphyi@techcrunch.com",
                Name = "Leyla",
                Surname = "Dunphy",
                Password = "ocuYriN1.",
                Weight = 100.6,
                Gender = "Male",
                Height = 181,
                ActivityLevel = ActivityLevel.ModeratelyActive.ToString(),
                BirthDate = new DateTime(1975, 11, 21),
                GoalId = 2
            });
            autoMembers.Add(new Member()
            {
                Email = "fbaurerichj@mediafire.com",
                Name = "Fiona",
                Surname = "Baurerich",
                Password = "ej9wNA9mcV.",
                Weight = 57.1,
                Gender = "Female",
                Height = 165,
                ActivityLevel = ActivityLevel.ModeratelyActive.ToString(),
                BirthDate = new DateTime(1990, 6, 8),
                GoalId = 3
            });

            foreach (var Member in autoMembers)
            {
                if (!db.Members.Any(x => x.Email == Member.Email))
                {
                    db.Members.Add(Member);
                    db.SaveChanges();
                }
            }
        }
        public void AutoFoods()
        {
            List<Food> autoFoods = new List<Food>();
            autoFoods.Add(new Food()
            {
                Name = "apple",
                Calorie = 95,
                Carbohydrate = 25,
                Protein = 0.5,
                Fat = 0.3,
                
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/399_thumb.jpg",
                FoodType = "Fruit",
            });
            autoFoods.Add(new Food()
            {
                Name = "banana",
                Calorie = 105,
                Carbohydrate = 27,
                Protein = 1.3,
                Fat = 0.4,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/399_thumb.jpg",
                FoodType = "Fruit",
            });
            autoFoods.Add(new Food()
            {
                Name = "orange",
                Calorie = 69,
                Carbohydrate = 18,
                Protein = 1.3,
                Fat = 0.2,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/719_thumb.jpg",
                FoodType = "Fruit",
            });
            autoFoods.Add(new Food()
            {
                Name = "peach",
                Calorie = 68,
                Carbohydrate = 17,
                Protein = 1.6,
                Fat = 0.4,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/225_thumb.jpg",
                FoodType = "Fruit",
            });
            autoFoods.Add(new Food()
            {
                Name = "pear",
                Calorie = 101,
                Carbohydrate = 27,
                Protein = 0.6,
                Fat = 0.3,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/190_thumb.jpg",
                FoodType = "Fruit",
            });
            autoFoods.Add(new Food()
            {
                Name = "grape",
                Calorie = 34,
                Carbohydrate = 8.9,
                Protein = 0.4,
                Fat = 0.1,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/586_thumb.jpg",
                FoodType = "Fruit",
            });

            autoFoods.Add(new Food()
            {
                Name = "broccoli",
                Calorie = 35,
                Carbohydrate = 7.2,
                Protein = 2.4,
                Fat = 0.4,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/363_thumb.jpg",
                FoodType = "Vegetable",
            });
            autoFoods.Add(new Food()
            {
                Name = "spinach",
                Calorie = 41,
                Carbohydrate = 6.8,
                Protein = 5.3,
                Fat = 0.5,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/263_thumb.jpg",
                FoodType = "Vegetable",
            });
            autoFoods.Add(new Food()
            {
                Name = "carrot",
                Calorie = 16,
                Carbohydrate = 3.8,
                Protein = 0.3,
                Fat = 0.1,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/452_thumb.jpg",
                FoodType = "Vegetable",
            });
            autoFoods.Add(new Food()
            {
                Name = "tomato",
                Calorie = 22,
                Carbohydrate = 4.8,
                Protein = 1.1,
                Fat = 0.3,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/191_thumb.jpg",
                FoodType = "Vegetable",
            });
            autoFoods.Add(new Food()
            {
                Name = "potato",
                Calorie = 161,
                Carbohydrate = 37,
                Protein = 4.3,
                Fat = 0.2,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/752_thumb.jpg",
                FoodType = "Vegetable",
            });
            autoFoods.Add(new Food()
            {
                Name = "mushroom",
                Calorie = 30.8,
                Carbohydrate = 5.7,
                Protein = 2.3,
                Fat = 0.5,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/148_thumb.jpg",
                FoodType = "Vegetable",
            });

            autoFoods.Add(new Food()
            {
                Name = "rice",
                Calorie = 205,
                Carbohydrate = 45,
                Protein = 4.3,
                Fat = 0.4,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/784_thumb.jpg",
                FoodType = "Grain",
            });
            autoFoods.Add(new Food()
            {
                Name = "oatmeal",
                Calorie = 166,
                Carbohydrate = 28,
                Protein = 5.9,
                Fat = 3.6,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/87_thumb.jpg",
                FoodType = "Grain",
            });
            autoFoods.Add(new Food()
            {
                Name = "pretzel",
                Calorie = 109,
                Carbohydrate = 23,
                Protein = 2.8,
                Fat = 0.8,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/60_thumb.jpg",
                FoodType = "Grain",
            });
            autoFoods.Add(new Food()
            {
                Name = "popcorn",
                Calorie = 44,
                Carbohydrate = 4.4,
                Protein = 0.6,
                Fat = 2.7,
                PhotoURL = "https://d2eawub7utcl6.cloudfront.net/images/nix-apple-grey.png",
                FoodType = "Grain",
            });
            autoFoods.Add(new Food()
            {
                Name = "pasta",
                Calorie = 196,
                Carbohydrate = 38,
                Protein = 7.2,
                Fat = 1.2,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/1012_thumb.jpg",
                FoodType = "Grain",
            });
            autoFoods.Add(new Food()
            {
                Name = "muffin",
                Calorie = 424,
                Carbohydrate = 60,
                Protein = 5.1,
                Fat = 18,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/694_thumb.jpg",
                FoodType = "Grain",
            });


            autoFoods.Add(new Food()
            {
                Name = "salmon",
                Calorie = 468,
                Carbohydrate = 0,
                Protein = 50,
                Fat = 28,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/375_thumb.jpg",
                FoodType = "ProteinFood",
            });
            autoFoods.Add(new Food()
            {
                Name = "beef",
                Calorie = 220,
                Carbohydrate = 0,
                Protein = 22,
                Fat = 14,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/192_thumb.jpg",
                FoodType = "ProteinFood",
            });
            autoFoods.Add(new Food()
            {
                Name = "black bean",
                Calorie = 227,
                Carbohydrate = 41,
                Protein = 15,
                Fat = 0.9,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/245_thumb.jpg",
                FoodType = "ProteinFood",
            });
            autoFoods.Add(new Food()
            {
                Name = "soybeans",
                Calorie = 296,
                Carbohydrate = 14,
                Protein = 31,
                Fat = 15,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/2769_thumb.jpg",
                FoodType = "ProteinFood",
            });
            autoFoods.Add(new Food()
            {
                Name = "egg",
                Calorie = 72,
                Carbohydrate = 0.4,
                Protein = 6.3,
                Fat = 4.8,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/542_thumb.jpg",
                FoodType = "ProteinFood",
            });

            autoFoods.Add(new Food()
            {
                Name = "milk",
                Calorie = 122,
                Carbohydrate = 12,
                Protein = 8.1,
                Fat = 4.8,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/377_thumb.jpg",
                FoodType = "Dairy",
            });
            autoFoods.Add(new Food()
            {
                Name = "milk",
                Calorie = 107,
                Carbohydrate = 12,
                Protein = 8.9,
                Fat = 2.6,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/186_thumb.jpg",
                FoodType = "Dairy",
            });
            autoFoods.Add(new Food()
            {
                Name = "kefir",
                Calorie = 112,
                Carbohydrate = 12,
                Protein = 11,
                Fat = 2.2,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/2472_thumb.jpg",
                FoodType = "Dairy",
            });
            autoFoods.Add(new Food()
            {
                Name = "cheese",
                Calorie = 113,
                Carbohydrate = 0.9,
                Protein = 6.4,
                Fat = 9.3,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/1034_thumb.jpg",
                FoodType = "Dairy",
            });
            autoFoods.Add(new Food()
            {
                Name = "cottage cheese",
                Calorie = 107,
                Carbohydrate = 3.7,
                Protein = 12,
                Fat = 4.7,
                PhotoURL = "https://nix-tag-images.s3.amazonaws.com/510_thumb.jpg",
                FoodType = "Dairy",
            });
            autoFoods.Add(new Food()
            {
                Name = "soymilk",
                Calorie = 110,
                Carbohydrate = 9,
                Protein = 8,
                Fat = 4.5,
                PhotoURL = "https://nutritionix-api.s3.amazonaws.com/53600a6067efca3d4b64cfc9.jpeg",
                FoodType = "Dairy",
            });


            foreach (var Food in autoFoods)
            {
                if (!db.Foods.Any(x => x.Name == Food.Name))
                {
                    db.Foods.Add(Food);
                    db.SaveChanges();
                }
            }
        }
        public void AutoFoodAdderToMemberAndMeals()
        {
            if (db.MembersFoods.ToList().Count() > 250)
                return;

            List<int> foodIds = new List<int>();
            foreach (var food in db.Foods.ToList())
            {
                foodIds.Add(food.FoodId);
            }
            Random rnd = new Random();

            foreach (var member in db.Members)
            {
                for (int i = 0; i < 5; i++)
                {
                    MemberFood newMemberFood = new MemberFood();
                    MealFood newMealFood = new MealFood();
                    int randomFoodId = foodIds[rnd.Next(foodIds.Count)];

                    newMemberFood.CreateDateTime = DateTime.Now.AddDays(rnd.Next(-35, 1)).Date;
                    newMemberFood.MemberId = member.MemberId;
                    newMemberFood.FoodId = randomFoodId;
                    newMemberFood.MealId = rnd.Next(1, 4);

                    newMealFood.CreateDateTime = newMemberFood.CreateDateTime;
                    newMealFood.MealId = newMemberFood.MealId;
                    newMealFood.FoodId = newMemberFood.FoodId;

                    MemberFood newMemberFood2 = new MemberFood();
                    MealFood newMealFood2 = new MealFood();
                    int randomFoodId2 = foodIds[rnd.Next(foodIds.Count)];

                    newMemberFood2.CreateDateTime = DateTime.Now.Date;
                    newMemberFood2.MemberId = member.MemberId;
                    newMemberFood2.FoodId = randomFoodId;
                    newMemberFood2.MealId = rnd.Next(1, 4);

                    newMealFood2.CreateDateTime = newMemberFood2.CreateDateTime;
                    newMealFood2.MealId = newMemberFood2.MealId;
                    newMealFood2.FoodId = newMemberFood2.FoodId;

                    db.MembersFoods.Add(newMemberFood);
                    db.MembersFoods.Add(newMemberFood2);
                    db.MealsFoods.Add(newMealFood);
                    db.MealsFoods.Add(newMealFood2);
                }
            }
            db.SaveChanges();
        }
    }
}
