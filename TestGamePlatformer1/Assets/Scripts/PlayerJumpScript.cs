using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpScript : MonoBehaviour
{
    /**
    ** Ускорение игрока
    **/
    [Header("Player velocity")]
    // Ось Ox
    public int xVelocity = 5;
    // Ось Oy
    public int yVelocity = 8;

    // Физическое поведение (тело) объекта
    private Rigidbody2D rigidBody;

    private void Start()
    {
        // Получаем доступ к Rigidbody2D объекта Player
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        updatePlayerPosition();
    }

    // Обновляем местоположение игрока
    private void updatePlayerPosition()
    {
        // Получаем значение ввода горизонтального перемещение
        float moveInput = Input.GetAxis("Horizontal");
        // Получаем значение ввода прыжка
        float jumpInput = Input.GetAxis("Jump");

        // Значения xVelocity, yVelocity можно задать через инспектор

        if (moveInput < 0)
        { // Движ влево
            rigidBody.velocity = new Vector2(-xVelocity, rigidBody.velocity.y);
        }
        else if (moveInput > 0)
        { // Движ вправо
            rigidBody.velocity = new Vector2(xVelocity, rigidBody.velocity.y);
        }

        if (jumpInput > 0)
        { //Тип прыгает
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, yVelocity);
        }
    }
}