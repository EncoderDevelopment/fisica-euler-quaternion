using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Euler : MonoBehaviour
{

    public Transform rotaciona;
    public float tempoRotacao = 3;
    private float direcao;
    private Transform posicaoInicial;

    private float rotationSpeed = 50.0f;
    private float maxLeftAngle = 85.0f;
    private float maxRightAngle = 275.0f;

    private void Start()
    {
        posicaoInicial = transform;
    }

    // Update is called once per frame
    void Update()
    {

        //gira no proprio eixo e volta para o mesmo local
        /*if (Input.GetAxis("Horizontal") < 0)
        {
            direcao = 90;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            direcao = 270;
        }
        else
        {
            direcao = 360;
        }

        rotaciona.transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(new Vector3(0, 0, direcao)), tempoRotacao * Time.deltaTime);
        */

        //gira no proprio eixo e para no local desejado
        float mouseAxisX = Input.GetAxis("Horizontal");
        //Debug.Log(mouseAxisX);
        transform.Rotate(Vector3.back * mouseAxisX * this.rotationSpeed * Time.deltaTime);

        //limita a mudança para o eixo negativo
        /*if (transform.eulerAngles.z > this.maxLeftAngle && transform.eulerAngles.z < 180.0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, maxLeftAngle);
        }
        if (transform.eulerAngles.z < this.maxRightAngle && transform.eulerAngles.z > 180.0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, maxRightAngle);
        }*/
    }
 }