using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{

    #region Public Params:
    [Header("Speeds")]
    public float m_MaxSpeedHorizontal;
    public float m_MaxSpeedLateral;
    [Header("Accelerations")]
    public float m_HorizontalAcceleration;
    public float m_LateralAcceleration;
    [Header("Mouse Sensitivity")]
    public float m_SensY;
    #endregion
    #region Private Params:
    private float m_horizontalInput;
    private float m_lateralInput;

    private float m_horizontalSpeed;
    private float m_lateralSpeed;

    private float m_yRotation;

    private Rigidbody m_rigidbody;
    #endregion

    private void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        //GetInput();
        SetSpeed();
        RotatePlayer();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }


    /// <summary>
    /// receives and saves player's inputs
    /// </summary>
    public void GetInput()
    {
        m_horizontalInput = Input.GetAxisRaw("Vertical");
        m_lateralInput = Input.GetAxisRaw("Horizontal");

        m_yRotation = Input.GetAxisRaw("Mouse X") * m_SensY * Time.deltaTime;
    }
    /// <summary>
    /// Manages the translation speeds on the three axes and the roll speed
    /// </summary>
    private void SetSpeed()
    {
        m_horizontalSpeed = Mathf.Lerp(m_horizontalSpeed, m_MaxSpeedHorizontal * m_horizontalInput, m_HorizontalAcceleration * Time.deltaTime);
        m_lateralSpeed = Mathf.Lerp(m_lateralSpeed, m_MaxSpeedLateral * m_lateralInput, m_LateralAcceleration * Time.deltaTime);

        float[] speeds = { Mathf.Abs(m_horizontalSpeed), Mathf.Abs(m_lateralSpeed) };
        if (m_rigidbody.velocity.magnitude > Mathf.Max(speeds)) m_rigidbody.velocity = m_rigidbody.velocity.normalized * Mathf.Max(speeds);
    }
    /// <summary>
    /// Manages the translation of player on the three axes
    /// </summary>
    private void MovePlayer()
    {
        m_rigidbody.AddForce(m_horizontalSpeed * transform.forward.normalized, ForceMode.Force);
        m_rigidbody.AddForce(m_lateralSpeed * transform.right.normalized, ForceMode.Force);
    }
    /// <summary>
    /// Manages the rotation of player on the three axes
    /// </summary>
    private void RotatePlayer()
    {
        transform.RotateAround(transform.position, transform.up, m_yRotation);
    }

}
