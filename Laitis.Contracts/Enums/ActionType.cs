using Laitis.Contracts;

namespace Laitis.Contracts.Enums
{
    /// <summary>
    /// Used to identify action type and it's parameters
    /// 
    /// Note: 
    /// all enums should be converted to int, after int to string
    /// all other parameters should be converted to string
    /// 
    /// <seealso cref="CommandAction"/>
    /// </summary>
    public enum ActionType
    {
        /// <summary>
        /// Open file or Program.
        /// Just like Run in windows.
        /// 
        /// Parameters:
        /// 1. (string) Path to app or file
        /// 2. (string) Launch arguments
        /// </summary>
        OpenFile = 0,

        /// <summary>
        /// Close app process.
        /// 
        /// Parameters:
        /// 1. (string) Process Name
        /// </summary>
        CloseApp = 1,

        /// <summary>
        /// Press keyboard hotkeys.
        /// 
        /// Parameters:
        /// 1. (string) Hotkeys https://msdn.microsoft.com/ru-ru/library/system.windows.forms.keys(v=vs.110).aspx
        /// 2. (ButtonAction enum) Button Action Type
        /// 
        /// <seealso cref="ButtonAction"/>
        /// </summary>
        Hotkeys = 2,

        /// <summary>
        /// Move mouse cursor.
        /// 
        /// Parameters:
        /// 1. (int) X
        /// 2. (int) Y
        /// 3. (MouseMoveType enum) Mouse Move Type (point/relative)
        /// 
        /// <seealso cref="MouseMoveType"/>
        /// </summary>
        MouseMove = 3,

        /// <summary>
        /// Pronounce some string.
        /// 
        /// Parameters:
        /// 1. (string) String to pronounce
        /// </summary>
        Say = 4,

        /// <summary>
        /// Type some text.
        /// 
        /// Parameters:
        /// 1. (string) String to type
        /// </summary>
        Type = 5,

        /// <summary>
        /// Play audio sound.
        /// 
        /// Parameters:
        /// 1. (string) Path to audio file
        /// </summary>
        PlayAudio = 6,

        /// <summary>
        /// Open url in default browser or active browser
        /// 
        /// Parameters:
        /// 1. (string) Url
        /// </summary>
        OpenURL = 7,

        /// <summary>
        /// Run script in current active web page in active browser
        /// 
        /// Parameters:
        /// 1. (string) JS script
        /// </summary>
        WebPageScript = 8,

        /// <summary>
        /// Wait some time before next action. Like Thread.Sleep.
        /// 
        /// Parameters:
        /// 1. (int) Milliseconds to wait
        /// </summary>
        Pause = 9,

        /// <summary>
        /// Perform next action if condition is satisfied.
        /// 
        /// Parameters:
        /// 1. (string) Process name
        /// </summary>
        IfProcessSelected = 10,

        /// <summary>
        /// Perform next action if condition is satisfied.
        /// 
        /// Parameters:
        /// 1. (string) Process name
        /// </summary>
        IfProcessExists = 11,

        /// <summary>
        /// Perform next action if condition is satisfied.
        /// 
        /// Parameters:
        /// 1. (string) Part of url
        /// </summary>
        IfWebsiteSelected = 12,

        /// <summary>
        /// Press mouse button
        /// 
        /// Parameters:
        /// 1. (System.Windows.Input.MouseButton enum) Button type https://msdn.microsoft.com/ru-ru/library/system.windows.input.mousebutton(v=vs.110).aspx
        /// 2. (ButtonAction enum) Button Press Type
        /// 
        /// <seealso cref="ButtonAction"/>
        /// </summary>
        MouseButton = 13,

        /// <summary>
        /// Send Http web request 
        /// 
        /// Parameters:
        /// 1. (HttpWebRequestMethod enum) Http Web Request Method (GET or POST)
        /// 2. (string) Url
        /// 
        /// <seealso cref="HttpWebRequestMethod"/>
        /// </summary>
        HttpWebRequest = 14,

        /// <summary>
        /// Set User Variable
        /// 
        /// Parameters:
        /// 1. (string) Variable Name
        /// 2. (string) Variable Value
        /// </summary>
        SetUserVariable = 15,

        /// <summary>
        /// Perform next action if condition is satisfied.
        /// 
        /// Parameters:
        /// 1. (string) Variable Name
        /// 2. (VariableOperator enum) Variable Comparison operator
        /// 3. (string) Variable Value
        /// 
        /// <seealso cref="VariableOperator"/>
        /// </summary>
        IfVariableValue = 16,

        /// <summary>
        /// Perform next action if condition is satisfied.
        /// If vebsite navigation is focused on an element.
        /// 
        /// Parameters:
        /// 1. (string) CSS selector
        /// </summary>
        IfWebsiteNavValue = 17,

        /// <summary>
        /// Show Main Window of a process
        /// 
        /// Parameters:
        /// 1. (string) Process name
        /// 2. (ShowWindowCommandType enum) Show Window Command Type
        /// 
        /// <seealso cref="ShowWindowCommandType"/>
        /// </summary>
        ShowWindow = 18,

        /// <summary>
        /// Focus element on an active webpage of active browser
        /// 
        /// Parameters:
        /// 1. (string) CSS selector
        /// </summary>
        WebPageFocus = 19,

        /// <summary>
        /// Click on element on an active webpage of active browser
        /// 
        /// Parameters:
        /// 1. (string) CSS selector
        /// </summary>
        WebPageClick = 20,

        /// <summary>
        /// Pronounce text on element on an active webpage of active browser
        /// 
        /// Parameters:
        /// 1. (string) CSS selector
        /// </summary>
        WebPageRead = 21,

        /// <summary>
        /// Begin webpage element navigation(selection) on element on an active webpage of active browser
        /// 
        /// Parameters:
        /// 1. (string) CSS selector
        /// 2. (WebPageNavigateAction enum) WebPage Navigate Action
        /// 3. (int) number (of element or how much element to skip up or down)
        /// 
        /// <seealso cref="WebPageNavigateAction"/>
        /// </summary>
        WebPageNavigate = 22,

        /// <summary>
        /// Click on focused element by webpage element navigation(selection)
        /// 
        /// Parameters:
        /// 1. (string) CSS selector of inner element of focused element (if needed, can be empty)
        /// </summary>
        WebPageNavClick = 23,

        /// <summary>
        /// Open popup window on the corner of the screen with webpage.
        /// Webpage will be cutted by provided selector to show most valuable content of the page.
        /// 
        /// Parameters:
        /// 1. (string) Url
        /// 2. (string) CSS Selector
        /// </summary>
        WebPagePopupOpen = 24,

        /// <summary>
        /// Find element by name or action and move cursor on Element in active window or taskbar
        /// https://msdn.microsoft.com/ru-ru/library/ms747327(v=vs.110).aspx
        /// 
        /// Parameters:
        /// 1. (string) Element name
        /// 1. (string) Element action
        /// </summary>
        MouseMoveOn = 25,

        /// <summary>
        /// Else condition part
        /// 
        /// No Parameters
        /// </summary>
        Else = 26,

        /// <summary>
        /// EndIf condition part
        /// 
        /// No Parameters
        /// </summary>
        EndIf = 27,

        /// <summary>
        /// Just text comment. Do nothing.
        /// 
        /// Parameters:
        /// 1. (string) Comment
        /// </summary>
        Comment = 28,

        /// <summary>
        /// Emulate Mouse Scroll
        /// 
        /// Parameters:
        /// 1. (MouseScrollType) Mouse Scroll Type (Vertical or Horizontal)
        /// 2. (int) Mouse Scroll Value (positive/negative value)
        /// 
        /// <seealso cref="MouseScrollType"/>
        /// </summary>
        MouseScroll = 29
    }
}