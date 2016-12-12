
public class ProductScript : MonoBehaviour {

    public static string ProductIDValue;
    public static string QRScanValue;
    public static string ImageValue;
    public static string InputValue1;
    public static string InputValue2;
    public static string InputValue3;



    public InputField ProductIDField;
    public  InputField QRScanField;
    public InputField ImageField;
    public InputField InputField1;
    public InputField InputField2;
    public InputField InputField3;

    public string[] ProductFileNo;

    public int ProductCounter;

    public static int counter = 1;



    // Use this for initialization
    void Start () {
        ProductFileNo = new string[6];
    }
	
	// Update is called once per frame
	void Update () {
	
	}


    public void OnClickBackButton()
    {
        SceneManager.LoadScene("Home Page");

    }

    public void OnClickSubmitButton()
    {
        
        ProductIDValue = ProductIDField.text.ToString();
        QRScanValue = QRScanField.text.ToString();
        ImageValue = ImageField.text.ToString();
        InputValue1 = InputField1.text.ToString();
        InputValue2 = InputField2.text.ToString();
        InputValue3 = InputField3.text.ToString();


        string ProductFile;
        string ProductCounterFile;
   
            ProductCounter = counter;
     

            ProductFileNo[counter] = counter.ToString();


      // StreamWriter ProductCounterWriter = new StreamWriter(@"C:\Users\Cyberwhiz\Desktop\AirBusProduct\counter.txt");

       StreamWriter ProductCounterWriter = new StreamWriter(Application.persistentDataPath + "/" + "counter.txt");

   

        ProductCounterFile = counter.ToString(); 

        ProductCounterWriter.WriteLine(ProductCounterFile);
        ProductCounterWriter.Close();






      // StreamWriter ProductWriter = new StreamWriter(@"C:\Users\Cyberwhiz\Desktop\AirBusProduct\Product" + ProductFileNo[counter] + ".txt");

        StreamWriter ProductWriter = new StreamWriter(Application.persistentDataPath + "/Product" + ProductFileNo[counter] + ".txt");


        ProductFile = ProductIDValue.ToString() + "," + QRScanValue.ToString() + "," + ImageValue.ToString() + "," + InputValue1.ToString() + ","
                + InputValue2.ToString() + "," + InputValue3.ToString();


            ProductWriter.WriteLine(ProductFile);
            ProductWriter.Close();



            SceneManager.LoadScene("Success Page");

        

    }
}
