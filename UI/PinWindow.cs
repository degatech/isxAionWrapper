using LavishScriptAPI;

namespace Aion.isxAion
{
    public class PinWindow : AionWindow
    {
        #region Constructors
        public PinWindow(LavishScriptObject Obj) : base(Obj)
        {
        }

        public PinWindow()
            : base(LavishScript.Objects.GetObject("PINWindow"))
        {
            
        }
        #endregion

        #region Members
        #region isxAion-20130130.1792
        /// <summary>
        /// numberButton can be 0-9 or C
        /// </summary>
        public AionButton Number(int numberButton)
        {
            return new AionButton(GetMember("Number", numberButton.ToString()));
        }

        public AionButton OK
        {
            get { return new AionButton(GetMember("OK")); }
        }

        public AionButton Cancel
        {
            get { return new AionButton(GetMember("Cancel")); }
        }
        #endregion
        #endregion
    }
}