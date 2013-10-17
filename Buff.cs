using LavishScriptAPI;

namespace Aion.isxAion
{
    public class Buff : LavishScriptObject  
    {
        #region Constructors
        public Buff(LavishScriptObject obj) : base(obj)
        {

        }
        #endregion

        #region Members
        #region isxAion-20130130.1099
        public string Name
        {
            get { return GetMember<string>("Name"); }
        }

        public AbilityInfo AbilityInfo
        {
            get { return new AbilityInfo(GetMember("AbilityInfo")); }
        }
        #endregion

        #region isxAion-20130130.0975
        public uint AbilityID
        {
            get { return GetMember<uint>("AbilityID"); }
        }

        public uint CasterID
        {
            get { return GetMember<uint>("CasterID"); }
        }

        public int Type
        {
            get { return GetMember<int>("Type"); }
        }

        /// <summary>
        /// In seconds.
        /// </summary>
        public float Duration
        {
            get { return GetMember<float>("Duration"); }
        }
        #endregion
        #endregion
    }
}
