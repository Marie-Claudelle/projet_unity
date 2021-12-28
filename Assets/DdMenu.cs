using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DdMenu : MonoBehaviour
{
    public class AddOption : MonoBehaviour
    {
        public List<string> menuList;
        public Text test;

        private string x;
        public void getText()
        {

            x = test.text;
            menuList.Insert(0, x);

        }

        public List<string> get_holder()
        {
            return menuList;
        }
    }
    AddOption ao;
    public Text selectedName;
    public Dropdown drop;


    public void dropIndex(int varIndex)
    {

        selectedName.text = ao.menuList[varIndex];
    }

    public void addItem()
    {

        drop.AddOptions(ao.get_holder());  
    }


}
