using UnityEngine;
using UnityEngine.Networking;
using System.Collections;


public class CustomRequest : MonoBehaviour
{
    public string url;
    public SensorManager sensorManager;
    void Start()
    {
        
        StartCoroutine(GetRequest(url));

    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    //Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                    string jsonstring = webRequest.downloadHandler.text;  
                    SensorInfo sensorinfo = JsonUtility.FromJson<SensorInfo>(jsonstring);
                    sensorManager.SetupSensors(sensorinfo);                    
                    break;
            }
        }
    }
}
