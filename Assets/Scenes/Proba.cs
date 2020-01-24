

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;



public class Proba : MonoBehaviour
{

    public GameObject Question;

    public string txtFile = "Putannia";
    string txtContens;
    public static List <string> textArray;
    private TextMesh textComp;










 
    void Start()
    {

        TextAsset textAssets = (TextAsset)Resources.Load(txtFile);

        string text = System.IO.File.ReadAllText("Assets/Putannia.txt");

        // txtContens = textAssets.text;

        // textComp = GetComponent<TextMesh>();






        /*
        string path = @"C:\SomeDir\hta.txt";

        using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
               // Console.WriteLine(line);
            }
        }
        // асинхронное чтение
        using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
        {
            string line;
            while ((line = await sr.ReadLineAsync()) != null)
            {
              //  Console.WriteLine(line);
            }
        }



        */













    }


   
    void Update()
    {
        
    }
  
 

}






public class HandleTextFile
{
    /*
    [MenuItem("Tools/Write file")]
    static void WriteString()
    {
        string path = "Assets/Resources/test.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("Test");
        writer.Close();

        //Re-import the file to update the reference in the editor
        AssetDatabase.ImportAsset(path);
        TextAsset asset = Resources.Load("test");

        //Print the text from the file
        Debug.Log(asset.text);
    }
    */

  //  [MenuItem("Tools/Read file")]
  /*
    static void ReadString()
    {
        string path = "Assets/Resources/test.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }
    */
}
