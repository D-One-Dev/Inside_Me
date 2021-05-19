// GENERATED AUTOMATICALLY FROM 'Assets/Input actions/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""cb37f3dd-11c2-4399-a583-0e3f72a2beed"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""Value"",
                    ""id"": ""0804ee16-a1c6-4cf2-ae6e-e73f7e0fd902"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveZ"",
                    ""type"": ""Value"",
                    ""id"": ""c41a2fe9-41c2-4aaf-9296-154f8517fcc5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateX"",
                    ""type"": ""Value"",
                    ""id"": ""580bae60-b7a6-42e4-8da5-d7521ca7810c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateZ"",
                    ""type"": ""Value"",
                    ""id"": ""50952210-366f-4b78-8d0e-9b911e589b85"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""36fff604-a9d3-48dd-bbb3-ba0791d59344"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a83ce819-2aed-4c36-9e30-f0103e4a33e2"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9cdc21c-8287-4a31-a113-c4228a2b56b4"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3e1dcc3-527b-4a47-8c9e-bcf6c6e392aa"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RotateX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdaecd31-7edd-438a-bb29-a785967c4bfa"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RotateZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f9e5aa7-b78d-4f7a-9cac-a015b52142db"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_MoveX = m_Gameplay.FindAction("MoveX", throwIfNotFound: true);
        m_Gameplay_MoveZ = m_Gameplay.FindAction("MoveZ", throwIfNotFound: true);
        m_Gameplay_RotateX = m_Gameplay.FindAction("RotateX", throwIfNotFound: true);
        m_Gameplay_RotateZ = m_Gameplay.FindAction("RotateZ", throwIfNotFound: true);
        m_Gameplay_Fire = m_Gameplay.FindAction("Fire", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_MoveX;
    private readonly InputAction m_Gameplay_MoveZ;
    private readonly InputAction m_Gameplay_RotateX;
    private readonly InputAction m_Gameplay_RotateZ;
    private readonly InputAction m_Gameplay_Fire;
    public struct GameplayActions
    {
        private @PlayerInput m_Wrapper;
        public GameplayActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_Gameplay_MoveX;
        public InputAction @MoveZ => m_Wrapper.m_Gameplay_MoveZ;
        public InputAction @RotateX => m_Wrapper.m_Gameplay_RotateX;
        public InputAction @RotateZ => m_Wrapper.m_Gameplay_RotateZ;
        public InputAction @Fire => m_Wrapper.m_Gameplay_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @MoveX.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveX;
                @MoveZ.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveZ;
                @MoveZ.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveZ;
                @MoveZ.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveZ;
                @RotateX.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateX;
                @RotateX.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateX;
                @RotateX.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateX;
                @RotateZ.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateZ;
                @RotateZ.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateZ;
                @RotateZ.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateZ;
                @Fire.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @MoveZ.started += instance.OnMoveZ;
                @MoveZ.performed += instance.OnMoveZ;
                @MoveZ.canceled += instance.OnMoveZ;
                @RotateX.started += instance.OnRotateX;
                @RotateX.performed += instance.OnRotateX;
                @RotateX.canceled += instance.OnRotateX;
                @RotateZ.started += instance.OnRotateZ;
                @RotateZ.performed += instance.OnRotateZ;
                @RotateZ.canceled += instance.OnRotateZ;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveZ(InputAction.CallbackContext context);
        void OnRotateX(InputAction.CallbackContext context);
        void OnRotateZ(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
