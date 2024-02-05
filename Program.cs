using System;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace rampsLoader
{
    public class Ramps
    {
        public String X { get; set; }
        public String Y { get; set; }
        public String OBJECTID { get; set; }
        public String FacType { get; set; }
        public String Name { get; set; }
        public String Access { get; set; }
        public String PrimAgency { get; set; }
        public String PartAgency { get; set; }
        public String Status { get; set; }
        public String Hours { get; set; }
        public String Fees { get; set; }
        public String FeeAmt { get; set; }
        public String FeeCollect { get; set; }
        public String RampSurf { get; set; }
        public String RampCond { get; set; }
        public String SingleLane { get; set; }
        public String DoubleLane { get; set; }
        public String TotalLane { get; set; }
        public String DockType { get; set; }
        public String ParkSurf { get; set; }
        public String ParkCond { get; set; }
        public String Trailer { get; set; }
        public String HandiTrail { get; set; }
        public String Vehicle { get; set; }
        public String Handicap { get; set; }
        public String Restroom { get; set; }
        public String HandiRestr { get; set; }
        public String HandiAcces { get; set; }
        public String Picnic { get; set; }
        public String Lighting { get; set; }
        public String Grill { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String County { get; set; }
        public String Zip { get; set; }
        public String Latitude { get; set; }
        public String Longitude { get; set; }
        public String WaterType { get; set; }
        public String WaterName { get; set; }
        public String created_user { get; set; }
        public String created_date { get; set; }
        public String last_edited_user { get; set; }
        public String last_edited_date { get; set; }
        public String GlobalID { get; set; }
    }


    class Program
    {
        static String userprofileFolder = Environment.GetEnvironmentVariable("USERPROFILE");

        static TextReader sr = new StreamReader(userprofileFolder + "\\Downloads\\" + "FWC_Florida_Boat_Ramp_Inventory.csv");

        static StreamWriter rampsOut = new StreamWriter("ramps.txt");

        static TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

        static void Main(string[] args)
        {
            CsvReader csv = new CsvReader(sr, System.Globalization.CultureInfo.InvariantCulture);

            csv.Read();
            csv.ReadHeader();

            while (csv.Read())
            {
                Ramps record = new Ramps();

                rampsOut.Write(myTI.ToTitleCase(myTI.ToLower(csv.GetField("Name").Trim())));
                rampsOut.Write('~');



                rampsOut.Write(csv.GetField("X").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Y").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("OBJECTID").Trim());
                rampsOut.Write('~');

                rampsOut.Write(myTI.ToTitleCase(myTI.ToLower(csv.GetField("FacType").Trim())));
                rampsOut.Write('~');





                rampsOut.Write(myTI.ToTitleCase(myTI.ToLower(csv.GetField("Access").Trim())));
                rampsOut.Write('~');

                rampsOut.Write(myTI.ToTitleCase(myTI.ToLower(csv.GetField("PrimAgency").Trim())));
                rampsOut.Write('~');

                rampsOut.Write(myTI.ToTitleCase(myTI.ToLower(csv.GetField("PartAgency").Trim())));
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Status").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Hours").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Fees").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("FeeAmt").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("FeeCollect").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("RampSurf").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("RampCond").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("SingleLane").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("DoubleLane").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("TotalLane").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("DockType").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("ParkSurf").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("ParkCond").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Trailer").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("HandiTrail").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Vehicle").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Handicap").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Restroom").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("HandiRestr").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("HandiAcces").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Picnic").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Lighting").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Grill").Trim());
                rampsOut.Write('~');

                rampsOut.Write(myTI.ToTitleCase(myTI.ToLower(csv.GetField("Street").Trim().Replace("~", ""))));
                rampsOut.Write('~');

                rampsOut.Write(myTI.ToTitleCase(myTI.ToLower(csv.GetField("City").Trim())));
                rampsOut.Write('~');

                rampsOut.Write(myTI.ToTitleCase(myTI.ToLower(csv.GetField("County").Trim())));
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Zip").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Latitude").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("Longitude").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("WaterType").Trim());
                rampsOut.Write('~');

                rampsOut.Write(myTI.ToTitleCase(myTI.ToLower(csv.GetField("WaterName").Trim())));
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("created_user").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("created_date").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("last_edited_user").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("last_edited_date").Trim());
                rampsOut.Write('~');

                rampsOut.Write(csv.GetField("GlobalID").Trim());
                
                rampsOut.Write(rampsOut.NewLine);
            }

            rampsOut.Close();
        }
    }
}
/*
                record.X =                  csv.GetField("X");
                record.Y =                  csv.GetField("Y");
                record.OBJECTID =           csv.GetField("OBJECTID");
                record.FacType =            csv.GetField("FacType");
                record.Name =               csv.GetField("Name");
                record.Access =             csv.GetField("Access");
                record.PrimAgency =         csv.GetField("PrimAgency");
                record.PartAgency =         csv.GetField("PartAgency");
                record.Status =             csv.GetField("Status");
                record.Hours =              csv.GetField("Hours");
                record.Fees =               csv.GetField("Fees");
                record.FeeAmt =             csv.GetField("FeeAmt");
                record.FeeCollect =         csv.GetField("FeeCollect");
                record.RampSurf =           csv.GetField("RampSurf");
                record.RampCond =           csv.GetField("RampCond");
                record.SingleLane =         csv.GetField("SingleLane");
                record.DoubleLane =         csv.GetField("DoubleLane");
                record.TotalLane =          csv.GetField("TotalLane");
                record.DockType =           csv.GetField("DockType");
                record.ParkSurf =           csv.GetField("ParkSurf");
                record.ParkCond =           csv.GetField("ParkCond");
                record.Trailer =            csv.GetField("Trailer");
                record.HandiTrail =         csv.GetField("HandiTrail");
                record.Vehicle =            csv.GetField("Vehicle");
                record.Handicap =           csv.GetField("Handicap");
                record.Restroom =           csv.GetField("Restroom");
                record.HandiRestr =         csv.GetField("HandiRestr");
                record.HandiAcces =         csv.GetField("HandiAcces");
                record.Picnic =             csv.GetField("Picnic");
                record.Lighting =           csv.GetField("Lighting");
                record.Grill =              csv.GetField("Grill");
                record.Street =             csv.GetField("Street");
                record.City =               csv.GetField("City");
                record.County =             csv.GetField("County");
                record.Zip =                csv.GetField("Zip");
                record.Latitude =           csv.GetField("Latitude");
                record.Longitude =          csv.GetField("Longitude");
                record.WaterType =          csv.GetField("WaterType");
                record.WaterName =          csv.GetField("WaterName");
                record.created_user =       csv.GetField("created_user");
                record.created_date =       csv.GetField("created_date");
                record.last_edited_user =   csv.GetField("last_edited_user");
                record.last_edited_date =   csv.GetField("last_edited_date");
                record.GlobalID =           csv.GetField("GlobalID");
*/