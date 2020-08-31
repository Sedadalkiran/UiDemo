using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletefriend : MonoBehaviour
{

    //public Transform myChildObject;

    //public bool _silinsinmi=false;
    // Start is called before the first frame update
   
    //public void Delete_Friend()
    //{

    //    myChildObject.parent.gameObject.SetActive(false);
    //    //Destroy(transform.root.gameObject);
    //    //Destroy(gameObject);
        
    //    gameObject.SetActive(false);

    //}

    public void Kontrol()
    {
        Debug.Log("silindi.");
        transform.root.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
