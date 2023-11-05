//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputF/Input.inputactions
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

public partial class @Input: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""5f5a313f-69fc-4dda-bebf-de4fe3d3c7b4"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""Value"",
                    ""id"": ""73a93a39-58d6-4f5d-8662-6cee4bcb4ab7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveZ"",
                    ""type"": ""Value"",
                    ""id"": ""cb140fd2-2aae-4ff5-ae87-7b8c3fd5732f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""57a40cf7-5940-41b5-8eb5-9ec8200ada23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""MoveForwardBack"",
                    ""id"": ""cb3d7855-a9b6-40ce-b7eb-16797cb91ca6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""54f16d75-f44f-412d-985f-ceea927c73b0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0d17dd82-9f43-4857-9a73-4be2ea87d8df"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""MoveRightLeft"",
                    ""id"": ""daba95a5-b0ac-4229-9d1c-d85c10ddd7e0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZ"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""faf14d09-2778-4afc-8805-bf7aed9b9c1f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cd686bf3-9801-4510-ac07-a2c67a749ab2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6ee92257-38bd-4379-9f64-944f9e7f84ee"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Look"",
            ""id"": ""0f8873d7-1577-44c0-85a6-1f984a073ff9"",
            ""actions"": [
                {
                    ""name"": ""MouseX_Axis"",
                    ""type"": ""Value"",
                    ""id"": ""bc9d4f52-df72-46e6-b9eb-103f1b5ba7a5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseY_Axis"",
                    ""type"": ""Value"",
                    ""id"": ""58c6783d-bcae-49ae-af31-ecae12a7720f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f4a39da3-4798-4dce-8b7a-416a36567a3f"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX_Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0f89108-e385-4dce-9c52-8abcd58f399c"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY_Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_MoveX = m_Movement.FindAction("MoveX", throwIfNotFound: true);
        m_Movement_MoveZ = m_Movement.FindAction("MoveZ", throwIfNotFound: true);
        m_Movement_Jump = m_Movement.FindAction("Jump", throwIfNotFound: true);
        // Look
        m_Look = asset.FindActionMap("Look", throwIfNotFound: true);
        m_Look_MouseX_Axis = m_Look.FindAction("MouseX_Axis", throwIfNotFound: true);
        m_Look_MouseY_Axis = m_Look.FindAction("MouseY_Axis", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_MoveX;
    private readonly InputAction m_Movement_MoveZ;
    private readonly InputAction m_Movement_Jump;
    public struct MovementActions
    {
        private @Input m_Wrapper;
        public MovementActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_Movement_MoveX;
        public InputAction @MoveZ => m_Wrapper.m_Movement_MoveZ;
        public InputAction @Jump => m_Wrapper.m_Movement_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @MoveX.started += instance.OnMoveX;
            @MoveX.performed += instance.OnMoveX;
            @MoveX.canceled += instance.OnMoveX;
            @MoveZ.started += instance.OnMoveZ;
            @MoveZ.performed += instance.OnMoveZ;
            @MoveZ.canceled += instance.OnMoveZ;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @MoveX.started -= instance.OnMoveX;
            @MoveX.performed -= instance.OnMoveX;
            @MoveX.canceled -= instance.OnMoveX;
            @MoveZ.started -= instance.OnMoveZ;
            @MoveZ.performed -= instance.OnMoveZ;
            @MoveZ.canceled -= instance.OnMoveZ;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Look
    private readonly InputActionMap m_Look;
    private List<ILookActions> m_LookActionsCallbackInterfaces = new List<ILookActions>();
    private readonly InputAction m_Look_MouseX_Axis;
    private readonly InputAction m_Look_MouseY_Axis;
    public struct LookActions
    {
        private @Input m_Wrapper;
        public LookActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseX_Axis => m_Wrapper.m_Look_MouseX_Axis;
        public InputAction @MouseY_Axis => m_Wrapper.m_Look_MouseY_Axis;
        public InputActionMap Get() { return m_Wrapper.m_Look; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LookActions set) { return set.Get(); }
        public void AddCallbacks(ILookActions instance)
        {
            if (instance == null || m_Wrapper.m_LookActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_LookActionsCallbackInterfaces.Add(instance);
            @MouseX_Axis.started += instance.OnMouseX_Axis;
            @MouseX_Axis.performed += instance.OnMouseX_Axis;
            @MouseX_Axis.canceled += instance.OnMouseX_Axis;
            @MouseY_Axis.started += instance.OnMouseY_Axis;
            @MouseY_Axis.performed += instance.OnMouseY_Axis;
            @MouseY_Axis.canceled += instance.OnMouseY_Axis;
        }

        private void UnregisterCallbacks(ILookActions instance)
        {
            @MouseX_Axis.started -= instance.OnMouseX_Axis;
            @MouseX_Axis.performed -= instance.OnMouseX_Axis;
            @MouseX_Axis.canceled -= instance.OnMouseX_Axis;
            @MouseY_Axis.started -= instance.OnMouseY_Axis;
            @MouseY_Axis.performed -= instance.OnMouseY_Axis;
            @MouseY_Axis.canceled -= instance.OnMouseY_Axis;
        }

        public void RemoveCallbacks(ILookActions instance)
        {
            if (m_Wrapper.m_LookActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ILookActions instance)
        {
            foreach (var item in m_Wrapper.m_LookActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_LookActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public LookActions @Look => new LookActions(this);
    public interface IMovementActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveZ(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ILookActions
    {
        void OnMouseX_Axis(InputAction.CallbackContext context);
        void OnMouseY_Axis(InputAction.CallbackContext context);
    }
}