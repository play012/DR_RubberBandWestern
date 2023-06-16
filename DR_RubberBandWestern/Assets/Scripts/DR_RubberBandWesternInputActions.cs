//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/Scripts/DR_RubberBandWestern.inputactions
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

public partial class @DR_RubberBandWesternInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DR_RubberBandWesternInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DR_RubberBandWestern"",
    ""maps"": [
        {
            ""name"": ""DR_RubberBandWestern"",
            ""id"": ""98444973-6ac9-4d84-be62-d6bdd7344c29"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""b67c38e3-d8a0-4ad2-b40d-d3adec2a09e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""30e16cb0-3280-4b44-9d13-4757f5b00b61"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a0efb4ba-9665-45fd-b43c-fe58eb7d81b6"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e6e10ac-cbee-4554-80fb-7fb44aea5ab8"",
                    ""path"": ""<XRController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // DR_RubberBandWestern
        m_DR_RubberBandWestern = asset.FindActionMap("DR_RubberBandWestern", throwIfNotFound: true);
        m_DR_RubberBandWestern_Shoot = m_DR_RubberBandWestern.FindAction("Shoot", throwIfNotFound: true);
        m_DR_RubberBandWestern_Reload = m_DR_RubberBandWestern.FindAction("Reload", throwIfNotFound: true);
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

    // DR_RubberBandWestern
    private readonly InputActionMap m_DR_RubberBandWestern;
    private List<IDR_RubberBandWesternActions> m_DR_RubberBandWesternActionsCallbackInterfaces = new List<IDR_RubberBandWesternActions>();
    private readonly InputAction m_DR_RubberBandWestern_Shoot;
    private readonly InputAction m_DR_RubberBandWestern_Reload;
    public struct DR_RubberBandWesternActions
    {
        private @DR_RubberBandWesternInputActions m_Wrapper;
        public DR_RubberBandWesternActions(@DR_RubberBandWesternInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_DR_RubberBandWestern_Shoot;
        public InputAction @Reload => m_Wrapper.m_DR_RubberBandWestern_Reload;
        public InputActionMap Get() { return m_Wrapper.m_DR_RubberBandWestern; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DR_RubberBandWesternActions set) { return set.Get(); }
        public void AddCallbacks(IDR_RubberBandWesternActions instance)
        {
            if (instance == null || m_Wrapper.m_DR_RubberBandWesternActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DR_RubberBandWesternActionsCallbackInterfaces.Add(instance);
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @Reload.started += instance.OnReload;
            @Reload.performed += instance.OnReload;
            @Reload.canceled += instance.OnReload;
        }

        private void UnregisterCallbacks(IDR_RubberBandWesternActions instance)
        {
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @Reload.started -= instance.OnReload;
            @Reload.performed -= instance.OnReload;
            @Reload.canceled -= instance.OnReload;
        }

        public void RemoveCallbacks(IDR_RubberBandWesternActions instance)
        {
            if (m_Wrapper.m_DR_RubberBandWesternActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDR_RubberBandWesternActions instance)
        {
            foreach (var item in m_Wrapper.m_DR_RubberBandWesternActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DR_RubberBandWesternActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DR_RubberBandWesternActions @DR_RubberBandWestern => new DR_RubberBandWesternActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
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
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IDR_RubberBandWesternActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
    }
}