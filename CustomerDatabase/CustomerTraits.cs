[System.Serializable]

///<Summary>
//This class is just a definition.  Also not a monobehaviour.  It doesn't need to be attached
//to any game object.  The CustomerDatabase class is and will reference this class
///</Summary>
public class CustomerTraits
{
    public string fname, lname;
    public int age;
    public string gender, occupation;

//Initialize the class
    public CustomerTraits(string fname, string lname, int age, string gender, string occupation)
    {
        this.fname = fname;
        this.lname = lname;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
