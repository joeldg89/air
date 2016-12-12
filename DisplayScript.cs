

public class DisplayScript : MonoBehaviour {



    public Text ProductIDValue;
    public Text InputValue1;
    public Text InputValue2;
    public Text InputValue3;

    // Use this for initialization
    void Start()
    {





       // StreamReader ProductReader = new StreamReader(@"C:\Users\Cyberwhiz\Desktop\AirBusProduct\Product1.txt");

        StreamReader ProductReader = new StreamReader(Application.persistentDataPath + "/" +  "Product1.txt");



        char[] delimiter = { ',' };



        string s = ProductReader.ReadLine();


        string[] valuecounter = s.Split(delimiter);

        s = ProductReader.ReadLine();


        ProductIDValue.text = valuecounter[0];
        InputValue1.text = valuecounter[3];
        InputValue2.text = valuecounter[4];
        InputValue3.text = valuecounter[5];

        Debug.Log(ProductScript.counter +"sdfs");



    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnClicEdit()
    {
        ProductScript.counter = 1;

        SceneManager.LoadScene("Add product");

        
    }

    public void OnClickBackButton()
    {
        SceneManager.LoadScene("Home Page");

    }

}
