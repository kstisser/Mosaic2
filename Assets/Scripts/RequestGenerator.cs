using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Mosaic
{
    public class RequestGenerator:MonoBehaviour
    {
        public Text text;
        HelpRequest request;

        void Start()
        {
            request = generateRandomRequest();
            Debug.Log(request.ToString());
        }

        public HelpRequest generateRandomRequest()
        {
            return generateRandomRequest((HelpRequest.ReliefType)UnityEngine.Random.Range(0, 5));
        }

        public HelpRequest generateRandomRequest(HelpRequest.ReliefType type)
        {
            LatLong latlong = new LatLong();
            latlong.generateRandom();
            HelpRequest.Severity severity = (HelpRequest.Severity)UnityEngine.Random.Range(0, 2);
            int ppl = UnityEngine.Random.Range(1, 5);
            return (new HelpRequest(latlong, severity, type, ppl, System.DateTime.Now, pickDescriptor(type)));
        }

        private string pickDescriptor(HelpRequest.ReliefType type)
        {
            if (type == HelpRequest.ReliefType.Medicine)
            {
                return HelpRequest.MedicalDescription[UnityEngine.Random.Range(0, HelpRequest.MedicalDescription.Length)];
            }
            else if (type == HelpRequest.ReliefType.Food)
            {
                return HelpRequest.FoodDescription[UnityEngine.Random.Range(0, HelpRequest.FoodDescription.Length)];
            }
            else if (type == HelpRequest.ReliefType.Water)
            {
                return HelpRequest.WaterDescription[UnityEngine.Random.Range(0, HelpRequest.WaterDescription.Length)];
            }
            else if (type == HelpRequest.ReliefType.Security)
            {
                return HelpRequest.SecurityDescription[UnityEngine.Random.Range(0, HelpRequest.SecurityDescription.Length)];
            }
            else if (type == HelpRequest.ReliefType.Evacuation)
            {
                return HelpRequest.EvacuationDescription[UnityEngine.Random.Range(0, HelpRequest.EvacuationDescription.Length)];
            }
            return "";
        }
    }
}
