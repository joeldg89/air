


public class HomeScript : MonoBehaviour {

    public static string Language;



    public Text AddProduct;


    public GameObject LanguageDefaultEnabled;
    public GameObject LanguageEnglishEnabled;


    // Use this for initialization
    void Start () {

        LanguageDefaultEnabled.SetActive(false);


        try {
         // StreamReader ProductReader = new StreamReader(@"C:\Users\Cyberwhiz\Desktop\AirBusProduct\counter.txt");


           StreamReader ProductReader = new StreamReader(Application.persistentDataPath + "/" + "counter.txt");

            

            char[] delimiter = { ',' };



            string s = ProductReader.ReadLine();


            string[] valuecounter = s.Split(delimiter);

            s = ProductReader.ReadLine();

            ProductScript.counter = int.Parse(valuecounter[0]);

        }
        catch
        {
           
        }


        Debug.Log(ProductScript.counter);


        Language = "English";
    }

    // Update is called once per frame
    void Update () {

        if(Language == "English")
        {

            AddProduct.text = "ADD PRODUCT";

        }
        else
        {

            AddProduct.text = "PRODUKT HINZUFÜGEN";



        }


    }

    public void OnClickAddProduct()
    {
        ProductScript.counter = 1;
        SceneManager.LoadScene("Add product");

    }

    public void OnClickScan()
    {
        ProductScript.counter = 1;
        SceneManager.LoadScene("Display Product");

        Debug.Log(ProductScript.counter);

    }

    public void OnClickLanguageDefault() //Translate to English
    {
        LanguageDefaultEnabled.SetActive(false);
        LanguageEnglishEnabled.SetActive(true);

        Language= "English";

    }

    public void OnClickLanguageEnglish() // translate to German
    {
        LanguageDefaultEnabled.SetActive(true);
        LanguageEnglishEnabled.SetActive(false);


        Language= "German";
    }



    


}
