﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EnableChoice : MonoBehaviour
{

    public string choice1Text;
    public string choice2Text;
    [Space(10)]
    public string choice1Scene;
    public string choice2Scene;

    private GameObject choice1Image;
    private GameObject choice2Image;

    private GameObject magGlass;


    private void Awake()
    {
        choice1Image = GameObject.FindGameObjectWithTag("Choice1");
        choice2Image = GameObject.FindGameObjectWithTag("Choice2");

        magGlass = GameObject.FindGameObjectWithTag("MagGlass");
    }

    // Start is called before the first frame update
    void Start()
    {
        magGlass.transform.position = Input.mousePosition;

        magGlass.transform.GetChild(0).gameObject.SetActive(true);

        choice1Image.gameObject.transform.GetChild(1).GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().SetText(choice1Text);
        choice2Image.gameObject.transform.GetChild(1).GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().SetText(choice2Text);

        choice1Image.gameObject.transform.GetChild(0).gameObject.GetComponent<Button>().onClick.AddListener(Option1OnClick);
        choice2Image.gameObject.transform.GetChild(0).gameObject.GetComponent<Button>().onClick.AddListener(Option2OnClick);

        choice1Image.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        choice2Image.gameObject.transform.GetChild(0).gameObject.SetActive(true);

        //choice1Image.gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
        //choice2Image.gameObject.transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
    }

    void Option1OnClick()
    {
        magGlass.transform.GetChild(0).gameObject.SetActive(false);
        Cursor.visible = true;

        SceneManager.LoadScene(choice1Scene);
    }

    void Option2OnClick()
    {
        magGlass.transform.GetChild(0).gameObject.SetActive(false);
        Cursor.visible = true;

        SceneManager.LoadScene(choice2Scene);
    }
}
