using LavishScriptAPI;

namespace Aion.isxAion
{
    public class AbilityInfo : LavishScriptObject
    {
        #region Constructors
        public AbilityInfo(LavishScriptObject Obj)
            : base(Obj)
        {
        }
        #endregion

        #region Members
        #region isxAion-20130130.1099
        public int ID
        {
            get { return GetMember<int>("ID"); }
        }

        public string Name
        {
            get { return GetMember<string>("Name"); }
        }

        public string Description
        {
            get { return GetMember<string>("Description"); }
        }

        /// <summary>
        /// In seconds
        /// </summary>
        public float CastTime
        {
            get { return GetMember<float>("CastTime"); }
        }

        /// <summary>
        /// This MEMBER returns any of the fields found in the "ClientSkills" table of the AionInfo.sql3 database located in your 
        /// /innerspace/Extensions/isxAion/ClientData folder.   I suggest http://sqlitebrowser.sourceforge.net for a quick/easy way
        /// to view the contents of AionInfo.sql3.  Also, although the DB does not contain all of the fields found in the
        /// /innerspace/Extensions/isxAion/ClientData/Aion_ClientSkills.xml file, you still might find it useful as a reference (as it would be 
        /// easier to read.
        /// </summary>
        public object GetFieldValue(string fieldName)
        {
            return GetMember<object>("GetFieldValue", fieldName);
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
