using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkC__2
{
    internal class CompanyAccess
    {
        static void Main(string[] args)
        {
            var Age = 0;
            string Status = null;
            string Clearance = null;
            string ClearanceLevel = null;
            string Armed = null;
            string AggressionLevel = null;
            string RequestedZoneAccess = null;
            string Access = null;
            int ThreatAssesment = 0;


            //1) Age Input
            Console.WriteLine("Specify your Age:");
            Age = Int32.Parse(Console.ReadLine());
            if (Age < 18)
            {
                Console.WriteLine("Access Request Denied. Our Facility is inaccessible for an underaged citizens. Your Guardian will be notified about your attempt.");
            }
            else
            {//2) Access Status
                Console.WriteLine("Specify your Status - Guest/Employee:");
                bool StatusBullshitCheck = true;
                bool Statusbool = true;
                do
                {
                    Status = Console.ReadLine();
                    if (Status.ToLower() == "guest")
                    {
                        StatusBullshitCheck = true;
                        Statusbool = false;
                        Status = "Guest";
                    }
                    else if (Status.ToLower() == "employee")
                    {
                        StatusBullshitCheck = true;
                        Statusbool = true;
                        Status = "Employee";
                    }
                    else
                    {
                        StatusBullshitCheck = false;
                        Status = "Unrecognized role. Please specify 'Guest' or 'Employee'.";
                        Console.WriteLine(Status);
                    }
                } while (!StatusBullshitCheck);
                //3)Securty Clearance Status
                Console.WriteLine("Do you have an issued Secret Clearance: Yes/No");
                bool ClStBullshitCheck = true;
                bool ClStboolCheck = true;
                do
                {
                    Clearance = Console.ReadLine();
                    if (Clearance.ToLower() == "yes")
                    {
                        ClStBullshitCheck = true;
                        ClStboolCheck = true;
                        Clearance = "Clearance Issued";
                    }
                    else if (Clearance.ToLower() == "no")
                    {
                        ClStBullshitCheck = true;
                        ClStboolCheck = false;
                        Clearance = "Access Request Denied. Our facility in incassesble without a Security Clearance, please, contact your local FSB office.";
                        Console.WriteLine(Clearance);
                        return;
                    }
                    else
                    {
                        ClStBullshitCheck = false;
                        Clearance = "Invalid Input. Verify if you have a Security Clearance.";
                        Console.WriteLine(Clearance);
                    }
                } while (!ClStBullshitCheck);
                //4) Security Clearance Level
                Console.WriteLine("Specify your Security Clearance Level: Confidential/Secret/Top Secret");
                bool ClLvlInputBullshitCheck = true;
                do
                {
                    ClearanceLevel = Console.ReadLine();
                    if (ClearanceLevel.ToLower() == "confidential")
                    {
                        ClLvlInputBullshitCheck = true;
                        ClearanceLevel = "Confidential";
                    }
                    else if (ClearanceLevel.ToLower() == "secret")
                    {
                        ClLvlInputBullshitCheck = true;
                        ClearanceLevel = "Secret";
                    }
                    else if (ClearanceLevel.ToLower() == "top secret")
                    {
                        ClLvlInputBullshitCheck = true;
                        ClearanceLevel = "Top Secret";
                    }
                    else
                    {
                        ClLvlInputBullshitCheck = false;
                        ClearanceLevel = "Invalid Input. Please specify your Security Clearance Level 'Confidential', 'Secret' 'Top Secret'.";
                        Console.WriteLine(ClearanceLevel);
                    }
                } while (!ClLvlInputBullshitCheck);
                //5) Weapon Carry
                Console.WriteLine("Do you have any weapon on You? - Yes/No");
                bool WeaponCarryBullShitCheck = true;
                bool WeaponCarry = true;
                do
                {
                    Armed = Console.ReadLine();
                    if (Armed.ToLower() == "yes")
                    {
                        WeaponCarryBullShitCheck = true;
                        Armed = "Armed";
                        WeaponCarry = false;
                    }
                    else if (Armed.ToLower() == "no")
                    {
                        WeaponCarryBullShitCheck = true;
                        Armed = "Unarmed";
                        WeaponCarry = true;
                    }
                    else
                    {
                        WeaponCarryBullShitCheck = false;
                        Armed = "Please, identify if you carry any weapon on you";
                        Console.WriteLine(Armed);
                    }
                } while (!WeaponCarryBullShitCheck);
                //6) Psych-Evaluation Status
                Console.WriteLine("Identify your most recent psychic-evaluation status - Aggressive/Non-aggressive");
                bool PsyEvalStatusBullShitCheck = true;
                bool PsyEvalStatus = true;
                do
                {
                    AggressionLevel = Console.ReadLine();
                    if (AggressionLevel.ToLower() == "aggressive")
                    {
                        PsyEvalStatusBullShitCheck = true;
                        AggressionLevel = "Aggressive";
                        PsyEvalStatus = false;
                    }
                    else if (AggressionLevel.ToLower() == "non-aggressive")
                    {
                        PsyEvalStatusBullShitCheck = true;
                        AggressionLevel = "Non-aggressive";
                        PsyEvalStatus = true;
                    }
                    else
                    {
                        PsyEvalStatusBullShitCheck = false;
                        AggressionLevel = "Please, identify your most recent psychic-evaluation status - 'Aggressive' or 'Non-aggressive'";
                        Console.WriteLine(AggressionLevel);
                    }
                } while (!PsyEvalStatusBullShitCheck);
                //7) Requested Zone Access
                Console.WriteLine("Specify Requested Zone Access - Conference-room/Lab/Secret Library");
                bool ZoneAccessBullShitCheck = true;
                do
                {
                    RequestedZoneAccess = Console.ReadLine();
                    if (RequestedZoneAccess.ToLower() == "conference-room")
                    {
                        ZoneAccessBullShitCheck = true;
                        RequestedZoneAccess = "Conference-room";
                    }
                    else if (RequestedZoneAccess.ToLower() == "lab")
                    {
                        ZoneAccessBullShitCheck = true;
                        RequestedZoneAccess = "Lab";
                    }
                    else if (RequestedZoneAccess.ToLower() == "secret library")
                    {
                        ZoneAccessBullShitCheck = true;
                        RequestedZoneAccess = "Secret Library";
                    }
                    else
                    {
                        ZoneAccessBullShitCheck = false;
                        RequestedZoneAccess = "Please, identify your most recent psychic-evaluation status - Aggressive/Non-aggressive\"";
                        Console.WriteLine(RequestedZoneAccess);
                    }
                } while (!ZoneAccessBullShitCheck);

                Console.WriteLine("=======================================");
                Console.WriteLine("Verify the following details:");
                Console.WriteLine("Visitor's Age: " + Age);
                Console.WriteLine("Visitor's Status: " + Status);
                Console.WriteLine("Clearance Status: " + Clearance);
                Console.WriteLine("Security Clearance Level: " + ClearanceLevel);
                Console.WriteLine("Weapon Carry: " + Armed);
                Console.WriteLine("Psychic-Evaluation Status: " + AggressionLevel);
                Console.WriteLine("Requested Zone Access: " + RequestedZoneAccess);
                Console.WriteLine("=======================================");
                //Threat Assesment
                if (PsyEvalStatus && WeaponCarry)
                { ThreatAssesment = 1; }
                else if (PsyEvalStatus && !WeaponCarry)
                { ThreatAssesment = 2; }
                else if (!PsyEvalStatus && WeaponCarry)
                { ThreatAssesment = 2; }
                else if (!PsyEvalStatus && !WeaponCarry)
                { ThreatAssesment = 3; }

                
                //Boolean conversion

            
            


                
            }
        }
    }
}
