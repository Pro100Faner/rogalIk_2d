using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectEnemy : MonoBehaviour
{
    public RaycastHit2D hit2D;
    public GameObject enemy;
    private GameObject attakButton;
    private Stats st;
    private Transform pos;
    private float distanse;
    private void Start()
    {
        attakButton = GameObject.Find("AtakButton");
        attakButton.SetActive(false);
        st = gameObject.GetComponent<Player>().stats;
        pos = gameObject.GetComponent<PlayerMovement>().movePoint;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 curPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit2D = Physics2D.Raycast(curPos, Vector2.zero);
            if (hit2D.transform != null)
            {
                if (hit2D.transform.tag == "Enemy")
                {
                    enemy = hit2D.transform.gameObject;
                    Debug.Log("ЦЕЛЬ ВЫБРАНА");
                }
            }
        }

        if (enemy != null)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A)
                || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                distanse = Vector2.Distance(enemy.transform.position, pos.position);
                if (distanse < 3)
                {
                    if (attakButton.activeInHierarchy == false)
                        attakButton.SetActive(true);
                }
                else if (distanse >= 10)
                {
                    enemy = null;
                    attakButton.SetActive(false);
                    Debug.Log("ЦЕЛЬ ПОТЕРЯНА");
                }
                else
                {
                    attakButton.SetActive(false);
                }
            }
        }
    }
}