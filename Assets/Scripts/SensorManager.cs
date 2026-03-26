using System.Collections.Generic;
using UnityEngine;

public class SensorManager : MonoBehaviour
{
        public GameObject good_crop;
        public GameObject bad_crop;
        public List<GameObject> Positions;
        public GameObject prueba;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SetupSensors(SensorInfo sensorInfo)

    { foreach (var pos in Positions)
        {
            if (sensorInfo.humedad > 0.5)
            {
                var crop= Instantiate(good_crop, pos.transform.position, Quaternion.identity);

                
            }
            else
            {
                var crop = Instantiate(bad_crop, pos.transform.position, Quaternion.identity);
                crop.transform.localScale = pos.transform.localScale;
                pos.SetActive(false);

            }
        }   
    }


    
       
        

 }