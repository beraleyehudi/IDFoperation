using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFoperation.Enemy;
using IDFoperation.Aman.Exterior.Actions.Data;
using IDFoperation.Aman.Exterior.Actions;
using IDFoperation.Aman.Interior.Data;
using IDFoperation.IDF;
using System.Collections;

namespace IDFoperation.AuxiliaryFunctions
{
    public static class All
    {
        public static string Input(string inputMessage)
        {
            Console.WriteLine();
            Console.WriteLine(inputMessage + ":\n ");
            string input = Console.ReadLine();
            Console.WriteLine();
            return input;
        }

        public static string PrintMenu(string title, string[] options)
        {
            Console.WriteLine("\n" + title + ":" +
                "\n");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}:  {options[i]}");
            }

            return options[int.Parse(Input("Enter your choice")) - 1];
        }

        public static int RiskCalculation(Terrorist terrorist)
        {
            int weaponScoring = 0;
           

            foreach (Enums.WeaponType weapon in terrorist.Weapons)
            {
                weaponScoring += (int)weapon;


            }

            return weaponScoring* terrorist.Rank;
           
        }

        public static Terrorist MostDangerous()
        {
            Terrorist mostDangerous = null;
            int score = 0;
            foreach (Terrorist terrorist1 in HamasOrganization.GetTerrorists())
            {
                if (RiskCalculation(terrorist1) > score)
                {
                    score = RiskCalculation(terrorist1);
                    mostDangerous = terrorist1;
                }
            }
            //mostDangerous.DisplayInfo();
            return mostDangerous;
        }

        public static Terrorist MostReports()
        {
            int countReports = 0;
            Terrorist theTerrorist = null;
            foreach (KeyValuePair<Terrorist, List<NewReport>> keyValuePair in Reports.reports)
            {
                if (keyValuePair.Value.Count > countReports)
                {
                    countReports = keyValuePair.Value.Count;
                    theTerrorist = keyValuePair.Key;
                }
            }

            //theTerrorist.DisplayInfo();
            return theTerrorist;


        }

        public static string[] typeStrike = { "F16", "Zik drone", "Artillery" };
        public static StrikeInit ChoosingAttackTool()
        {
          
            string typeChoice = PrintMenu("Select attack tool type", typeStrike) ;

            Munitions.GetMunitionsData(new string[] {typeChoice});
            int attackToolChoice = int.Parse(Input("Enter your choice: ")) - 1;

            return Munitions.munitions[typeChoice][attackToolChoice];
            


        }

        public static Terrorist WantedTerrorist()
        {
            string[] options = new string[]{
                "The terrorist with the highest number of reports",
                "The most dangerous terrorist"};

            string choice = PrintMenu("Who is being attacked today?", options);

            switch(choice)
            {
                case "The terrorist with the highest number of reports":
                    return MostReports();


                case "The most dangerous terrorist":
                    return MostDangerous();

            }
            return null;

        }

        public static void AttackTerrorist(OperationsOfficer operationsOfficer)
        {
            Terrorist terrorist = WantedTerrorist();
            StrikeInit strikeInit = ChoosingAttackTool();
            NewReport lastReport = Reports.GetlastReport(terrorist);
           

            OrderAttack orderAttack = new OrderAttack
                (
                terrorist,
                strikeInit,
                operationsOfficer,

                lastReport

                );
            Console.WriteLine("secces");
            strikeInit.Attack();
            terrorist.UpdateTerroristStatus();


        }

    }




}


           













         


