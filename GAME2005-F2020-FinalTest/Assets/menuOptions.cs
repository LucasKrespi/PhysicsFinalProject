﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuOptions : MonoBehaviour
{
    // Start is called before the first frame update
  public void Playbutton()
    {
        SceneManager.LoadScene(1);
    }
}