// GENERATED AUTOMATICALLY FROM 'Assets/Input/ChefControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ChefControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ChefControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ChefControls"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""463b321a-4db2-47dd-be92-f9fb8535bee4"",
            ""actions"": [
                {
                    ""name"": ""ChangeTeamLeft"",
                    ""type"": ""Button"",
                    ""id"": ""3fd6a299-0264-4837-a3f7-4f6bd5d8aaeb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeTeamRight"",
                    ""type"": ""Button"",
                    ""id"": ""ae6a3770-608a-4775-88a2-6147807bfc4e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""d9f17c30-a143-4064-a89c-502a633205d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Join"",
                    ""type"": ""Button"",
                    ""id"": ""85f0683f-f0c3-426a-8958-75dd70c6dcfe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""53ff5f7e-2308-498b-9fdd-e05fe874c257"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveCursor"",
                    ""type"": ""Value"",
                    ""id"": ""06518e7a-b6a2-4a58-be1f-b8888c8772c8"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveCursorDpad"",
                    ""type"": ""Value"",
                    ""id"": ""8cebcba0-b958-431a-bc14-f29249f664d3"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cafe0239-c97c-43a4-bb86-0eea1c3bcb38"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ChangeTeamLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1270f96-5ad5-421a-a85b-27cfea2ca88f"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ChangeTeamLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0a85bd4-ce21-4169-b5a5-0f7396dfc212"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""ChangeTeamLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e701f80-6f4f-4f55-8062-f75f928dd3ff"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""ChangeTeamLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f6a2107-a68d-4914-8a2c-e556063c0d6b"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""ChangeTeamLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e80231f-ea40-4ece-b354-2a95f97ef7e8"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ChangeTeamRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27821f3a-298c-4b16-8c13-9c2ad9b72d41"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ChangeTeamRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f20ca562-016a-4497-9fbc-aa22ba341318"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""ChangeTeamRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d0b8f5d-b759-418c-9d3b-71bcf831e76a"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""ChangeTeamRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb95996b-8140-48eb-aa51-46539d1675dc"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""ChangeTeamRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7349430b-e514-4176-a2a6-997c28b32532"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD;KeyboardNum;KeyboardIJKL"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f3355a5-4fab-4045-9b0d-65f48d001c03"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77443c6f-ca6f-45b5-a423-797ef1404650"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55688cb2-1a1f-4e6f-83d5-7d10dbd2c752"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a110c80-25f5-42f9-ae0d-39fd27cefcf0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56a224d2-c894-466d-9144-048cf7eeb694"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de57e54e-7aba-41fc-83f2-701549e5387f"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6617e752-af33-4b57-addc-1053fb265caa"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""636d5fcf-08d5-417a-b454-45492291ce38"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c724dc4-3ace-4a41-a2b1-5a50a790e8f8"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f34cb816-1e4b-4e5b-a5a6-9df2916ff1c8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee3ebba3-71ff-4318-81fb-dd59ad5a8360"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1f12057-a18a-4ebe-8eef-d83379b80115"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""360107c8-4784-4308-b35b-5a5d3f548e3a"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e77c4a96-1b8f-4046-b7f0-b35b3eb9e10e"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""604f3457-53b9-41fa-8cb1-80cd4c248fdb"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd8cef48-f536-4fa4-9676-a134999df074"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1d1040f-dd00-4337-acc7-257cfe4af39e"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""335a82d9-611d-469f-ac13-1400e2930400"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f28fb87-ab30-48b2-b090-b07cf6120861"",
                    ""path"": ""<Keyboard>/rightAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a3e9db3-07d7-463c-af13-941127588256"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""beb0b0d9-5d34-4e31-a053-db4077b0a585"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32724c78-965b-4ae7-9c06-f8301558d19c"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c2e7abc-809d-458e-b7d5-49071f5bc5f2"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00f40931-20ce-4136-b3f2-f5be29f7c6bc"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""304cae92-c6fb-4f26-82aa-6b56c0ae4563"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e1cbe3f-cc53-4f05-86b2-65004c126ee4"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c62f774e-a1e6-4b98-aafa-d1ea5f3423b1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c2d1030-bbe6-4d1f-8f6e-408b64383a83"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bb6b0ed-1916-49b0-a9ec-ec3652dbd336"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a71aee7-c523-4b17-9012-bbb1244a75cd"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c69cc569-a6a4-4501-aec2-fbf71eff2b33"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""886d738c-709e-4bc2-a966-5005179fbd45"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e9275f5-5ca7-41ca-a420-29a82be24361"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee6bb28a-b8d5-4c3f-b6db-8f856b640b54"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc36c1a9-e5e0-4bc5-8b71-14bcae133d62"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d11ec779-6180-4870-be62-525bc7a5885c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88923d4f-7aac-4f11-b627-7a4077cf6faa"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""179c2478-b5ef-464b-b81c-809d4610b46e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67fdcb0c-6e95-4435-8785-7d68326b618a"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b102bd6-b26b-48b1-a13c-4f3556b633b8"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52baf35c-de54-4640-ab16-39a66b5ce7e4"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b6854aa-10b5-4a5b-bb79-765d1186d578"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a0eb765-aaa7-472a-8390-cc2ac5cde548"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e556224-add7-470b-aeab-c3c747372fd7"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a53e094-0942-49f5-b503-990eeb7a4c76"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""b674ecf9-d9bc-4c40-87a0-f5ad39e8d345"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""60b09781-a234-4f96-bc37-490ae3956354"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ee3c75ad-7a56-491c-8ffa-09b9662b45ce"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f1810503-0ad5-4378-8569-43b1d9d472ec"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""53f431ec-2ecd-419a-ae48-eff011d18bf1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""IJKL"",
                    ""id"": ""ea137ce4-d14a-46f8-8187-b09552bc758e"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b70a4d66-6414-45a6-a24b-b0c04a300d35"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""69881ea5-23eb-4caf-bfc4-0ea047173cef"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5655516c-46a8-4478-9ee2-c00a7fde313f"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""31b99f4c-84a9-4870-ae27-e1fb214f8fd0"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Num"",
                    ""id"": ""fadd6182-7a4c-4831-b94c-83422543b79e"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0a48afcd-c137-45ac-9d16-a9adf902cd7a"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""69ab290e-daf3-44a2-a334-34b7bd576e9b"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""284e5e02-c93a-40ee-9515-8a94ff31202e"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""12e4ab67-57f1-427e-ba54-bb5b8634de22"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""MoveCursorDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7253aa8f-8381-4bde-8481-783d27614eb3"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adb19418-2638-44dc-8cac-f84e6fed2f5d"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c75121d9-11fc-4431-a354-4239effad7d2"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ccc8cf2-ca62-478c-b17c-8b7ffa043b0d"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a0cd868-102e-409c-b502-f89a2d53cf80"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Ingame"",
            ""id"": ""3adf9f16-1260-4c9d-82dc-41c3961a53ba"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""81e001f2-d0c9-4b5b-958c-505c90a35c44"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveDpad"",
                    ""type"": ""Value"",
                    ""id"": ""cc35633f-b5b3-490b-8bb4-8dbe755dfccd"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""22eacf31-9210-42d9-8529-68c5a1b0d726"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Take"",
                    ""type"": ""Button"",
                    ""id"": ""935fd52c-5cb9-49a4-853b-a35117ed1a88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""aee577f2-3029-4a1c-9786-dd03ad5ba88b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThrowPress"",
                    ""type"": ""Button"",
                    ""id"": ""83114928-12f1-4006-96e8-1c2cd279dff7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ThrowRelease"",
                    ""type"": ""Button"",
                    ""id"": ""6570f3bd-3a73-48e3-90c2-a2bead98bddf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""SpecialPress"",
                    ""type"": ""Button"",
                    ""id"": ""afb910c9-978b-4b87-932e-79bf8602541b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""SpecialRelease"",
                    ""type"": ""Button"",
                    ""id"": ""5a59adc0-a2e9-4e04-b550-f42e2f0af7bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""809e7133-2413-4ec2-92a3-eba7f433aa4e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""654a85a2-87e9-45a8-b40d-d01d5fed7b2e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abcff7eb-5ad4-4f29-9ee6-148f51da9a24"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f0f7d51-de8f-4f11-9229-a452bc6e9886"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1528dd1d-4feb-4e78-81b6-aabc3a4a82d9"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""417b8f93-1903-43e7-bc06-e461e266f011"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98db7e4c-82f6-47dd-82c4-1816e0a5b2c8"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ThrowPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6ad969e-c09e-404a-8ed3-4ab386d67c36"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""ThrowPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""165fff8f-1ac1-47d6-8e1f-d57379a343f0"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""ThrowPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdcf3c3b-1c51-4d66-ba40-d709a3bd1ffb"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""ThrowPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b01edba1-ff8c-475d-bf70-0b0f1c8157e4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Take"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03e2c328-e3b1-43b0-a936-aba12f0c70df"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Take"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45acb278-009a-415d-94bd-cbd179019f29"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Take"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fd9a72e-a5f6-4d7d-830d-380a22471798"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Take"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34986f09-2966-43ce-a6ec-838b004e3049"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SpecialPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfeb39e1-3866-4ced-81b1-f6d669769855"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""SpecialPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcfb0a26-0367-452d-870b-caf528001a09"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""SpecialPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""611bf9bb-2d49-41b6-8529-842ae8d3b9fb"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""SpecialPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcbeeb9f-8501-48b8-9352-0f2c733e12c5"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ThrowRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe324ca6-3e34-4c3f-9d51-17138fdca32d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""ThrowRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60524d28-dc9d-4ff1-a788-11f0aa62360b"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""ThrowRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d503fbaf-725e-4f23-80e9-676b554c4cf8"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""ThrowRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b1e9862-d7ae-43bc-a2b4-c7360402aa3b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SpecialRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd356ce8-e79a-4c35-9f8b-cfcdcdaaaee5"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""SpecialRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8677bb9-d390-45dc-996d-103124267068"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""SpecialRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28ca74a0-e5ae-4749-95e4-4fe4977f6baa"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""SpecialRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bdeff8a-46a5-46c2-9004-987a5b9cae0b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f46eba1-1e1c-4ead-b0ba-57ba9ff02fe4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD;KeyboardNum;KeyboardIJKL"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""13f0bd64-b00e-4c24-8e2e-0f5573ef8de0"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""55bc442e-58e2-4ee4-aa8b-3d9724d1330a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5b355610-78bb-4161-a008-f75cb1fdbce9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1f3e3b97-bb3f-42bf-bd83-708eedc10386"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c95e2f1c-6a52-4518-be3e-ea92a4879f51"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""IJKL"",
                    ""id"": ""3c4e6a0a-55e0-4579-b1e7-05a932f20c56"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dda5db00-cb07-497a-9feb-38f885577e2e"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6e9342f4-3a73-4b18-b9a5-982dfce4bbdb"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6d25d9f3-bda9-4db3-975e-eef51122bed7"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f42f0ac1-d8a5-443b-bbcf-a6a11fdc3706"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Num"",
                    ""id"": ""f90303d1-1eb4-48a9-b856-225d6bef42f0"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c8cc0fa6-c389-4444-969e-a8e3cbcb55ed"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""98c57ac9-ebc8-4299-b61c-df32dd6d0925"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e13baebf-f665-4d7f-ae08-4e4bacdcb616"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""623cd9b2-71e4-41ff-94a7-c5612f59da15"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""d5737e21-0bb7-431f-aeb9-74d3412ab2ba"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d47f179e-b551-49f3-a215-8a352b0ce0ca"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""131c49ce-99f4-4804-bbef-6bb393727212"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""329a8931-61bd-4b86-93cd-dfef9bb3831c"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3970b426-b17a-4974-90f4-4634d60a3ffd"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c7c35987-9697-4628-afb9-fd3ec083fc8e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72db7081-c543-4ba6-af10-c33b9e5a5fee"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1cb03e0-2d52-4536-9069-19e2c7886405"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f853ed8-900d-4822-99a4-6522d627c340"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Editor"",
            ""id"": ""4342c111-82c0-4ec2-911e-359a19d255df"",
            ""actions"": [
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""0f8ab0ab-a97d-4795-b7a3-cf0463168b27"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Delete"",
                    ""type"": ""Button"",
                    ""id"": ""b34d6025-afcc-41b8-97cd-422e36b0ad0b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Place"",
                    ""type"": ""Button"",
                    ""id"": ""7acdaec7-b3cb-4165-a0b0-8c60609cda68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Relocate"",
                    ""type"": ""Button"",
                    ""id"": ""8b018f2d-f4e1-40d5-bb80-7e250333c857"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Copy"",
                    ""type"": ""Button"",
                    ""id"": ""a0f115c3-2eb8-446c-baa8-57a33c6aec3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""NavigateObjectMenu"",
                    ""type"": ""Value"",
                    ""id"": ""a70de38e-6efb-4aed-836e-8d926ccccc08"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NavigateTopMenu"",
                    ""type"": ""Value"",
                    ""id"": ""d3e1d29f-476c-4a06-b730-69def98f04c4"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""af8755e0-3450-4294-b629-b4f7f551c0e0"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""a4c7db57-c698-4603-a9cf-646df4f00a27"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShowDirectionSelectionPress"",
                    ""type"": ""Button"",
                    ""id"": ""4c76dd2b-5b73-47bd-98f4-afb390170871"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ShowDirectionSelectionRelease"",
                    ""type"": ""Button"",
                    ""id"": ""1574b705-4ca6-4e5b-98e6-700e7035e7e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""ToggleCameraMode"",
                    ""type"": ""Button"",
                    ""id"": ""6480967b-5826-4e88-8c35-a5edb8ce9a89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveDpad"",
                    ""type"": ""Value"",
                    ""id"": ""57598a40-5ca2-45c6-a73a-72be8aacbe9e"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraDpad"",
                    ""type"": ""Value"",
                    ""id"": ""8571b3a7-8082-4b83-8f98-e023d942fdb6"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActivateObjectMenu"",
                    ""type"": ""Button"",
                    ""id"": ""c32a2945-c142-49d4-96b6-87e75996cfba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ActivateTopMenu"",
                    ""type"": ""Button"",
                    ""id"": ""571b1983-738f-4cb1-bec5-83d49f48e8af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ActivateMoveMode"",
                    ""type"": ""Button"",
                    ""id"": ""ceb42b04-8263-433f-b7fc-91bc74c6da82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ActivateCameraMoveMode"",
                    ""type"": ""Button"",
                    ""id"": ""388d4796-a31c-490d-bf1a-c238cb33b97e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ActivateCameraRotateMode"",
                    ""type"": ""Button"",
                    ""id"": ""da94c0e4-c895-4770-b55b-b97e8d0be4f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""003b13ea-4d09-435b-a1f4-4dbdc85af48b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Delete"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70e4ed59-c130-4ea6-95e9-0d2867c0979c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Delete"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d58e37e-8567-47ac-85c0-acf577872b06"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Delete"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a08dba81-ca57-4eb2-ab01-52aa5e3ff8ba"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Delete"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4237582f-4ba7-4491-8afb-1253f7e6bb94"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Relocate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d146bf6e-5353-44a2-8ce8-195dc2050227"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Relocate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa0af393-9ef3-4556-a397-4606991d2ab8"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Relocate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""461d8fdd-3432-4c9e-8d12-df9e02fd0708"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Relocate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45dae553-6723-4646-a63b-2375ac44c024"",
                    ""path"": ""<Keyboard>/numpadMultiply"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Relocate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd8d886f-c483-46c0-87b9-cdd63bd354de"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Place"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81e1132e-2ffc-4021-93d9-ecb471a52297"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Place"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b6cb6cd-87bb-4fef-962c-c244230e0a93"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Place"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a3c4c50-19c0-46e7-b8c9-021c4d8ef7e6"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Place"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08753a91-5835-4c4f-9098-9cb803f782b1"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Copy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1753642e-d3e1-4238-a0f1-1e87d277fac3"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Copy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea61c1c0-2135-4646-bb11-7231f78f7f8a"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Copy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22e07b65-6571-4446-98d2-ab707d554564"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Copy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""529fa347-6700-47d3-b36c-184d37242fc8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Copy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""c7141a99-08f8-4046-a7ed-fd8fb80874ce"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""af9baaaf-e703-4716-912e-c5017910ca30"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""151bd72a-9a7a-4281-9ad6-9c447d44c9d3"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""IJKL"",
                    ""id"": ""74ac6125-9a24-44bb-860b-05e3953bcffb"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9214d99a-8d4a-4123-bc46-65cf8f1d5649"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b74f90b9-f1d8-4ae8-bfb0-e1bc9b6c6254"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Num"",
                    ""id"": ""b44ebe9d-7acf-4845-805d-77ee8fca6d72"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""249baec7-0fc9-415f-a5d0-be231286ef9d"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""460727e6-6215-46a6-a4eb-57617b3e5fbc"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""6e3be35b-6547-4898-ba24-8031a9f45030"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a1cbd33f-12ee-423b-a99f-4cee7b7dc9e1"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d3b3085b-9899-4663-81cc-54c02ddb1f2f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9640507b-1ad5-4eba-8a93-7929d87f7d74"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""ActivateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0000bba-5509-4c07-8dba-1b1b57f1b357"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""ActivateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ff3dc81-a915-478b-b9af-ffc8816a1b00"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""ActivateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86e4a084-72c3-47e1-840a-790634b191c4"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ToggleCameraMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc2cd9f4-1328-4755-88bb-8b7e73010d3f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""756c4b4e-a249-412f-a312-6cb5548ca628"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""647fc878-d072-47de-81ba-0d99e19e9232"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4cc30c18-07a1-4eba-86fb-ac8b49ca1556"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""aae8b537-bcdd-4c20-bc01-9339203f03a6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""398c26a0-5323-46c8-843c-3d35d7047606"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""IJKL"",
                    ""id"": ""934ac4f4-a270-48da-a0b6-806d36e46f2a"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f57a9050-af79-4434-9b3f-c11c0d4b3103"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""512b9582-7e7d-4fef-bcea-db4d36f4f37c"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bda0b535-604c-421b-bcb2-833c6f1197e5"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""94949098-fc7a-48cd-b1cf-a54a38bbd81c"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Num"",
                    ""id"": ""18711fd6-f246-4632-ae22-003996730044"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4e9e568d-8cda-4e6e-b5af-a9011bfd3a36"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""20d0ea7a-9cc7-474c-9bed-81479c587638"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e58ad319-3afd-49dd-bdb8-565bc5062404"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""804eb16c-db9b-4d69-8905-929ce9af1ffa"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""a2df7cce-7022-4219-8f29-b43da1196032"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""218d3d7b-7033-4c88-bf79-a5565762aca8"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a71764a1-4b45-4d0b-9f91-910a71528fee"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7a258371-cd0e-4f3e-9937-1fe8d7ac9cbe"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""26d54016-5a29-430e-b843-40114d70efab"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""33f0b8ea-750f-459b-856c-813356ef62e9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""IJKL"",
                    ""id"": ""9ff54f5f-0769-48a7-8ad7-20715c350526"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""53f26656-074a-4a63-8607-0f989cb25742"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""20f843f7-a5cd-4720-a2fa-83f6495ca4f7"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7612aca4-863f-48f5-8222-8344631cf901"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""037fbfc0-b205-4838-a6b0-e000dcbac513"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Num"",
                    ""id"": ""576bc577-ef3a-4232-a1b6-5df5a0c49e33"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f5e92393-0dcb-4e70-99af-3fe17b0c3e34"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a493530d-ece1-4cdd-8638-358c4898f3e0"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""20957850-8acd-4820-9ea3-556d4d72516c"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""320f607e-0353-457b-a4fb-8dda094c256c"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""8d588d7b-587d-494a-91c4-6eb687e74981"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraDpad"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4dd8d690-3d4e-4cb5-b400-c67493fb5ba0"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""f4d713cf-8a8f-4296-8b07-576a4c42d1b3"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eefaf7d4-24b8-466d-a1aa-e216b7385530"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5eebba68-bf34-4b1b-b09d-1fbd8c4b7824"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5f61b5be-83af-43aa-a005-aaa87d270954"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d1b025e9-a6cd-4173-a869-82747f2f7eca"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""IJKL"",
                    ""id"": ""b95ddf4c-0772-4858-8c2b-192cc28edf8a"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""34182c94-69d2-4f99-9d5c-7fb4bc88e4e5"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dde22cb9-1996-4774-ad42-a402acf3ed63"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d76d078a-6c91-4275-abaa-0bf015893b82"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""81eb77b9-3677-44b6-a8f9-940a4250beca"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Num"",
                    ""id"": ""77c25193-57be-4163-9243-06110a6a2f46"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""56879d48-3874-44b3-9da5-d7957f2c54a2"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0e5cf760-ac64-46be-b377-e915fe05975f"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7a87b871-a27b-471d-9582-323321b6e871"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2f046dd6-2007-409e-9230-2ef894d371c3"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""88f3e6b6-3588-4966-b3c9-59eeae09dfb1"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""af525432-71c3-40d7-92cc-c1ad355b781c"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""53a0dd09-e43d-4e68-af04-63bddae4b5b2"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5d7d9028-fca8-43ee-a467-d56289bae8a5"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3fa2ef8f-f54f-4022-8de0-e17f18f5e088"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateObjectMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0752abf6-da93-4943-8dfe-4415be266919"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""ActivateMoveMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ede52fe-e2c6-45a7-a501-933c4b5a1bf5"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""ActivateMoveMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae71595b-6fca-474c-bcd0-f7d9e8ab23ee"",
                    ""path"": ""<Keyboard>/numLock"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""ActivateMoveMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7ed5e8a-596f-4f28-a803-817c4083fdbb"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""ActivateCameraMoveMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""225a42e3-b416-4981-8b1d-5e7c9822d19a"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""ActivateCameraMoveMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf399b14-37b6-495d-993d-4a4eeb7a9044"",
                    ""path"": ""<Keyboard>/numpadDivide"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""ActivateCameraMoveMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b66060b7-84bb-4bb8-9abe-0799e888d198"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""ActivateCameraRotateMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""966154c9-5f77-409b-bb8a-6fb47a67b77d"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""ActivateCameraRotateMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55bd9d5c-d129-4360-909e-7d7a1548b8cf"",
                    ""path"": ""<Keyboard>/numpadMultiply"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""ActivateCameraRotateMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76eaf459-987b-468d-ac29-172785a78e06"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShowDirectionSelectionPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37682dc6-c606-4d70-a10a-17e311557bf7"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""ShowDirectionSelectionPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75134cd6-515e-45fc-a8f0-da0eeb3b69c0"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""ShowDirectionSelectionPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e36c6db-1610-4c7e-aeb1-018cf045551d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""ShowDirectionSelectionPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c719dd28-3619-4523-be1d-cfe88b882537"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShowDirectionSelectionRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f7ce93e-42e5-490a-94f0-d76367aefd03"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""ShowDirectionSelectionRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f508d332-f4e7-43fb-81b8-c0932b08eaf5"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""ShowDirectionSelectionRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9919b8e-7191-401b-b139-97fb022da312"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""ShowDirectionSelectionRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""6afb75a3-3664-4c00-9b4c-1fc4f789b870"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5a0f06bb-d5f9-4564-8ebe-a51fef05271f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bcdf15f4-641c-4f1c-ab45-166b95bc6227"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""459173c7-783c-48df-8e57-bf327eb0ef2e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""IJKL"",
                    ""id"": ""ae35fcf6-2495-46fb-a35f-3d01b1d4a5b0"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5067696c-e2a6-4e6a-abb2-567def730cdf"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2b2c1e8f-4718-4268-a67b-197ee4c66135"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""201bde21-2c6a-4dc1-9450-9b2440cde12d"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Num"",
                    ""id"": ""cbac259b-f852-48b9-b822-7573310d33cc"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8abee365-b254-44ac-9cb8-e76582fd90bf"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a855bd17-86cd-4506-8d9a-57c0a1e296bd"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5b68f95f-435f-40d3-97db-8f04329f2459"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""0ec416bf-ce30-4657-a84f-0485e2aedbc3"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b09e2ada-2795-48d0-bc98-62e3911c4d60"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e64e99da-2e6a-4653-b655-2cbb687485b7"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""33eb5421-433f-4296-b63f-66daac411fa6"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a4f05b67-4fc1-4978-83f1-bc182fc3402d"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""ActivateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b504796-8f15-4552-87eb-afba64f3918f"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""ActivateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd0bdcb8-ef27-400f-a8ca-9b2bf6d09128"",
                    ""path"": ""<Keyboard>/numpadMinus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardNum"",
                    ""action"": ""ActivateTopMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardWASD"",
            ""bindingGroup"": ""KeyboardWASD"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KeyboardNum"",
            ""bindingGroup"": ""KeyboardNum"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
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
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KeyboardIJKL"",
            ""bindingGroup"": ""KeyboardIJKL"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""VR"",
            ""bindingGroup"": ""VR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_ChangeTeamLeft = m_Menu.FindAction("ChangeTeamLeft", throwIfNotFound: true);
        m_Menu_ChangeTeamRight = m_Menu.FindAction("ChangeTeamRight", throwIfNotFound: true);
        m_Menu_Start = m_Menu.FindAction("Start", throwIfNotFound: true);
        m_Menu_Join = m_Menu.FindAction("Join", throwIfNotFound: true);
        m_Menu_Click = m_Menu.FindAction("Click", throwIfNotFound: true);
        m_Menu_MoveCursor = m_Menu.FindAction("MoveCursor", throwIfNotFound: true);
        m_Menu_MoveCursorDpad = m_Menu.FindAction("MoveCursorDpad", throwIfNotFound: true);
        // Ingame
        m_Ingame = asset.FindActionMap("Ingame", throwIfNotFound: true);
        m_Ingame_Move = m_Ingame.FindAction("Move", throwIfNotFound: true);
        m_Ingame_MoveDpad = m_Ingame.FindAction("MoveDpad", throwIfNotFound: true);
        m_Ingame_Interact = m_Ingame.FindAction("Interact", throwIfNotFound: true);
        m_Ingame_Take = m_Ingame.FindAction("Take", throwIfNotFound: true);
        m_Ingame_Dash = m_Ingame.FindAction("Dash", throwIfNotFound: true);
        m_Ingame_ThrowPress = m_Ingame.FindAction("ThrowPress", throwIfNotFound: true);
        m_Ingame_ThrowRelease = m_Ingame.FindAction("ThrowRelease", throwIfNotFound: true);
        m_Ingame_SpecialPress = m_Ingame.FindAction("SpecialPress", throwIfNotFound: true);
        m_Ingame_SpecialRelease = m_Ingame.FindAction("SpecialRelease", throwIfNotFound: true);
        m_Ingame_Menu = m_Ingame.FindAction("Menu", throwIfNotFound: true);
        // Editor
        m_Editor = asset.FindActionMap("Editor", throwIfNotFound: true);
        m_Editor_Zoom = m_Editor.FindAction("Zoom", throwIfNotFound: true);
        m_Editor_Delete = m_Editor.FindAction("Delete", throwIfNotFound: true);
        m_Editor_Place = m_Editor.FindAction("Place", throwIfNotFound: true);
        m_Editor_Relocate = m_Editor.FindAction("Relocate", throwIfNotFound: true);
        m_Editor_Copy = m_Editor.FindAction("Copy", throwIfNotFound: true);
        m_Editor_NavigateObjectMenu = m_Editor.FindAction("NavigateObjectMenu", throwIfNotFound: true);
        m_Editor_NavigateTopMenu = m_Editor.FindAction("NavigateTopMenu", throwIfNotFound: true);
        m_Editor_Move = m_Editor.FindAction("Move", throwIfNotFound: true);
        m_Editor_Camera = m_Editor.FindAction("Camera", throwIfNotFound: true);
        m_Editor_ShowDirectionSelectionPress = m_Editor.FindAction("ShowDirectionSelectionPress", throwIfNotFound: true);
        m_Editor_ShowDirectionSelectionRelease = m_Editor.FindAction("ShowDirectionSelectionRelease", throwIfNotFound: true);
        m_Editor_ToggleCameraMode = m_Editor.FindAction("ToggleCameraMode", throwIfNotFound: true);
        m_Editor_MoveDpad = m_Editor.FindAction("MoveDpad", throwIfNotFound: true);
        m_Editor_CameraDpad = m_Editor.FindAction("CameraDpad", throwIfNotFound: true);
        m_Editor_ActivateObjectMenu = m_Editor.FindAction("ActivateObjectMenu", throwIfNotFound: true);
        m_Editor_ActivateTopMenu = m_Editor.FindAction("ActivateTopMenu", throwIfNotFound: true);
        m_Editor_ActivateMoveMode = m_Editor.FindAction("ActivateMoveMode", throwIfNotFound: true);
        m_Editor_ActivateCameraMoveMode = m_Editor.FindAction("ActivateCameraMoveMode", throwIfNotFound: true);
        m_Editor_ActivateCameraRotateMode = m_Editor.FindAction("ActivateCameraRotateMode", throwIfNotFound: true);
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

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_ChangeTeamLeft;
    private readonly InputAction m_Menu_ChangeTeamRight;
    private readonly InputAction m_Menu_Start;
    private readonly InputAction m_Menu_Join;
    private readonly InputAction m_Menu_Click;
    private readonly InputAction m_Menu_MoveCursor;
    private readonly InputAction m_Menu_MoveCursorDpad;
    public struct MenuActions
    {
        private @ChefControls m_Wrapper;
        public MenuActions(@ChefControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChangeTeamLeft => m_Wrapper.m_Menu_ChangeTeamLeft;
        public InputAction @ChangeTeamRight => m_Wrapper.m_Menu_ChangeTeamRight;
        public InputAction @Start => m_Wrapper.m_Menu_Start;
        public InputAction @Join => m_Wrapper.m_Menu_Join;
        public InputAction @Click => m_Wrapper.m_Menu_Click;
        public InputAction @MoveCursor => m_Wrapper.m_Menu_MoveCursor;
        public InputAction @MoveCursorDpad => m_Wrapper.m_Menu_MoveCursorDpad;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @ChangeTeamLeft.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnChangeTeamLeft;
                @ChangeTeamLeft.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnChangeTeamLeft;
                @ChangeTeamLeft.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnChangeTeamLeft;
                @ChangeTeamRight.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnChangeTeamRight;
                @ChangeTeamRight.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnChangeTeamRight;
                @ChangeTeamRight.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnChangeTeamRight;
                @Start.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                @Join.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnJoin;
                @Join.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnJoin;
                @Join.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnJoin;
                @Click.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnClick;
                @MoveCursor.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveCursor;
                @MoveCursor.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveCursor;
                @MoveCursor.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveCursor;
                @MoveCursorDpad.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveCursorDpad;
                @MoveCursorDpad.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveCursorDpad;
                @MoveCursorDpad.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveCursorDpad;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChangeTeamLeft.started += instance.OnChangeTeamLeft;
                @ChangeTeamLeft.performed += instance.OnChangeTeamLeft;
                @ChangeTeamLeft.canceled += instance.OnChangeTeamLeft;
                @ChangeTeamRight.started += instance.OnChangeTeamRight;
                @ChangeTeamRight.performed += instance.OnChangeTeamRight;
                @ChangeTeamRight.canceled += instance.OnChangeTeamRight;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Join.started += instance.OnJoin;
                @Join.performed += instance.OnJoin;
                @Join.canceled += instance.OnJoin;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @MoveCursor.started += instance.OnMoveCursor;
                @MoveCursor.performed += instance.OnMoveCursor;
                @MoveCursor.canceled += instance.OnMoveCursor;
                @MoveCursorDpad.started += instance.OnMoveCursorDpad;
                @MoveCursorDpad.performed += instance.OnMoveCursorDpad;
                @MoveCursorDpad.canceled += instance.OnMoveCursorDpad;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Ingame
    private readonly InputActionMap m_Ingame;
    private IIngameActions m_IngameActionsCallbackInterface;
    private readonly InputAction m_Ingame_Move;
    private readonly InputAction m_Ingame_MoveDpad;
    private readonly InputAction m_Ingame_Interact;
    private readonly InputAction m_Ingame_Take;
    private readonly InputAction m_Ingame_Dash;
    private readonly InputAction m_Ingame_ThrowPress;
    private readonly InputAction m_Ingame_ThrowRelease;
    private readonly InputAction m_Ingame_SpecialPress;
    private readonly InputAction m_Ingame_SpecialRelease;
    private readonly InputAction m_Ingame_Menu;
    public struct IngameActions
    {
        private @ChefControls m_Wrapper;
        public IngameActions(@ChefControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Ingame_Move;
        public InputAction @MoveDpad => m_Wrapper.m_Ingame_MoveDpad;
        public InputAction @Interact => m_Wrapper.m_Ingame_Interact;
        public InputAction @Take => m_Wrapper.m_Ingame_Take;
        public InputAction @Dash => m_Wrapper.m_Ingame_Dash;
        public InputAction @ThrowPress => m_Wrapper.m_Ingame_ThrowPress;
        public InputAction @ThrowRelease => m_Wrapper.m_Ingame_ThrowRelease;
        public InputAction @SpecialPress => m_Wrapper.m_Ingame_SpecialPress;
        public InputAction @SpecialRelease => m_Wrapper.m_Ingame_SpecialRelease;
        public InputAction @Menu => m_Wrapper.m_Ingame_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Ingame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(IngameActions set) { return set.Get(); }
        public void SetCallbacks(IIngameActions instance)
        {
            if (m_Wrapper.m_IngameActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnMove;
                @MoveDpad.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnMoveDpad;
                @MoveDpad.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnMoveDpad;
                @MoveDpad.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnMoveDpad;
                @Interact.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnInteract;
                @Take.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnTake;
                @Take.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnTake;
                @Take.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnTake;
                @Dash.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnDash;
                @ThrowPress.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnThrowPress;
                @ThrowPress.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnThrowPress;
                @ThrowPress.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnThrowPress;
                @ThrowRelease.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnThrowRelease;
                @ThrowRelease.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnThrowRelease;
                @ThrowRelease.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnThrowRelease;
                @SpecialPress.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnSpecialPress;
                @SpecialPress.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnSpecialPress;
                @SpecialPress.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnSpecialPress;
                @SpecialRelease.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnSpecialRelease;
                @SpecialRelease.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnSpecialRelease;
                @SpecialRelease.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnSpecialRelease;
                @Menu.started -= m_Wrapper.m_IngameActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_IngameActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_IngameActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_IngameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveDpad.started += instance.OnMoveDpad;
                @MoveDpad.performed += instance.OnMoveDpad;
                @MoveDpad.canceled += instance.OnMoveDpad;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Take.started += instance.OnTake;
                @Take.performed += instance.OnTake;
                @Take.canceled += instance.OnTake;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @ThrowPress.started += instance.OnThrowPress;
                @ThrowPress.performed += instance.OnThrowPress;
                @ThrowPress.canceled += instance.OnThrowPress;
                @ThrowRelease.started += instance.OnThrowRelease;
                @ThrowRelease.performed += instance.OnThrowRelease;
                @ThrowRelease.canceled += instance.OnThrowRelease;
                @SpecialPress.started += instance.OnSpecialPress;
                @SpecialPress.performed += instance.OnSpecialPress;
                @SpecialPress.canceled += instance.OnSpecialPress;
                @SpecialRelease.started += instance.OnSpecialRelease;
                @SpecialRelease.performed += instance.OnSpecialRelease;
                @SpecialRelease.canceled += instance.OnSpecialRelease;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public IngameActions @Ingame => new IngameActions(this);

    // Editor
    private readonly InputActionMap m_Editor;
    private IEditorActions m_EditorActionsCallbackInterface;
    private readonly InputAction m_Editor_Zoom;
    private readonly InputAction m_Editor_Delete;
    private readonly InputAction m_Editor_Place;
    private readonly InputAction m_Editor_Relocate;
    private readonly InputAction m_Editor_Copy;
    private readonly InputAction m_Editor_NavigateObjectMenu;
    private readonly InputAction m_Editor_NavigateTopMenu;
    private readonly InputAction m_Editor_Move;
    private readonly InputAction m_Editor_Camera;
    private readonly InputAction m_Editor_ShowDirectionSelectionPress;
    private readonly InputAction m_Editor_ShowDirectionSelectionRelease;
    private readonly InputAction m_Editor_ToggleCameraMode;
    private readonly InputAction m_Editor_MoveDpad;
    private readonly InputAction m_Editor_CameraDpad;
    private readonly InputAction m_Editor_ActivateObjectMenu;
    private readonly InputAction m_Editor_ActivateTopMenu;
    private readonly InputAction m_Editor_ActivateMoveMode;
    private readonly InputAction m_Editor_ActivateCameraMoveMode;
    private readonly InputAction m_Editor_ActivateCameraRotateMode;
    public struct EditorActions
    {
        private @ChefControls m_Wrapper;
        public EditorActions(@ChefControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Zoom => m_Wrapper.m_Editor_Zoom;
        public InputAction @Delete => m_Wrapper.m_Editor_Delete;
        public InputAction @Place => m_Wrapper.m_Editor_Place;
        public InputAction @Relocate => m_Wrapper.m_Editor_Relocate;
        public InputAction @Copy => m_Wrapper.m_Editor_Copy;
        public InputAction @NavigateObjectMenu => m_Wrapper.m_Editor_NavigateObjectMenu;
        public InputAction @NavigateTopMenu => m_Wrapper.m_Editor_NavigateTopMenu;
        public InputAction @Move => m_Wrapper.m_Editor_Move;
        public InputAction @Camera => m_Wrapper.m_Editor_Camera;
        public InputAction @ShowDirectionSelectionPress => m_Wrapper.m_Editor_ShowDirectionSelectionPress;
        public InputAction @ShowDirectionSelectionRelease => m_Wrapper.m_Editor_ShowDirectionSelectionRelease;
        public InputAction @ToggleCameraMode => m_Wrapper.m_Editor_ToggleCameraMode;
        public InputAction @MoveDpad => m_Wrapper.m_Editor_MoveDpad;
        public InputAction @CameraDpad => m_Wrapper.m_Editor_CameraDpad;
        public InputAction @ActivateObjectMenu => m_Wrapper.m_Editor_ActivateObjectMenu;
        public InputAction @ActivateTopMenu => m_Wrapper.m_Editor_ActivateTopMenu;
        public InputAction @ActivateMoveMode => m_Wrapper.m_Editor_ActivateMoveMode;
        public InputAction @ActivateCameraMoveMode => m_Wrapper.m_Editor_ActivateCameraMoveMode;
        public InputAction @ActivateCameraRotateMode => m_Wrapper.m_Editor_ActivateCameraRotateMode;
        public InputActionMap Get() { return m_Wrapper.m_Editor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EditorActions set) { return set.Get(); }
        public void SetCallbacks(IEditorActions instance)
        {
            if (m_Wrapper.m_EditorActionsCallbackInterface != null)
            {
                @Zoom.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnZoom;
                @Delete.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnDelete;
                @Delete.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnDelete;
                @Delete.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnDelete;
                @Place.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnPlace;
                @Place.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnPlace;
                @Place.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnPlace;
                @Relocate.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnRelocate;
                @Relocate.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnRelocate;
                @Relocate.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnRelocate;
                @Copy.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnCopy;
                @Copy.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnCopy;
                @Copy.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnCopy;
                @NavigateObjectMenu.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnNavigateObjectMenu;
                @NavigateObjectMenu.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnNavigateObjectMenu;
                @NavigateObjectMenu.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnNavigateObjectMenu;
                @NavigateTopMenu.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnNavigateTopMenu;
                @NavigateTopMenu.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnNavigateTopMenu;
                @NavigateTopMenu.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnNavigateTopMenu;
                @Move.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnMove;
                @Camera.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnCamera;
                @ShowDirectionSelectionPress.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnShowDirectionSelectionPress;
                @ShowDirectionSelectionPress.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnShowDirectionSelectionPress;
                @ShowDirectionSelectionPress.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnShowDirectionSelectionPress;
                @ShowDirectionSelectionRelease.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnShowDirectionSelectionRelease;
                @ShowDirectionSelectionRelease.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnShowDirectionSelectionRelease;
                @ShowDirectionSelectionRelease.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnShowDirectionSelectionRelease;
                @ToggleCameraMode.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnToggleCameraMode;
                @ToggleCameraMode.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnToggleCameraMode;
                @ToggleCameraMode.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnToggleCameraMode;
                @MoveDpad.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnMoveDpad;
                @MoveDpad.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnMoveDpad;
                @MoveDpad.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnMoveDpad;
                @CameraDpad.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnCameraDpad;
                @CameraDpad.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnCameraDpad;
                @CameraDpad.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnCameraDpad;
                @ActivateObjectMenu.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateObjectMenu;
                @ActivateObjectMenu.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateObjectMenu;
                @ActivateObjectMenu.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateObjectMenu;
                @ActivateTopMenu.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateTopMenu;
                @ActivateTopMenu.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateTopMenu;
                @ActivateTopMenu.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateTopMenu;
                @ActivateMoveMode.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateMoveMode;
                @ActivateMoveMode.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateMoveMode;
                @ActivateMoveMode.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateMoveMode;
                @ActivateCameraMoveMode.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateCameraMoveMode;
                @ActivateCameraMoveMode.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateCameraMoveMode;
                @ActivateCameraMoveMode.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateCameraMoveMode;
                @ActivateCameraRotateMode.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateCameraRotateMode;
                @ActivateCameraRotateMode.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateCameraRotateMode;
                @ActivateCameraRotateMode.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnActivateCameraRotateMode;
            }
            m_Wrapper.m_EditorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @Delete.started += instance.OnDelete;
                @Delete.performed += instance.OnDelete;
                @Delete.canceled += instance.OnDelete;
                @Place.started += instance.OnPlace;
                @Place.performed += instance.OnPlace;
                @Place.canceled += instance.OnPlace;
                @Relocate.started += instance.OnRelocate;
                @Relocate.performed += instance.OnRelocate;
                @Relocate.canceled += instance.OnRelocate;
                @Copy.started += instance.OnCopy;
                @Copy.performed += instance.OnCopy;
                @Copy.canceled += instance.OnCopy;
                @NavigateObjectMenu.started += instance.OnNavigateObjectMenu;
                @NavigateObjectMenu.performed += instance.OnNavigateObjectMenu;
                @NavigateObjectMenu.canceled += instance.OnNavigateObjectMenu;
                @NavigateTopMenu.started += instance.OnNavigateTopMenu;
                @NavigateTopMenu.performed += instance.OnNavigateTopMenu;
                @NavigateTopMenu.canceled += instance.OnNavigateTopMenu;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @ShowDirectionSelectionPress.started += instance.OnShowDirectionSelectionPress;
                @ShowDirectionSelectionPress.performed += instance.OnShowDirectionSelectionPress;
                @ShowDirectionSelectionPress.canceled += instance.OnShowDirectionSelectionPress;
                @ShowDirectionSelectionRelease.started += instance.OnShowDirectionSelectionRelease;
                @ShowDirectionSelectionRelease.performed += instance.OnShowDirectionSelectionRelease;
                @ShowDirectionSelectionRelease.canceled += instance.OnShowDirectionSelectionRelease;
                @ToggleCameraMode.started += instance.OnToggleCameraMode;
                @ToggleCameraMode.performed += instance.OnToggleCameraMode;
                @ToggleCameraMode.canceled += instance.OnToggleCameraMode;
                @MoveDpad.started += instance.OnMoveDpad;
                @MoveDpad.performed += instance.OnMoveDpad;
                @MoveDpad.canceled += instance.OnMoveDpad;
                @CameraDpad.started += instance.OnCameraDpad;
                @CameraDpad.performed += instance.OnCameraDpad;
                @CameraDpad.canceled += instance.OnCameraDpad;
                @ActivateObjectMenu.started += instance.OnActivateObjectMenu;
                @ActivateObjectMenu.performed += instance.OnActivateObjectMenu;
                @ActivateObjectMenu.canceled += instance.OnActivateObjectMenu;
                @ActivateTopMenu.started += instance.OnActivateTopMenu;
                @ActivateTopMenu.performed += instance.OnActivateTopMenu;
                @ActivateTopMenu.canceled += instance.OnActivateTopMenu;
                @ActivateMoveMode.started += instance.OnActivateMoveMode;
                @ActivateMoveMode.performed += instance.OnActivateMoveMode;
                @ActivateMoveMode.canceled += instance.OnActivateMoveMode;
                @ActivateCameraMoveMode.started += instance.OnActivateCameraMoveMode;
                @ActivateCameraMoveMode.performed += instance.OnActivateCameraMoveMode;
                @ActivateCameraMoveMode.canceled += instance.OnActivateCameraMoveMode;
                @ActivateCameraRotateMode.started += instance.OnActivateCameraRotateMode;
                @ActivateCameraRotateMode.performed += instance.OnActivateCameraRotateMode;
                @ActivateCameraRotateMode.canceled += instance.OnActivateCameraRotateMode;
            }
        }
    }
    public EditorActions @Editor => new EditorActions(this);
    private int m_KeyboardWASDSchemeIndex = -1;
    public InputControlScheme KeyboardWASDScheme
    {
        get
        {
            if (m_KeyboardWASDSchemeIndex == -1) m_KeyboardWASDSchemeIndex = asset.FindControlSchemeIndex("KeyboardWASD");
            return asset.controlSchemes[m_KeyboardWASDSchemeIndex];
        }
    }
    private int m_KeyboardNumSchemeIndex = -1;
    public InputControlScheme KeyboardNumScheme
    {
        get
        {
            if (m_KeyboardNumSchemeIndex == -1) m_KeyboardNumSchemeIndex = asset.FindControlSchemeIndex("KeyboardNum");
            return asset.controlSchemes[m_KeyboardNumSchemeIndex];
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
    private int m_KeyboardIJKLSchemeIndex = -1;
    public InputControlScheme KeyboardIJKLScheme
    {
        get
        {
            if (m_KeyboardIJKLSchemeIndex == -1) m_KeyboardIJKLSchemeIndex = asset.FindControlSchemeIndex("KeyboardIJKL");
            return asset.controlSchemes[m_KeyboardIJKLSchemeIndex];
        }
    }
    private int m_VRSchemeIndex = -1;
    public InputControlScheme VRScheme
    {
        get
        {
            if (m_VRSchemeIndex == -1) m_VRSchemeIndex = asset.FindControlSchemeIndex("VR");
            return asset.controlSchemes[m_VRSchemeIndex];
        }
    }
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    public interface IMenuActions
    {
        void OnChangeTeamLeft(InputAction.CallbackContext context);
        void OnChangeTeamRight(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnJoin(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnMoveCursor(InputAction.CallbackContext context);
        void OnMoveCursorDpad(InputAction.CallbackContext context);
    }
    public interface IIngameActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveDpad(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnTake(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnThrowPress(InputAction.CallbackContext context);
        void OnThrowRelease(InputAction.CallbackContext context);
        void OnSpecialPress(InputAction.CallbackContext context);
        void OnSpecialRelease(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
    public interface IEditorActions
    {
        void OnZoom(InputAction.CallbackContext context);
        void OnDelete(InputAction.CallbackContext context);
        void OnPlace(InputAction.CallbackContext context);
        void OnRelocate(InputAction.CallbackContext context);
        void OnCopy(InputAction.CallbackContext context);
        void OnNavigateObjectMenu(InputAction.CallbackContext context);
        void OnNavigateTopMenu(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnShowDirectionSelectionPress(InputAction.CallbackContext context);
        void OnShowDirectionSelectionRelease(InputAction.CallbackContext context);
        void OnToggleCameraMode(InputAction.CallbackContext context);
        void OnMoveDpad(InputAction.CallbackContext context);
        void OnCameraDpad(InputAction.CallbackContext context);
        void OnActivateObjectMenu(InputAction.CallbackContext context);
        void OnActivateTopMenu(InputAction.CallbackContext context);
        void OnActivateMoveMode(InputAction.CallbackContext context);
        void OnActivateCameraMoveMode(InputAction.CallbackContext context);
        void OnActivateCameraRotateMode(InputAction.CallbackContext context);
    }
}
