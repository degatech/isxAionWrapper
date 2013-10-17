using LavishScriptAPI;

namespace Aion.isxAion
{
    public class TeleportWindow : AionWindow
    {
        #region Constructors
        public TeleportWindow(LavishScriptObject Obj) : base(Obj)
        {
        }

        public TeleportWindow()
            : base(LavishScript.Objects.GetObject("TeleportWindow"))
        {
            
        }
        #endregion
    }
}