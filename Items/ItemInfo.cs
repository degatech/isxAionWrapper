using LavishScriptAPI;

namespace Aion.isxAion
{
    public class ItemInfo : LavishScriptObject
    {
        #region Constructors
        public ItemInfo(LavishScriptObject Obj) : base(Obj)
        {
        }
        #endregion

        #region Members

        #region isxAion-20130130.1407
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

        public string LongDescription
        {
            get { return GetMember<string>("LongDescription"); }
        }

        /// <summary>
        /// This MEMBER returns any of the fields found in the "ClientItems" table of the AionInfo.sql3 database located in your 
        /// /innerspace/Extensions/isxAion/ClientData folder.   I suggest http://sqlitebrowser.sourceforge.net for a quick/easy way
        /// to view the contents of AionInfo.sql3.  Also, although the DB contains most of the fields found in the
        /// /innerspace/Extensions/isxAion/ClientData/Aion_ClientItems*.xml files, you still might find those useful as a reference 
	    /// (as they may be easier to read.)
        /// </summary>
        public object GetFieldValue(string fieldName)
        {
            return GetMember<object>("GetFieldValue", fieldName);
        }
        #endregion

        #endregion
    }
}
