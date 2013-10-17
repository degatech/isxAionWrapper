using LavishScriptAPI;

namespace Aion.isxAion
{
    public class Group : LavishScriptObject
    {
        #region Constructors
        public Group(LavishScriptObject obj) : base(obj)
        {
            
        }
        #endregion

        #region Members
        #region isxAion-20130130.0975
        public int Size
        {
            get { return GetMember<int>("Size"); }
        }

        public uint LeaderID
        {
            get { return GetMember<uint>("LeaderID"); }
        }

        public Entity Leader
        {
            get { return new Entity(GetMember("Leader")); }
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
