using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class ConsoleOutput : MonoBehaviour
{
    public SerialHandler serialHandler;

    //public Text text;

    public static float[] AngleDataESP = new float[3];

    void Start()
    {
        serialHandler.OnDataReceived += OnDataReceived;
    }

    void OnDataReceived(string message)
    {
        var data = message.Split(
            new string[] { "\n" }, System.StringSplitOptions.None);
        if (data.Length != 1) return;

        TransformAngleData(data[0]);
        //text.text = AngleDataESP[0].ToString() + "\n" + AngleDataESP[1].ToString() + "\n" + AngleDataESP[2].ToString();
    }

    void TransformAngleData(string Data)
    {
        int dataKari = 0;
        int i = 0;
        int j = 0;
        char[] charData = Data.ToCharArray();
        int sign = 1; //ïÑçÜ
        while (j<3)
        {
            if (charData[i] == '/')
            {
                AngleDataESP[j] = (float)dataKari;
                AngleDataESP[j] *= sign;
                AngleDataESP[j] /= 100f;
                dataKari = 0;
                sign = 1;
                j++;
            }
            else
            {
                if (charData[i] == '-')
                {
                    sign = -1;
                }
                else if(charData[i] != '.')
                {
                    dataKari = dataKari * 10 + charData[i] - '0';
                }
            }
            i++;
            if (i > 100)
            {
                Debug.Log("ÉGÉâÅ[");
                break;
            }
        }
    }
}