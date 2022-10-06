using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//コインとお邪魔の生成
public class RunMakeCoinAndOds : MonoBehaviour
{
    int[] type = new int[10]; //0:コイン,1:お邪魔
    int[] posX = new int[10]; //2000~12000
    int[] posY = new int[10]; //-400~100
    int quantity = 10; //コイン,お邪魔の総数
    int CoinRate = 70; //コインの割合[%]

    public GameObject CoinGO;
    public GameObject ObstacleGO;
    public GameObject CanvasGO;

    // Start is called before the first frame update
    void Start()
    {
        //コイン、お邪魔の数、位置を決定
        for(int i = 0; i < quantity; i++)
        {
            int dif = 10000 / quantity;
            int shake = dif / 5;
            posX[i] = Random.Range(2000 + dif * i - shake, 2000 + dif * i + shake);
            posY[i] = Random.Range(-300, 100);
            if (Random.Range(1, 101) > CoinRate) type[i] = 1;
            else type[i] = 0;
        }
        //コイン、お邪魔を表示
        for (int i = 0; i < quantity; i++)
        {
            GameObject thing;
            if (type[i] == 0) thing = (GameObject)Instantiate(CoinGO, new Vector3(posX[i], posY[i], 0), Quaternion.identity);
            else thing = (GameObject)Instantiate(ObstacleGO, new Vector3(posX[i], posY[i], 0), Quaternion.identity);
            thing.transform.SetParent(CanvasGO.transform, false);
        }
    }
}
