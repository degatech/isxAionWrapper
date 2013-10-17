using LavishScriptAPI;

namespace Aion.isxAion
{
    public class CharSelectWindow : AionWindow
    {
        #region Constructors
        public CharSelectWindow(LavishScriptObject Obj) : base(Obj)
        {
        }

        public CharSelectWindow()
            : base(LavishScript.Objects.GetObject("CharSelectWindow"))
        {
            
        }
        #endregion

        #region Members
        #region isxAion-20130130.1792
        public AionButton Start
        {
            get { return new AionButton(GetMember("Start")); }
        }

        public AionButton Character(int index)
        {
            return new AionButton(GetMember("Character", index.ToString()));
        }

        public AionButton Character(string name)
        {
            return new AionButton(GetMember("Character", name));
        }
        #endregion
        #endregion
    }
}