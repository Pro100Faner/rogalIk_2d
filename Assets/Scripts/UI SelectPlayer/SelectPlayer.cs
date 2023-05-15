using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEditor.Animations;
public class SelectPlayer : MonoBehaviour
{
    public GameObject playerPref;
    public Text selectName;
    public Image selectImage;
    public GameObject selectPage;
    public Text selectDescr;
    private string description;
    private Sprite curSprite;
    private DontDestr  dDestroy;

    private void Start() {
        description = CreateDescrSelectPlayer();
        dDestroy =  GameObject.Find("dDestrList").GetComponent<DontDestr>();
        curSprite = gameObject.GetComponent<Image>().sprite;
        selectPage.SetActive(false);
    }
    public void Select(){
        if(!selectPage.activeInHierarchy){
            selectPage.SetActive(true);
        }
        selectName.text = gameObject.name;
        selectImage.sprite = curSprite;
        selectDescr.text = description;
        dDestroy.PlayerPref = playerPref;
    }
    private string CreateDescrSelectPlayer(){
        string customDescr = "";
        string namePlayer = gameObject.name;
        switch(namePlayer){
            case "Engineer":
                customDescr = "Базовый класс.\n\nОбычный прирост параметров.";
                break;
            case "Mage":
                customDescr = "Класс мага.\n\nПонижен прирост здоровья.\n\nПовыщен прирост маны.";
                break;
            case "Rogue":
                customDescr = "Класс убийцы.\n\nПовыщен прирост урона.\n\nПонижен прирост здоровья.\n\nПонижен прирост маны.";
                break;
        }

        return customDescr;
    }
}
