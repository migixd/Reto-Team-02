using System.Collections.Generic;
using UnityEngine;

public class SensorManager : MonoBehaviour
{
    public GameObject good_cropCarrot;
    public GameObject bad_cropCarrot;
    public GameObject good_cropCorn;
    public GameObject bad_cropCorn;
    public List<GameObject> PositionsCarrot;
    public List<GameObject> PositionsCorn;
    public GameObject prueba;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SetupSensors(SensorInfo sensorInfo)
    {
        foreach (var pos in PositionsCarrot)
        {
            if (sensorInfo.humedad > 0.5)
            {
                var crop = Instantiate(good_cropCarrot, pos.transform.position, Quaternion.identity);
            }
            else
            {
                var crop = Instantiate(bad_cropCarrot, pos.transform.position, Quaternion.identity);
                crop.transform.localScale = pos.transform.localScale;
                pos.SetActive(false);
            }
        }

        foreach (var pos in PositionsCorn)
        {
            if (sensorInfo.humedad > 0.5)
            {
                var crop = Instantiate(good_cropCorn, pos.transform.position, Quaternion.identity);
            }
            else
            {
                var crop = Instantiate(bad_cropCorn, pos.transform.position, Quaternion.identity);
                crop.transform.localScale = pos.transform.localScale;
                pos.SetActive(false);
            }
        }
    }
}