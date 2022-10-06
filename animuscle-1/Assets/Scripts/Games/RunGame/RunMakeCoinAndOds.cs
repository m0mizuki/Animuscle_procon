using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�R�C���Ƃ��ז��̐���
public class RunMakeCoinAndOds : MonoBehaviour
{
    int[] type = new int[10]; //0:�R�C��,1:���ז�
    int[] posX = new int[10]; //2000~12000
    int[] posY = new int[10]; //-400~100
    int quantity = 10; //�R�C��,���ז��̑���
    int CoinRate = 70; //�R�C���̊���[%]

    public GameObject CoinGO;
    public GameObject ObstacleGO;
    public GameObject CanvasGO;

    // Start is called before the first frame update
    void Start()
    {
        //�R�C���A���ז��̐��A�ʒu������
        for(int i = 0; i < quantity; i++)
        {
            int dif = 10000 / quantity;
            int shake = dif / 5;
            posX[i] = Random.Range(2000 + dif * i - shake, 2000 + dif * i + shake);
            posY[i] = Random.Range(-300, 100);
            if (Random.Range(1, 101) > CoinRate) type[i] = 1;
            else type[i] = 0;
        }
        //�R�C���A���ז���\��
        for (int i = 0; i < quantity; i++)
        {
            GameObject thing;
            if (type[i] == 0) thing = (GameObject)Instantiate(CoinGO, new Vector3(posX[i], posY[i], 0), Quaternion.identity);
            else thing = (GameObject)Instantiate(ObstacleGO, new Vector3(posX[i], posY[i], 0), Quaternion.identity);
            thing.transform.SetParent(CanvasGO.transform, false);
        }
    }
}
