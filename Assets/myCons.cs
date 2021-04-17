// GENERATED AUTOMATICALLY FROM 'Assets/myCons.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MyCons : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MyCons()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""myCons"",
    ""maps"": [
        {
            ""name"": ""hackCons"",
            ""id"": ""c4c1df0d-3a98-4e3d-b62a-a821e945926b"",
            ""actions"": [
                {
                    ""name"": ""TurnClockwise"",
                    ""type"": ""Button"",
                    ""id"": ""22a8ceb6-6fd9-4374-b7b4-207ffadef480"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TurnCounterClockwise"",
                    ""type"": ""Button"",
                    ""id"": ""ddd72b43-4b80-48cf-9f3a-a8ccf7425168"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RingIn"",
                    ""type"": ""Button"",
                    ""id"": ""99025342-b769-4e73-8f7c-68acf84c294e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RingOut"",
                    ""type"": ""Button"",
                    ""id"": ""c4581366-7eee-4005-b5d6-c576752e2a3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1819bf79-c807-45e2-a8dc-3c2034cca626"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd99298d-7091-4e0f-a1dd-fd3ed3eed385"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurnCounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f18c01b6-c300-43be-83df-aa8e3041129f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RingIn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1a5883a-3cb2-44c1-a6a6-c7d291f1001d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RingOut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // hackCons
        m_hackCons = asset.FindActionMap("hackCons", throwIfNotFound: true);
        m_hackCons_TurnClockwise = m_hackCons.FindAction("TurnClockwise", throwIfNotFound: true);
        m_hackCons_TurnCounterClockwise = m_hackCons.FindAction("TurnCounterClockwise", throwIfNotFound: true);
        m_hackCons_RingIn = m_hackCons.FindAction("RingIn", throwIfNotFound: true);
        m_hackCons_RingOut = m_hackCons.FindAction("RingOut", throwIfNotFound: true);
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

    // hackCons
    private readonly InputActionMap m_hackCons;
    private IHackConsActions m_HackConsActionsCallbackInterface;
    private readonly InputAction m_hackCons_TurnClockwise;
    private readonly InputAction m_hackCons_TurnCounterClockwise;
    private readonly InputAction m_hackCons_RingIn;
    private readonly InputAction m_hackCons_RingOut;
    public struct HackConsActions
    {
        private @MyCons m_Wrapper;
        public HackConsActions(@MyCons wrapper) { m_Wrapper = wrapper; }
        public InputAction @TurnClockwise => m_Wrapper.m_hackCons_TurnClockwise;
        public InputAction @TurnCounterClockwise => m_Wrapper.m_hackCons_TurnCounterClockwise;
        public InputAction @RingIn => m_Wrapper.m_hackCons_RingIn;
        public InputAction @RingOut => m_Wrapper.m_hackCons_RingOut;
        public InputActionMap Get() { return m_Wrapper.m_hackCons; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HackConsActions set) { return set.Get(); }
        public void SetCallbacks(IHackConsActions instance)
        {
            if (m_Wrapper.m_HackConsActionsCallbackInterface != null)
            {
                @TurnClockwise.started -= m_Wrapper.m_HackConsActionsCallbackInterface.OnTurnClockwise;
                @TurnClockwise.performed -= m_Wrapper.m_HackConsActionsCallbackInterface.OnTurnClockwise;
                @TurnClockwise.canceled -= m_Wrapper.m_HackConsActionsCallbackInterface.OnTurnClockwise;
                @TurnCounterClockwise.started -= m_Wrapper.m_HackConsActionsCallbackInterface.OnTurnCounterClockwise;
                @TurnCounterClockwise.performed -= m_Wrapper.m_HackConsActionsCallbackInterface.OnTurnCounterClockwise;
                @TurnCounterClockwise.canceled -= m_Wrapper.m_HackConsActionsCallbackInterface.OnTurnCounterClockwise;
                @RingIn.started -= m_Wrapper.m_HackConsActionsCallbackInterface.OnRingIn;
                @RingIn.performed -= m_Wrapper.m_HackConsActionsCallbackInterface.OnRingIn;
                @RingIn.canceled -= m_Wrapper.m_HackConsActionsCallbackInterface.OnRingIn;
                @RingOut.started -= m_Wrapper.m_HackConsActionsCallbackInterface.OnRingOut;
                @RingOut.performed -= m_Wrapper.m_HackConsActionsCallbackInterface.OnRingOut;
                @RingOut.canceled -= m_Wrapper.m_HackConsActionsCallbackInterface.OnRingOut;
            }
            m_Wrapper.m_HackConsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TurnClockwise.started += instance.OnTurnClockwise;
                @TurnClockwise.performed += instance.OnTurnClockwise;
                @TurnClockwise.canceled += instance.OnTurnClockwise;
                @TurnCounterClockwise.started += instance.OnTurnCounterClockwise;
                @TurnCounterClockwise.performed += instance.OnTurnCounterClockwise;
                @TurnCounterClockwise.canceled += instance.OnTurnCounterClockwise;
                @RingIn.started += instance.OnRingIn;
                @RingIn.performed += instance.OnRingIn;
                @RingIn.canceled += instance.OnRingIn;
                @RingOut.started += instance.OnRingOut;
                @RingOut.performed += instance.OnRingOut;
                @RingOut.canceled += instance.OnRingOut;
            }
        }
    }
    public HackConsActions @hackCons => new HackConsActions(this);
    public interface IHackConsActions
    {
        void OnTurnClockwise(InputAction.CallbackContext context);
        void OnTurnCounterClockwise(InputAction.CallbackContext context);
        void OnRingIn(InputAction.CallbackContext context);
        void OnRingOut(InputAction.CallbackContext context);
    }
}
