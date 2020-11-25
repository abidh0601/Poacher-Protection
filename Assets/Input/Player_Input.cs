// GENERATED AUTOMATICALLY FROM 'Assets/Input/Player_Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player_Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player_Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player_Input"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""a7d20d1a-e8cc-41d9-9574-9a31232237dd"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2f7d2bef-7168-43fc-a438-4002af181a08"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""xLook"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5a36a8f3-999c-426a-84b9-9cdf573d5c3c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""yLook"",
                    ""type"": ""PassThrough"",
                    ""id"": ""abeabab8-03d8-434e-a131-e9f562b12137"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlaceFence"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dc1ada77-5b34-40e6-b6a9-fbf640317106"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""mouseClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4748a119-b27b-4537-83ed-652833fba7e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""deleteMode"",
                    ""type"": ""PassThrough"",
                    ""id"": ""76147fb1-e1b0-42fc-ac31-1cf7c186541f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""9e9c2515-647f-43ab-a504-bf29e8077d8e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bd89902f-cb99-4a49-a947-fb52943b7767"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9499b26b-d27d-4d95-9ab3-13566a8f47f1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""PS4"",
                    ""id"": ""41789052-c717-4b5b-ba40-38875627649a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""21909553-85a8-4bf9-8882-7500d4f2de26"",
                    ""path"": ""<DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5f2a7ea5-475c-40f5-b85c-bcfb7ab86e62"",
                    ""path"": ""<DualShockGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Generic"",
                    ""id"": ""6ff41701-8ab3-453b-8d47-026abc28f317"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""77364649-3b5d-49a6-b088-3ef4db806bd2"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""11c2f5d6-12b8-4ec4-8115-5f563b760ea1"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Xbox"",
                    ""id"": ""6b02d2fa-0c88-411f-b4c5-e1e6d4be955f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ef891d07-971f-49c3-86ac-bf1699a82db7"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c4c13eab-ebfb-4cad-91b4-ab98ef955e90"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b07c8146-f858-43fd-babe-ddf647526738"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""xLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6ed840c-c92d-443b-9292-350f5fab48a4"",
                    ""path"": ""<XRHMD>/centerEyeRotation/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""xLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b23be343-afed-4b89-93f3-f3c3f4ffd751"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""yLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6839e21-94aa-4c1e-87d1-e291915baf72"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(pressPoint=1)"",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""PlaceFence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e979f41-26dc-47bc-9d86-3c3bf0f1d4f1"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Press(pressPoint=1)"",
                    ""processors"": """",
                    ""groups"": ""Mouse;Touch"",
                    ""action"": ""PlaceFence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6909727d-1bce-4bc5-b35c-a21b149c7a64"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": ""Press(pressPoint=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlaceFence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c70ca856-d457-49b6-a686-be2b0a329932"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": ""Press(pressPoint=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlaceFence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46968ace-158d-41ca-aac2-8eae279bae4e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a63fe830-8762-4e54-a798-f301c8434cca"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""101be47a-c5dc-4173-ba42-a79c7ae38da1"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9de1ab6b-1dae-49e2-a487-f49ff5e28005"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0d897c8-7a6e-4031-946d-f4d585a0dd02"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deleteMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21a548fa-fbd9-45cf-a26c-32b7721c12d7"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deleteMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8c72a44-36f6-4a92-b8fc-ee386ecc0fac"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""deleteMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Screen"",
            ""id"": ""81ab5cdc-0064-40e3-96fe-a349ffe984f0"",
            ""actions"": [
                {
                    ""name"": ""click"",
                    ""type"": ""Button"",
                    ""id"": ""830052aa-893a-4e8d-8f45-eff7560f6cba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""mousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""7d4aecab-9cf2-4d82-955c-273d08a63563"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""adeda6a7-6686-4b20-bba8-70e9259d75a8"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc3cf601-9542-4de8-ac17-63e0210a9e64"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": []
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": []
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_move = m_Player.FindAction("move", throwIfNotFound: true);
        m_Player_xLook = m_Player.FindAction("xLook", throwIfNotFound: true);
        m_Player_yLook = m_Player.FindAction("yLook", throwIfNotFound: true);
        m_Player_PlaceFence = m_Player.FindAction("PlaceFence", throwIfNotFound: true);
        m_Player_mouseClick = m_Player.FindAction("mouseClick", throwIfNotFound: true);
        m_Player_deleteMode = m_Player.FindAction("deleteMode", throwIfNotFound: true);
        // Screen
        m_Screen = asset.FindActionMap("Screen", throwIfNotFound: true);
        m_Screen_click = m_Screen.FindAction("click", throwIfNotFound: true);
        m_Screen_mousePosition = m_Screen.FindAction("mousePosition", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_move;
    private readonly InputAction m_Player_xLook;
    private readonly InputAction m_Player_yLook;
    private readonly InputAction m_Player_PlaceFence;
    private readonly InputAction m_Player_mouseClick;
    private readonly InputAction m_Player_deleteMode;
    public struct PlayerActions
    {
        private @Player_Input m_Wrapper;
        public PlayerActions(@Player_Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_Player_move;
        public InputAction @xLook => m_Wrapper.m_Player_xLook;
        public InputAction @yLook => m_Wrapper.m_Player_yLook;
        public InputAction @PlaceFence => m_Wrapper.m_Player_PlaceFence;
        public InputAction @mouseClick => m_Wrapper.m_Player_mouseClick;
        public InputAction @deleteMode => m_Wrapper.m_Player_deleteMode;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @xLook.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnXLook;
                @xLook.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnXLook;
                @xLook.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnXLook;
                @yLook.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYLook;
                @yLook.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYLook;
                @yLook.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYLook;
                @PlaceFence.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlaceFence;
                @PlaceFence.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlaceFence;
                @PlaceFence.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlaceFence;
                @mouseClick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseClick;
                @mouseClick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseClick;
                @mouseClick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseClick;
                @deleteMode.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDeleteMode;
                @deleteMode.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDeleteMode;
                @deleteMode.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDeleteMode;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @xLook.started += instance.OnXLook;
                @xLook.performed += instance.OnXLook;
                @xLook.canceled += instance.OnXLook;
                @yLook.started += instance.OnYLook;
                @yLook.performed += instance.OnYLook;
                @yLook.canceled += instance.OnYLook;
                @PlaceFence.started += instance.OnPlaceFence;
                @PlaceFence.performed += instance.OnPlaceFence;
                @PlaceFence.canceled += instance.OnPlaceFence;
                @mouseClick.started += instance.OnMouseClick;
                @mouseClick.performed += instance.OnMouseClick;
                @mouseClick.canceled += instance.OnMouseClick;
                @deleteMode.started += instance.OnDeleteMode;
                @deleteMode.performed += instance.OnDeleteMode;
                @deleteMode.canceled += instance.OnDeleteMode;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Screen
    private readonly InputActionMap m_Screen;
    private IScreenActions m_ScreenActionsCallbackInterface;
    private readonly InputAction m_Screen_click;
    private readonly InputAction m_Screen_mousePosition;
    public struct ScreenActions
    {
        private @Player_Input m_Wrapper;
        public ScreenActions(@Player_Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @click => m_Wrapper.m_Screen_click;
        public InputAction @mousePosition => m_Wrapper.m_Screen_mousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Screen; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ScreenActions set) { return set.Get(); }
        public void SetCallbacks(IScreenActions instance)
        {
            if (m_Wrapper.m_ScreenActionsCallbackInterface != null)
            {
                @click.started -= m_Wrapper.m_ScreenActionsCallbackInterface.OnClick;
                @click.performed -= m_Wrapper.m_ScreenActionsCallbackInterface.OnClick;
                @click.canceled -= m_Wrapper.m_ScreenActionsCallbackInterface.OnClick;
                @mousePosition.started -= m_Wrapper.m_ScreenActionsCallbackInterface.OnMousePosition;
                @mousePosition.performed -= m_Wrapper.m_ScreenActionsCallbackInterface.OnMousePosition;
                @mousePosition.canceled -= m_Wrapper.m_ScreenActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_ScreenActionsCallbackInterface = instance;
            if (instance != null)
            {
                @click.started += instance.OnClick;
                @click.performed += instance.OnClick;
                @click.canceled += instance.OnClick;
                @mousePosition.started += instance.OnMousePosition;
                @mousePosition.performed += instance.OnMousePosition;
                @mousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public ScreenActions @Screen => new ScreenActions(this);
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnXLook(InputAction.CallbackContext context);
        void OnYLook(InputAction.CallbackContext context);
        void OnPlaceFence(InputAction.CallbackContext context);
        void OnMouseClick(InputAction.CallbackContext context);
        void OnDeleteMode(InputAction.CallbackContext context);
    }
    public interface IScreenActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
}
