//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/InputActionPlayer.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActionPlayer: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActionPlayer()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActionPlayer"",
    ""maps"": [
        {
            ""name"": ""PlayerInput"",
            ""id"": ""d2de86da-bf58-460c-b3f2-5c3597f551bc"",
            ""actions"": [
                {
                    ""name"": ""ActionMovement"",
                    ""type"": ""Value"",
                    ""id"": ""ade70296-def2-4714-9022-8ca71283c6fb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interactions"",
                    ""type"": ""Button"",
                    ""id"": ""6cafaae5-e2c1-457e-976a-b0114f212016"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ControlsMovement"",
                    ""id"": ""38c0d58f-6161-4d07-9e44-4384d0b7ae89"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""760512db-4960-4456-b1d6-84960914e4cc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""846aad11-9543-4a40-8240-4209686d98da"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2fcb0d89-559f-4bef-9fb9-2c5bced9a07f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cac7dd88-12fc-4aba-af07-dfd1975a1004"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerInput
        m_PlayerInput = asset.FindActionMap("PlayerInput", throwIfNotFound: true);
        m_PlayerInput_ActionMovement = m_PlayerInput.FindAction("ActionMovement", throwIfNotFound: true);
        m_PlayerInput_Interactions = m_PlayerInput.FindAction("Interactions", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerInput
    private readonly InputActionMap m_PlayerInput;
    private List<IPlayerInputActions> m_PlayerInputActionsCallbackInterfaces = new List<IPlayerInputActions>();
    private readonly InputAction m_PlayerInput_ActionMovement;
    private readonly InputAction m_PlayerInput_Interactions;
    public struct PlayerInputActions
    {
        private @InputActionPlayer m_Wrapper;
        public PlayerInputActions(@InputActionPlayer wrapper) { m_Wrapper = wrapper; }
        public InputAction @ActionMovement => m_Wrapper.m_PlayerInput_ActionMovement;
        public InputAction @Interactions => m_Wrapper.m_PlayerInput_Interactions;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerInputActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Add(instance);
            @ActionMovement.started += instance.OnActionMovement;
            @ActionMovement.performed += instance.OnActionMovement;
            @ActionMovement.canceled += instance.OnActionMovement;
            @Interactions.started += instance.OnInteractions;
            @Interactions.performed += instance.OnInteractions;
            @Interactions.canceled += instance.OnInteractions;
        }

        private void UnregisterCallbacks(IPlayerInputActions instance)
        {
            @ActionMovement.started -= instance.OnActionMovement;
            @ActionMovement.performed -= instance.OnActionMovement;
            @ActionMovement.canceled -= instance.OnActionMovement;
            @Interactions.started -= instance.OnInteractions;
            @Interactions.performed -= instance.OnInteractions;
            @Interactions.canceled -= instance.OnInteractions;
        }

        public void RemoveCallbacks(IPlayerInputActions instance)
        {
            if (m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerInputActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerInputActions @PlayerInput => new PlayerInputActions(this);
    public interface IPlayerInputActions
    {
        void OnActionMovement(InputAction.CallbackContext context);
        void OnInteractions(InputAction.CallbackContext context);
    }
}
