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

           
          
           
            OperationsOfficer berale = new OperationsOfficer("berale");
            IntelligenceResearcher berale2 = new IntelligenceResearcher("berale2");

            //CreatingObjects.StrikeInits();
            //CreatingObjects.Terrorists();
            F16 F16one = new F16("10");
            F16 F162 = new F16("11");
            ZikDrone zikOne = new ZikDrone("20");
            ZikDrone zik2 = new ZikDrone("21");
            Artillery artilleryOne = new Artillery("30");
            Artillery artillery2 = new Artillery("31");

            Terrorist yechya = new Terrorist("yechya", 3, Enums.TerroristStatus.Alive, new List<Enums.WeaponType>() { Enums.WeaponType.M16, Enums.WeaponType.Gun });
            Terrorist yechya2 = new Terrorist("yechya", 5, Enums.TerroristStatus.Alive, new List<Enums.WeaponType>() { Enums.WeaponType.Gun, Enums.WeaponType.Knife });
            Terrorist yechya3 = new Terrorist("yechya", 2, Enums.TerroristStatus.Alive, new List<Enums.WeaponType>() { Enums.WeaponType.Knife, Enums.WeaponType.AK47 });


            NewReport report = new NewReport(berale2, yechya, Enums.LocationType.structur);
            NewReport report2 = new NewReport(berale2, yechya, Enums.LocationType.structur);
            NewReport report3 = new NewReport(berale2, yechya2, Enums.LocationType.structur);
            NewReport report4 = new NewReport(berale2, yechya2, Enums.LocationType.structur);
            NewReport report5 = new NewReport(berale2, yechya2, Enums.LocationType.structur);
            NewReport report6 = new NewReport(berale2, yechya3, Enums.LocationType.structur);



            Menages.Menage(berale);

            //foreach (Terrorist terrorist in HamasOrganization.GetTerrorists())
            //{
            //    terrorist.DisplayInfo();






            //}



        }

    }
}
