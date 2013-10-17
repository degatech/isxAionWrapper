using LavishScriptAPI;

namespace Aion.isxAion
{
    public class ConversationWindow : AionWindow
    {
        #region Constructors
        public ConversationWindow(LavishScriptObject Obj) : base(Obj)
        {
        }

        public ConversationWindow()
            : base(LavishScript.Objects.GetObject("ConversationWindow"))
        {
            
        }
        #endregion

        #region Members
        #region isxAion-20130130.1872
        public int NumResponses
        {
            get { return GetMember<int>("NumResponses"); }
        }

        public AionButton Response(int responseIndex)
        {
            return new AionButton(GetMember("Response", responseIndex.ToString()));
        }

        public AionButton Response(string label)
        {
            return new AionButton(GetMember("Response", label));
        }
        #endregion

        #region isxAion-20130130.1863
        /// <summary>
        /// Number of visible 'buttons'
        /// </summary>
        public int NumButtons
        {
            get { return GetMember<int>("NumButtons"); }
        }

        /// <summary>
        /// ButtonIndex is between 1 and conversationwindow.NumButtons
        /// </summary>
        public AionButton Button(int buttonIndex)
        {
            return new AionButton(GetMember("Button", buttonIndex.ToString()));
        }

        public AionButton Button(string label)
        {
            return new AionButton(GetMember("Button", label));
        }

        public AionUIText Dialog
        {
            get { return new AionUIText(GetMember("Dialog")); }
        }
        #endregion
        #endregion

        #region Methods
        #region isxAion-20130130.1882
        public bool EnableAllButtons()
        {
            return ExecuteMethod("EnableAllButtons");
        }
        #endregion
        #endregion
    }
}