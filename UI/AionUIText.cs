using LavishScriptAPI;

namespace Aion.isxAion
{
    public class AionUIText : AionWidget
    {
        #region Constructors
        public AionUIText(LavishScriptObject Obj)
            : base(Obj)
        {
        }
        #endregion

        #region Members
        #region isxAion-20130130.1378
        /// <summary>
        /// Raw text; no html parsing, etc.
        /// </summary>
        public string Raw
        {
            get { return GetMember<string>("Raw"); }
        }
        #endregion
        #endregion
    }
}