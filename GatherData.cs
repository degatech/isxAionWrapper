using LavishScriptAPI;

namespace Aion.isxAion
{
    public class GatherData : LavishScriptObject
    {
        #region Constructors
        public GatherData(LavishScriptObject obj)
            : base(obj)
        {
        }
        #endregion

        #region Members
        #region isxAion-1.5.1.7.0151
        public int ID
        {
            get { return GetMember<int>("ID"); }
        }

        public string SourceType
        {
            get { return GetMember<string>("SourceType"); }
        }

        public string HarvestSkill
        {
            get { return GetMember<string>("HarvestSkill"); }
        }

        public int SkillLevel
        {
            get { return GetMember<int>("SkillLevel"); }
        }

        public int NormalRate(int number)
        {
            return GetMember<int>("NormalRate", number.ToString());
        }

        public string Material(int number)
        {
            return GetMember<string>("Material", number.ToString());
        }

        public int HarvestCount
        {
            get { return GetMember<int>("HarvestCount"); }
        }

        public int SuccessAdj
        {
            get { return GetMember<int>("SuccessAdj"); }
        }

        public int FailureAdj
        {
            get { return GetMember<int>("FailureAdj"); }
        }

        public int AerialAdj
        {
            get { return GetMember<int>("AerialAdj"); }
        }

        public int CaptchaRate
        {
            get { return GetMember<int>("CaptchaRate"); }
        }
        #endregion
        #endregion

        #region Methods
        #region isxAion-20130130.1099
        /// <summary>
        /// This method is to allow one lavishscript variable to be reused.
        /// </summary>
        public bool Set(int datatypeID)
        {
            return ExecuteMethod("Set", datatypeID.ToString());
        }
        #endregion
        #endregion
    }
}
