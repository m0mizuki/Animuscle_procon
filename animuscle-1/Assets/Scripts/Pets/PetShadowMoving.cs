using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetShadowMoving : MonoBehaviour
{
    public PetsMoving PM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�e���y�b�g�{�̂�Ǐ]
        transform.position = new Vector3(PM.PetMainPos.x, PM.PetMainPos.y - 0.5f, PM.PetMainPos.z + 1);
    }
}
