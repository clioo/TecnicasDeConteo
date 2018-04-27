using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiadorDeNivel : MonoBehaviour {
	public void cambiarNivel(string nivel)
    {
        SceneManager.LoadScene(nivel);
    }
}
