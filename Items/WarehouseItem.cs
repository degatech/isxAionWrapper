using LavishScriptAPI;

namespace Aion.isxAion
{
    public class WarehouseItem : ItemInfo
    {
        #region Constructors
        public WarehouseItem(LavishScriptObject Obj) : base(Obj)
        {
        }
        #endregion

        #region Members
        #region isxAion-20130130.1548
        public int Quantity
        {
            get { return GetMember<int>("Quantity"); }
        }

        /// <summary>
        /// In seconds
        /// </summary>
        public float Reuse
        {
            get { return GetMember<float>("Reuse"); }
        }

        /// <summary>
        /// In seconds
        /// </summary>
        public float ReadyIn
        {
            get { return GetMember<float>("ReadyIn"); }
        }

        public bool IsReady
        {
            get { return GetMember<bool>("IsReady"); }
        }

        public ItemInfo ItemInfo
        {
            get { return new ItemInfo(GetMember("ItemInfo")); }
        }
        #endregion
        #endregion
    }
}