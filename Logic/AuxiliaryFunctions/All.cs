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
        public static string str = "ee";
        string.C
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
            int choice = 0;
            Console.WriteLine("\n" + title + ":" +
                "\n");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}:  {options[i]}");
            }
              string input = Input("Enter your choice");
            
            while (!int.TryParse(input, out choice) && choice < options.Length)
            {
                Console.WriteLine("was not prece correct choice");
                input = Input("Enter your choice");


            }
            
            return options[choice - 1];

           

        }
        public static double QualityOfExperience(int attempts, int successes)
        {
            if (successes > 0 && attempts > 0)
            {
                return (((100 / (double)attempts) * (double)successes) / 100) * (double)successes;
            }
            return 0;
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
            mostDangerous.DisplayInfo();
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

            theTerrorist.DisplayInfo();
            return theTerrorist;


        }

        public static string[] typeStrike = { "F16", "Zik drone", "Artillery" };
        public static StrikeUnit ChoosingAttackTool()
        {
          
            string typeChoice = PrintMenu("Select attack tool type", typeStrike) ;

            Munitions.GetMunitionsData(new string[] {typeChoice});
            int attackToolChoice = int.Parse(Input("Enter your choice: ")) - 1;

            return Munitions.munitions[typeChoice][attackToolChoice];
            


        }

        public static Terrorist WantedTerrorist(IntelligenceResearcher intelligenceResearcher)
        {
            string[] options = new string[]{
                "The terrorist with the highest number of reports",
                "The most dangerous terrorist",
                  "alguritem"};

            string choice = PrintMenu("Who is being attacked today?", options);

            Console.WriteLine("The terrorist who will be attacked: \n");
            switch(choice)
            {
                case "The terrorist with the highest number of reports":

                    return MostReports();


                case "The most dangerous terrorist":

                    return MostDangerous();

                case "alguritem":
                    
                    return SelectedTerrorist(intelligenceResearcher).terrorist;

            }
            return null;

        }

        public static void AttackTerrorist(OperationsOfficer operationsOfficer, IntelligenceResearcher intelligenceResearcher)
        {
            Terrorist terrorist = WantedTerrorist(intelligenceResearcher);
            StrikeUnit strikeInit = ChoosingAttackTool();
            NewReport lastReport = Reports.GetlastReport(terrorist);
           

            OrderAttack orderAttack = new OrderAttack
                (
                terrorist,
                strikeInit,
                operationsOfficer,

                lastReport

                );
            Console.WriteLine("success");
            strikeInit.Attack();
            terrorist.UpdateTerroristStatus();


            // בדיקה אם הסטטוס מתעדכן כיאות
            int attempts = orderAttack.Report.IntelligenceResearcher.NumberOfReports;
            int success = orderAttack.Report.IntelligenceResearcher.NumberOfSuccesses;
            Console.WriteLine($"all: {orderAttack.Report.IntelligenceResearcher.NumberOfReports}");
            Console.WriteLine($"success: {orderAttack.Report.IntelligenceResearcher.NumberOfSuccesses}");
            Console.WriteLine($"failuers: {orderAttack.Report.IntelligenceResearcher.NumberOfFailuers}");
            Console.WriteLine($"The quality experience of {orderAttack.Report.IntelligenceResearcher.Name} is:");
            Console.WriteLine(QualityOfExperience(attempts, success));

            AttackResult(orderAttack);


        }

        public static void AttackResult(OrderAttack orderAttack)
        {
            string[] options = {"yes", "no"};
            string choice = PrintMenu("Was the attack succeesful?", options);

            
           


            switch (choice)
            {
                case "yes":
                    orderAttack.UpdataStatus(OrderAttckStatus.success);
                    // בדיקה אם הסטטוס מתעדכן כיאות
                    int attempts = orderAttack.Report.IntelligenceResearcher.NumberOfReports;
                    int success = orderAttack.Report.IntelligenceResearcher.NumberOfSuccesses;
                    Console.WriteLine($"all: {orderAttack.Report.IntelligenceResearcher.NumberOfReports}");
                    Console.WriteLine($"success: {orderAttack.Report.IntelligenceResearcher.NumberOfSuccesses}");
                    Console.WriteLine($"failuers: {orderAttack.Report.IntelligenceResearcher.NumberOfFailuers}");
                    Console.WriteLine($"The quality experience of {orderAttack.Report.IntelligenceResearcher.Name} is:");
                    Console.WriteLine(QualityOfExperience(attempts, success));
                    return;

                case "no":
                    AttackFailure(orderAttack);
                    return;

                    

            }
        }

        public static void AttackFailure(OrderAttack orderAttack)
        {
            // בדיקה אם הסטטוס מתעדכן כיאות
            int attempts = orderAttack.Report.IntelligenceResearcher.NumberOfReports;
            int success = orderAttack.Report.IntelligenceResearcher.NumberOfSuccesses;
            string[] options = { "The intelligence was flawed", "The attack tool failed" };
            string choice = PrintMenu("Why did the attack fail?", options);

            switch(choice)
            {
                case "The intelligence was flawed":
                    orderAttack.UpdataStatus(OrderAttckStatus.intelligenceinformation);




                    Console.WriteLine($"all: {orderAttack.Report.IntelligenceResearcher.NumberOfReports}");
                    Console.WriteLine($"success: {orderAttack.Report.IntelligenceResearcher.NumberOfSuccesses}");
                    Console.WriteLine($"failuers: {orderAttack.Report.IntelligenceResearcher.NumberOfFailuers}");
                    Console.WriteLine($"The quality experience of {orderAttack.Report.IntelligenceResearcher.Name} is:");
                    Console.WriteLine(QualityOfExperience(attempts, success));
                    return;

                case "The attack tool failed":
                    orderAttack.UpdataStatus(OrderAttckStatus.strikeunit);


                    Console.WriteLine($"all: {orderAttack.Report.IntelligenceResearcher.NumberOfReports}");
                    Console.WriteLine($"success: {orderAttack.Report.IntelligenceResearcher.NumberOfSuccesses}");
                    Console.WriteLine($"failuers: {orderAttack.Report.IntelligenceResearcher.NumberOfFailuers}");
                    Console.WriteLine($"The quality experience of {orderAttack.Report.IntelligenceResearcher.Name} is:");
                    Console.WriteLine(QualityOfExperience(attempts, success));
                    return;

            }
        }

        public static int Differentresearchers(List<NewReport> reports)
        {
            Dictionary<IntelligenceResearcher, int> inteligenceResearchers = new Dictionary<IntelligenceResearcher, int>();

            foreach (NewReport report in reports)
            {
                inteligenceResearchers[report.IntelligenceResearcher] = 0;
            }

            return inteligenceResearchers.Count;

        }


        // אינה מחזירה את מספר המיקומים השונה

        public static int DifferentLocations(List<NewReport> reports)
        {
            Dictionary<Enums.LocationType, double> locations = new Dictionary<Enums.LocationType, double>();
            foreach (NewReport report in reports)
            {
                locations[report.Location] = 0;


            }
            return locations.Count;
        }



        public static Dictionary<Enums.LocationType, double> LocationData(List<NewReport> reports)
        {
            Dictionary<Enums.LocationType, double> locations = new Dictionary<Enums.LocationType, double>();

            foreach (NewReport report in reports)
            {
                if (!locations.ContainsKey(report.Location))
                {
                locations[report.Location] = 0;

                }
                locations[report.Location] += report.IntelligenceResearcher.QualityOfExperience();
            }
            double max = 0;
            Enums.LocationType location = Enums.LocationType.structur;

            foreach (KeyValuePair<Enums.LocationType, double> keyValuePair in locations)
            {
                if (keyValuePair.Value > max)
                {
                    max = keyValuePair.Value;
                    location = keyValuePair.Key;
                }


            }
            

            return new Dictionary<Enums.LocationType, double>() { { location, max } };

        }

        public static double CalculatoreLocation(int numberOfResearchers, int numberOfLocations, double locationPoints)
        {
            
            return (100 / numberOfResearchers * numberOfLocations) * locationPoints;
        }

        public static double ReportsQuality(List<NewReport> reports)
        {
            double counter = 0;
            foreach (NewReport report in reports)
            {
                counter += report.IntelligenceResearcher.QualityOfExperience();
            }
            
            return counter;
        }

        public static double ReportingReliability(double reportsQuality, double locationPoints)
        {
            
            return reportsQuality + locationPoints * locationPoints;
        }


        public static NewReport SelectedTerrorist(IntelligenceResearcher intelligenceResearcher)
        {
            Terrorist terrorist = null;
            double maxpoints = 0;
            Enums.LocationType currentLocation = Enums.LocationType.structur;
            Enums.LocationType reallylocation = Enums.LocationType.structur;


            foreach (KeyValuePair<Terrorist, List<NewReport>> keyValuePair in Reports.reports)
            {
                double locationValue = 0;
                Dictionary<Enums.LocationType, double> locationData = LocationData(keyValuePair.Value);
                foreach (KeyValuePair<Enums.LocationType, double> keyValuePair1 in locationData)
                {
                    currentLocation = keyValuePair1.Key;
                    locationValue = keyValuePair1.Value;

                }
                keyValuePair.Key.DisplayInfo();
                Console.WriteLine(ReportingReliability(ReportsQuality(keyValuePair.Value), locationValue));
                if (ReportingReliability(ReportsQuality(keyValuePair.Value), locationValue) > maxpoints)
                {
                    maxpoints = ReportingReliability(ReportsQuality(keyValuePair.Value), locationValue);
                    reallylocation = currentLocation;
                    terrorist = keyValuePair.Key;
                }

                Console.WriteLine("SelectedTerrorist: ");
                Console.WriteLine(maxpoints);
            }

            terrorist.DisplayInfo();
            

            return new NewReport(intelligenceResearcher, terrorist, reallylocation);

        }
                        

                






            

    }
    
    




}










           













         


