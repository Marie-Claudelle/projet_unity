using UnityEngine;

public class Scroll : MonoBehaviour
{
    
    public Vector2 scrollPosition;
    
    public string longString = "This is a long-ish string";

    
    void OnGUI()
    {

        
        using (var scrollScope = new GUI.ScrollViewScope(new Rect(10, 300, 100, 100), scrollPosition, new Rect(0, 0, 220, 200)))
        {
            scrollPosition = scrollScope.scrollPosition;

            
            GUI.Button(new Rect(0, 0, 100, 20), "Top-left");
            GUI.Button(new Rect(120, 0, 100, 20), "Top-right");
            GUI.Button(new Rect(0, 180, 100, 20), "Bottom-left");
            GUI.Button(new Rect(120, 180, 100, 20), "Bottom-right");
        }
      
       // using (var scrollViewScope = new ScrollViewScope(scrollPosition, GUILayout.Width(100), GUILayout.Height(100)))
       // {
           // scrollPosition = scrollViewScope.scrollPosition;

           // GUILayout.Label(longString);

        
           // if (GUILayout.Button("Clear"))
          //      longString = "";
       // }

        
        if (GUILayout.Button("Add More Text"))
            longString += "\nHere is another line";
    }
    private void Start()
    {
        OnGUI();
    }
}