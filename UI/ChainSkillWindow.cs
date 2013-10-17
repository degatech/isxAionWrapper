using LavishScriptAPI;

namespace Aion.isxAion
{
    public class ChainSkillWindow : AionWindow
    {
        #region Constructors
        public ChainSkillWindow(LavishScriptObject Obj) : base(Obj)
        {
        }

        public ChainSkillWindow()
            : base(LavishScript.Objects.GetObject("ChainSkillWindow"))
        {
            
        }
        #endregion

        #region Members
        #region isxAion-20130130.1568
        /// <summary>
        /// Returns the number of skills currently visible
        /// </summary>
        public int SkillsVisible
        {
            get { return GetMember<int>("SkillsVisible"); }
        }

        /// <summary>
        /// visibleIndex is between 1 and chainskillwindow.SkillsVisible
        /// </summary>
        public ChainSkill Skill(int visibleIndex)
        {
            return new ChainSkill(GetMember("Skill", visibleIndex.ToString()));
        }

        public ChainSkill Skill(bool isID, int skillID)
        {
            return new ChainSkill(GetMember("Skill", isID.ToString(), skillID.ToString()));
        }
        #endregion
        #endregion
    }
}