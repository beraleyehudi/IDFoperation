using IDFoperation.Aman.Exterior.Actions;
using IDFoperation.Aman.Exterior.Actions.Data;
using IDFoperation.Aman.Interior.Data;
using IDFoperation.Controller;
using IDFoperation.Enemy;
using IDFoperation.IDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFoperation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Terrorist m = new Terrorist("ahmed", 4,Enums.TerroristStatus.Alive,new List<Enums.WeaponType> {Enums.WeaponType.Knife});
            //NewReport t = new NewReport(m,"lop","lko");
            //Reports.f();

           
          
           
            OperationsOfficer ber = new OperationsOfficer("berale");
            
            IntelligenceResearcher berale = new IntelligenceResearcher("berale");
            IntelligenceResearcher ptachya = new IntelligenceResearcher("ptachya");
            IntelligenceResearcher zalush = new IntelligenceResearcher("zalosh");
            IntelligenceResearcher chime = new IntelligenceResearcher("chime");
            berale.NumberOfSuccesses = 88;
            berale.NumberOfReports = 102;
            ptachya.NumberOfSuccesses = 8;
            ptachya.NumberOfReports = 22;
            zalush.NumberOfSuccesses = 42;
            zalush.NumberOfReports = 64;
            chime.NumberOfSuccesses = 110;
            chime.NumberOfReports = 150;

            //CreatingObjects.StrikeInits();
            //CreatingObjects.Terrorists();
            F16 F16one = new F16("10");
            F16 F162 = new F16("11");
            ZikDrone zikOne = new ZikDrone("20");
            ZikDrone zik2 = new ZikDrone("21");
            Artillery artilleryOne = new Artillery("30");
            Artillery artillery2 = new Artillery("31");

            Terrorist yechya = new Terrorist("yechya", 3, Enums.TerroristStatus.Alive, new List<Enums.WeaponType>() { Enums.WeaponType.M16, Enums.WeaponType.Gun });
            Terrorist nassralla = new Terrorist("nassralla", 5, Enums.TerroristStatus.Alive, new List<Enums.WeaponType>() { Enums.WeaponType.Gun, Enums.WeaponType.Knife });
            Terrorist abuFadi = new Terrorist("abu fadi", 2, Enums.TerroristStatus.Alive, new List<Enums.WeaponType>() { Enums.WeaponType.Knife, Enums.WeaponType.AK47 });
            Terrorist murinya = new Terrorist("murinya", 2, Enums.TerroristStatus.Alive, new List<Enums.WeaponType>() { Enums.WeaponType.Knife, Enums.WeaponType.AK47 });


            NewReport report = new NewReport(berale, yechya, Enums.LocationType.people);
            NewReport report2 = new NewReport(berale, yechya, Enums.LocationType.openArea);
            NewReport report3 = new NewReport(berale, yechya, Enums.LocationType.structur);
            NewReport report4 = new NewReport(ptachya, yechya, Enums.LocationType.people);
            NewReport report5 = new NewReport(ptachya, yechya, Enums.LocationType.openArea);
            NewReport report6 = new NewReport(zalush, yechya, Enums.LocationType.structur);

            NewReport report7 = new NewReport(zalush, abuFadi, Enums.LocationType.structur);
            NewReport report8 = new NewReport(chime, abuFadi, Enums.LocationType.structur);
            NewReport report9 = new NewReport(chime, abuFadi, Enums.LocationType.structur);

            NewReport report10 = new NewReport(berale, nassralla, Enums.LocationType.structur);
            NewReport report11 = new NewReport(berale, nassralla, Enums.LocationType.people);
            NewReport report12 = new NewReport(berale, nassralla, Enums.LocationType.structur);
            NewReport report13 = new NewReport(berale, nassralla, Enums.LocationType.structur);



            Menages.Menage(ber, berale);

            //foreach (Terrorist terrorist in HamasOrganization.GetTerrorists())
            //{
            //    terrorist.DisplayInfo();






            //}



        }

    }
}
