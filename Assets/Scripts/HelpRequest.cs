using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mosaic
{
    public class HelpRequest
    {
        public enum Severity{
            Critical,
            Noncritical
        }
        public enum ReliefType
        {
            Food,
            Medicine,
            Water,
            Security,
            Evacuation
        }
        public static string[] FoodDescription = new string[]
        {
            "We just ran out of canned goods!",
            "Hungry, please Help!",
            "Need formula for my Baby",
            "No food left in the grocery store",
            "Food is spoiled, need resupplies!" };
        public static string[] MedicalDescription = new string[]
        {
            "My arm is bleeding badly",
            "Been voimiting consistantly for the last 3 hours",
            "My 2 year old has a fever. Please send help",
            "Cut off my finger on sharp metal object",
            "Foot going gangreen",
            "Man with diabetes passed out",
        };
        public static string[] WaterDescription = new string[]
        {
            "Our water supplies are extremely low",
            "Ran out of water yesterday,HELP!",
            "My family will run out of water in 12 hours.",
            "Need H20, please send help",
            "Extremely low on water",
            "Water is contaminated!"
        };
        public static string[] SecurityDescription = new string[]
        {
            "Breaking and entering through the neighborhood,",
            "Neighbor was just robbed at gunpoint",
            "People are shouting violent threats from the street",
            "Worried my son might get into trouble.",
            "Was just shot at by looters. Need law enforcement"
        };
        public static string[] EvacuationDescription = new string[]
        {
            "Elderly community needs evac. ASAP!",
            "We have 3 children under the age of 5 please get us out!",
            "We're completely out of suplies, need to get out of here",
            "Stranded on the roof, please help us!!!",
            "Our first floor is flooded, we need rescue"
        };
        public enum RequestState
        {
            Active,
            EnRoute,
            PartialCompletion,
            Completed
        }
        public static string description;
        public LatLong locationLatLong;
        public Severity severity;
        public ReliefType reliefType;
        public int numberPeople;
        public System.DateTime timestamp;
        public RequestState state;

        public HelpRequest(LatLong latlong, Severity severity, ReliefType reliefType, int ppl, System.DateTime timestamp, string descript)
        {
            this.locationLatLong = latlong;
            this.severity = severity;
            this.reliefType = reliefType;
            this.numberPeople = ppl;
            this.timestamp = timestamp;
            description = descript;
            this.state = RequestState.Active;
        }

        public string ToString()
        {
            return "Location: " + locationLatLong.ToString()
                + "Relief Type: " + reliefType.ToString()
                + "Severity: " + severity.ToString()
                + "People: " + numberPeople
                + "Request Time: " + timestamp
                + "Description: " + description
                + "State: " + state.ToString();
        }
    }

    public class LatLong{
        float lat;
        float lon;

        public void generateRandom()
        {
            lat = Random.Range(40.500f, 40.800f);
            lon = Random.Range(-74.300f, -74.500f);
        }

        public string ToString()
        {
            return "Lat: " + lat + " Long: " + lon;
        }
    }
}
