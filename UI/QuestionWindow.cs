using LavishScriptAPI;

namespace Aion.isxAion
{
    public class QuestionWindow : LavishScriptObject
    {
        #region Constructors
        public QuestionWindow(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public QuestionWindow()
            : base(LavishScript.Objects.GetObject("QuestionWindow"))
        {
        }
        #endregion

        #region Members
        #region isxAion-20130130.1378
        public AionButton Button1
        {
            get { return new AionButton(GetMember("Button1")); }
        }

        public AionButton Button2
        {
            get { return new AionButton(GetMember("Button2")); }
        }

        public AionUIText Text
        {
            get { return new AionUIText(GetMember("Text")); }
        }
        #endregion
        #endregion
    }
}