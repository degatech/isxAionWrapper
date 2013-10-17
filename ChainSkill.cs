using LavishScriptAPI;

namespace Aion.isxAion
{
    public class ChainSkill : AbilityInfo
    {
        #region Constructors
        public ChainSkill(LavishScriptObject Obj) : base(Obj)
        {
        }
        #endregion

        #region Members
        #region isxAion-20130130.1568
        /// <summary>
        /// The skill is still visible (greyed) but you waited too long or started another chain
        /// </summary>
        public bool IsExpired
        {
            get { return GetMember<bool>("IsExpred"); }
        }

        /// <summary>
        /// The length of time the skill has been visible, in seconds
        /// </summary>
        public float TimeVisible
        {
            get { return GetMember<float>("TimeVisible"); }
        }
        #endregion
        #endregion
    }
}