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
            string ThreatAssesment = null;
            string LastName = null;

            Console.WriteLine("Greetings. In order to visit our Facility, please, submit the required data");
            Console.WriteLine("Specify your last name");
            LastName = Console.ReadLine();
            //1) Age Input
            Console.WriteLine("Specify your Age:");
            Age = Int32.Parse(Console.ReadLine());
            if (Age < 18)
            {
                Console.WriteLine("Access Request Denied. Our Facility is inaccessible for the underaged citizens.");
            }
            else
            {//2) Access Status
                Console.WriteLine("Specify your Status - Visitor/Agent:");
                bool StatusBullshitCheck = true;                
                do
                {
                    Status = Console.ReadLine();
                    if (Status.ToLower() == "visitor")
                    {
                        StatusBullshitCheck = true;                       
                        Status = "Visitor";
                    }
                    else if (Status.ToLower() == "agent")
                    {
                        StatusBullshitCheck = true;
                        Status = "Agent";
                    }
                    else
                    {
                        StatusBullshitCheck = false;
                        Status = "Unrecognized role. Please specify 'Visitor' or 'Agent'.";
                        Console.WriteLine(Status);
                    }
                } while (!StatusBullshitCheck);
                //3)Securty Clearance Status
                Console.WriteLine("Do you have an issued Secret Clearance: Yes/No");
                bool ClStBullshitCheck = true;
                do
                {
                    Clearance = Console.ReadLine();
                    if (Clearance.ToLower() == "yes")
                    {
                        ClStBullshitCheck = true;
                        Clearance = "Clearance Issued";
                    }
                    else if (Clearance.ToLower() == "no")
                    {
                        ClStBullshitCheck = true;
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
                Console.WriteLine("Specify requested Zone access - Conference-room/Lab/Secret Library");
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
                        RequestedZoneAccess = "Invalid Input. Specify the requested Zone access - 'Conference-room', 'Lab', 'Secret Library'";
                        Console.WriteLine(RequestedZoneAccess);
                    }
                } while (!ZoneAccessBullShitCheck);
                //Gathered details
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
                { ThreatAssesment = "Low"; }
                else if (PsyEvalStatus && !WeaponCarry)
                { ThreatAssesment = "Medium"; }
                else if (!PsyEvalStatus && WeaponCarry)
                { ThreatAssesment = "Medium"; }
                else if (!PsyEvalStatus && !WeaponCarry)
                { ThreatAssesment = "High"; }

                //Access Calculations - Secret Library:
                if (RequestedZoneAccess == "Secret Library" && Status == "Agent" && ClearanceLevel == "Top Secret" && ThreatAssesment == "Low")
                { Console.WriteLine("Access Granted - Welcome to the Secret Library"); }
                else if (RequestedZoneAccess == "Secret Library" && Status != "Agent" & ClearanceLevel == "Top Secret" & ThreatAssesment == "Low")
                { Console.WriteLine("Access Denied: You must be an Agent to get the Secret Library access"); }
                else if (RequestedZoneAccess == "Secret Library" && Status == "Agent" & ClearanceLevel != "Top Secret" & ThreatAssesment == "Low")
                { Console.WriteLine("Access Denied: You must have the highest clearance level - 'Top Secret' to get the Secret Library access"); }
                else if (RequestedZoneAccess == "Secret Library" && Status == "Agent" & ClearanceLevel != "Top Secret" & ThreatAssesment == "Low")
                { Console.WriteLine("Access Denied: You must be considered a low threat to get the Secret Library access"); }
                //Access Calculations - Lab:
                else if (RequestedZoneAccess == "Lab" && Status == "Agent" && ClearanceLevel != "Confidential" && ThreatAssesment != "High")
                { Console.WriteLine("Access Granted - Welcome to the Lab"); }
                else if (RequestedZoneAccess == "Lab" && Status == "Agent" & ClearanceLevel != "Confidential" & (ThreatAssesment == "High"))
                { Console.WriteLine("Access Denied - High Threat Level agents are not allowed to the Lab"); }
                else if (RequestedZoneAccess == "Lab" && Status == "Agent" & ClearanceLevel == "Confidential" & ThreatAssesment != "High")
                { Console.WriteLine("Access Denied - Contact your Local FSB office to request a higher clearance level."); }
                else if (RequestedZoneAccess == "Lab" && Status == "Agent" & ClearanceLevel == "Confidential" & ThreatAssesment == "High")
                { Console.WriteLine("Access Denied - Contact your Local FSB office to request a higher clearance level and re-evaluate your Threat Level"); }
                else if (RequestedZoneAccess == "Lab" && Status != "Agent" & ClearanceLevel != "Confidential" & ThreatAssesment != "High")
                {Console.WriteLine("Access Denied - Restricted area - Authorized Personnel Only"); }
                //Access Calculations - Conference-room:
                else if (RequestedZoneAccess == "Conference-room" && Status == "Agent" && ClearanceLevel != null && ThreatAssesment != null)
                { Console.WriteLine("Access Granted - Welcome to the Lab"); }
                else if (RequestedZoneAccess == "Conference-room" && Status == "Visitor" && ClearanceLevel != null && ThreatAssesment == "Low")
                { Console.WriteLine("Access Granted - Welcome to the Lab"); }
                else if (RequestedZoneAccess == "Conference-room" && Status == "Visitor" && ClearanceLevel != null && ThreatAssesment != "Low")
                { Console.WriteLine("Access Denied - Threat level assesment failed, contact your Coordinator"); }
                Console.WriteLine("Press any key to exist");
                Console.ReadKey();
            }
        }
    }
}
