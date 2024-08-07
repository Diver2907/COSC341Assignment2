using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataLoggerScript : MonoBehaviour
{
    public string filename = "";
    public string participant_id = "";
    public enum Device{mouse,touchpad};
    public Device device;
    public enum Width{small,medium,large};
    public Width width;
    public enum Distance{one,two,three};
    public Distance distance;
    public float time = 0.0f;
    public float FinalTime = 0/0f;
    public int wrong = 0;

    public InputHandlerScript inputHandlerScript;
    public ColorChangingScript colorChangingScript;
    // Start is called before the first frame update
    void Start()
    {
        filename = Application.dataPath + "/"+participant_id+".csv";

    }

    public void WriteCSV(){
        TextWriter tw = new StreamWriter(filename, true);
        tw.WriteLine(""+participant_id+", "+device+", "+width+", "+distance+", "+FinalTime+", "+wrong);
        tw.Close();
        time = 0;
        wrong = 0;
        FinalTime = 0;
    }
}
