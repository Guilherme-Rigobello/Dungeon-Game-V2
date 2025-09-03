using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class Enemy : MonoBehaviour
{
    public string nome;
    public float vida;
    public float speed;
    public float maxVida;

    private void Start()
    {
        vida = maxVida;
        Introduction();
    }

    void Introduction()
    {
        Debug.Log("O nome é" + nome + "a vida é:" + vida + "e o max de vida é:" + maxVida);
    }

}