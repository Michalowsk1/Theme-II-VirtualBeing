using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseCoat : MonoBehaviour
{
    [SerializeField] GameObject storeCoat;
    [SerializeField] GameObject coat;
    // Start is called before the first frame update
    void Start()
    {
        storeCoat.SetActive(true);
        coat.SetActive(false);
    }

    // Update is called once per frame
    public void PurchasedCoat()
    {
        storeCoat.SetActive(false );
        coat.SetActive(true);
    }
}
