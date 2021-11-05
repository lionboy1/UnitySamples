using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Add this to a gamme object
public class CustomerDatabase : MonoBehaviour
{
    //Option 2 - let the designer manually populate data in the inspector
    //Reference the customer traits description class
    public CustomerTraits c1;
    public CustomerTraits c2;
    public CustomerTraits c3;
    public CustomerTraits c4;
    
    // Start is called before the first frame update
    void Start()
    {
        //Option 2 - Populate customer data by code.  Comment out to have designer add data
        //Create customers based on the customer traits class fields
        c1 = new CustomerTraits("Zoso", "Tex", 36, "Male", "Engineer");
        c2 = new CustomerTraits("Sally", "Maintz", 28, "Female", "Nutritionist");
        c3 = new CustomerTraits("Wally", "Callzone", 58, "Male", "Doctor");
        c4 = new CustomerTraits("Gelde", "Rasmussen", 68, "Female", "Scientist");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
