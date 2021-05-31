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
                    ""expectedControlType"": ""Button"",
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
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""e95b2b11-6d8a-44ce-844d-534463e55b0e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveW"",
                    ""type"": ""Button"",
                    ""id"": ""b7b8c8f5-9c9e-4c9f-80f7-e51421517a82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveA"",
                    ""type"": ""Button"",
                    ""id"": ""d735aa00-6ee6-4c40-aae5-990d2b85431d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveS"",
                    ""type"": ""Button"",
                    ""id"": ""466ab4e7-3c5a-4bca-b0df-58ded440e104"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveD"",
                    ""type"": ""Button"",
                    ""id"": ""9cb858f1-9981-43d3-9707-76a8e08d3a88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""4922582b-6920-4e09-a701-f48974796979"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""f475b193-1586-43fc-b90e-a8ebdb6b0c7c"",
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
                    ""name"": ""X"",
                    ""id"": ""0361029f-c2c5-4753-8df6-53def870bd73"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c1355b03-2c77-4169-8c45-d7b0550052ab"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6e1b22a5-a269-44d1-92c8-88e0f7c56c1e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                    ""name"": ""Z"",
                    ""id"": ""ef5ddd54-ddff-4090-946e-f309f05fbe4d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZ"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e857d3de-1569-4b9a-8cdf-edc0691cda05"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6b11945b-dcac-4acd-9af5-00678e37cb0d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                },
                {
                    ""name"": """",
                    ""id"": ""34f39089-efd4-43c1-a82d-b5232ce10bd5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b3166679-c000-4156-a304-c301eb1e66ef"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81278712-c17b-40b6-8130-7f18206cf98d"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d154070b-ab79-45c0-b745-fa74c98ec98f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveW"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85a06506-10e5-450b-99eb-fe423ad2685c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7124ae8-6c61-4ae8-98f9-a8f511fbd290"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd3b2f74-dde2-45e6-8d40-3da235d68c47"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a128f58-8ac4-41ae-bd33-90b381e112c8"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e258b3dd-610b-4714-949f-176c9059b54c"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54173a59-21fe-40c3-9fa6-5a16fb2dc6a7"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Exit"",
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
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
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
        m_Gameplay_Dash = m_Gameplay.FindAction("Dash", throwIfNotFound: true);
        m_Gameplay_MoveW = m_Gameplay.FindAction("MoveW", throwIfNotFound: true);
        m_Gameplay_MoveA = m_Gameplay.FindAction("MoveA", throwIfNotFound: true);
        m_Gameplay_MoveS = m_Gameplay.FindAction("MoveS", throwIfNotFound: true);
        m_Gameplay_MoveD = m_Gameplay.FindAction("MoveD", throwIfNotFound: true);
        m_Gameplay_Mouse = m_Gameplay.FindAction("Mouse", throwIfNotFound: true);
        m_Gameplay_Exit = m_Gameplay.FindAction("Exit", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_Dash;
    private readonly InputAction m_Gameplay_MoveW;
    private readonly InputAction m_Gameplay_MoveA;
    private readonly InputAction m_Gameplay_MoveS;
    private readonly InputAction m_Gameplay_MoveD;
    private readonly InputAction m_Gameplay_Mouse;
    private readonly InputAction m_Gameplay_Exit;
    public struct GameplayActions
    {
        private @PlayerInput m_Wrapper;
        public GameplayActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_Gameplay_MoveX;
        public InputAction @MoveZ => m_Wrapper.m_Gameplay_MoveZ;
        public InputAction @RotateX => m_Wrapper.m_Gameplay_RotateX;
        public InputAction @RotateZ => m_Wrapper.m_Gameplay_RotateZ;
        public InputAction @Fire => m_Wrapper.m_Gameplay_Fire;
        public InputAction @Dash => m_Wrapper.m_Gameplay_Dash;
        public InputAction @MoveW => m_Wrapper.m_Gameplay_MoveW;
        public InputAction @MoveA => m_Wrapper.m_Gameplay_MoveA;
        public InputAction @MoveS => m_Wrapper.m_Gameplay_MoveS;
        public InputAction @MoveD => m_Wrapper.m_Gameplay_MoveD;
        public InputAction @Mouse => m_Wrapper.m_Gameplay_Mouse;
        public InputAction @Exit => m_Wrapper.m_Gameplay_Exit;
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
                @Dash.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                @MoveW.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveW;
                @MoveW.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveW;
                @MoveW.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveW;
                @MoveA.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveA;
                @MoveA.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveA;
                @MoveA.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveA;
                @MoveS.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveS;
                @MoveS.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveS;
                @MoveS.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveS;
                @MoveD.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveD;
                @MoveD.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveD;
                @MoveD.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveD;
                @Mouse.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMouse;
                @Exit.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnExit;
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
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @MoveW.started += instance.OnMoveW;
                @MoveW.performed += instance.OnMoveW;
                @MoveW.canceled += instance.OnMoveW;
                @MoveA.started += instance.OnMoveA;
                @MoveA.performed += instance.OnMoveA;
                @MoveA.canceled += instance.OnMoveA;
                @MoveS.started += instance.OnMoveS;
                @MoveS.performed += instance.OnMoveS;
                @MoveS.canceled += instance.OnMoveS;
                @MoveD.started += instance.OnMoveD;
                @MoveD.performed += instance.OnMoveD;
                @MoveD.canceled += instance.OnMoveD;
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
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
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveZ(InputAction.CallbackContext context);
        void OnRotateX(InputAction.CallbackContext context);
        void OnRotateZ(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnMoveW(InputAction.CallbackContext context);
        void OnMoveA(InputAction.CallbackContext context);
        void OnMoveS(InputAction.CallbackContext context);
        void OnMoveD(InputAction.CallbackContext context);
        void OnMouse(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
}
