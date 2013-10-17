using LavishScriptAPI;

namespace Aion.isxAion
{
    public class Ability : AbilityInfo
    {
        #region Constructors
        public Ability(LavishScriptObject obj) : base(obj)
        {
            
        }
        #endregion

        #region Members
        #region isxAion-20130130.1162
        /// <summary>
        /// This is the level of the ability, not the level at which you receive the ability.
        /// </summary>
        public int Level
        {
            get { return GetMember<int>("Level"); }
        }
        #endregion

        #region isxAion-20130130.0949

        /// <summary>
        /// In seconds.
        /// </summary>
        public float Cooldown
        {
            get { return GetMember<float>("Cooldown"); }
        }

        public bool IsReady
        {
            get { return GetMember<bool>("IsReady"); }
        }

        /// <summary>
        /// In seconds.
        /// </summary>
        public float ReadyIn
        {
            get { return GetMember<float>("ReadyIn"); }
        }
        #endregion
        #endregion

        #region Methods
        #region isxAion-20130130.1015
        #endregion

        #region isxAion-20130130.0949
        /// <summary>
        /// If you try to 'Use' an ability that is not ready, isxAion will do nothing.
        /// </summary>
        public bool Use()
        {
            return ExecuteMethod("Use");
        }
        #endregion
        #endregion
    }
}
