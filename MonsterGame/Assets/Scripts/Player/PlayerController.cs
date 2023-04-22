using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("----- Components -----")]
    [SerializeField] CharacterController controller;
    public PlayerData data;
    [SerializeField] Camera playerCamera;

    private void Start()
    {
        if (data != null)
            LoadPlayer(data);
    }

    private void LoadPlayer(PlayerData _data)
    {
        foreach (Transform child in this.transform)
        {
            if (Application.isEditor)
                DestroyImmediate(child.gameObject);
            else
                Destroy(child.gameObject);
        }

        GameObject visuals;

        switch (data.tier)
        {
            case Tier.tierOne:
                visuals = Instantiate(data.tierOneUnit);
                visuals.transform.SetParent(this.transform);
                visuals.transform.localPosition = Vector3.zero;
                visuals.transform.rotation = Quaternion.identity;
                return;
            case Tier.tierTwo:
                visuals = Instantiate(data.tierTwoUnit);
                visuals.transform.SetParent(this.transform);
                visuals.transform.localPosition = Vector3.zero;
                visuals.transform.rotation = Quaternion.identity;
                return;
            case Tier.tierThree:
                visuals = Instantiate(data.tierThreeUnit);
                visuals.transform.SetParent(this.transform);
                visuals.transform.localPosition = Vector3.zero;
                visuals.transform.rotation = Quaternion.identity;
                return;
        }

    }
    
    private void Update()
    {
        getPlayerInput();
    }

    private void getPlayerInput()
    {
        movement();
    }

    private void movement()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        controller.Move(move * Time.deltaTime * data.Speed);
    }
}
