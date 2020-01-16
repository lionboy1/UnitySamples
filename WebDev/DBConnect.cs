using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DBConnect : MonoBehaviour {

    public Text make;
    public Text model;
    public Text trim;
    public Text year;
    public Text quantity;

    public void AddDetails() {
        StartCoroutine(AddVehicleDetails());
    }

    public void GetDetails() {
        StartCoroutine(RetrieveVehicleDetails());
    }

    public void UpdateDetails() {
        StartCoroutine(UpdateVehicleDetails());
    }

    IEnumerator AddVehicleDetails() {
        Debug.Log("Adding Details");

        WWWForm form = new WWWForm();
        form.AddField("make", make.text);
        form.AddField("model", model.text);
        form.AddField("trim", trim.text);
        form.AddField("year", year.text);
        form.AddField("quantity", quantity.text);

        WWW www = new WWW("http://gsdemo.atwebpages.com/saveCar.php", form);

        yield return www;

        if(www.error != null) {
            Debug.Log(www.error);
        } else {
            Debug.Log(www.text);
        }
    }

    IEnumerator RetrieveVehicleDetails() {
        Debug.Log("Retrieving Details");

        WWWForm form = new WWWForm();
        form.AddField("make", make.text);
        form.AddField("model", model.text);
        form.AddField("trim", trim.text);
        form.AddField("year", year.text);
        //form.AddField("quantity", quantity.text);//Don't pass the field that info is returned to
        WWW www = new WWW("http://gsdemo.atwebpages.com/retrieveCar.php", form);

        yield return www;//yield to Unity for app to execute its logic.
        if (www.error != null) {
            Debug.Log(www.error);
        }
        else 
        {
            Debug.Log(www.text);
            quantity.transform.parent.GetComponent<InputField>().text = www.text;//details[0];//add as many lines as needed. details[] will split strings.
        }
    }

    IEnumerator UpdateVehicleDetails() {
        Debug.Log("Updating Details");

        WWWForm form = new WWWForm();
        form.AddField("make", make.text);
        form.AddField("model", model.text);
        form.AddField("trim", trim.text);
        form.AddField("year", year.text);
        form.AddField("quantity", quantity.text);

        WWW www = new WWW("http://gsdemo.atwebpages.com/updateCar.php", form);

        yield return www;

        if (www.error != null) {
            Debug.Log(www.error);
        }
        else {
            Debug.Log(www.text);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
