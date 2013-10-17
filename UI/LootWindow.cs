using LavishScriptAPI;

namespace Aion.isxAion
{
    public class LootWindow : AionWindow
    {
        #region Constructors
        public LootWindow(LavishScriptObject Obj) : base(Obj)
        {
        }

        public LootWindow()
            : base(LavishScript.Objects.GetObject("LootWindow"))
        {
            
        }
        #endregion

        #region Members
        #region isxAion-20130130.1407
        public int LootCounter
        {
            get { return GetMember<int>("LootCounter"); }
        }

        /// <summary>
        /// lootItemNumber is between 1 and lootwindow.LootCount
        /// </summary>
        public LootItem Loot(int lootItemNumber)
        {
            return new LootItem(GetMember("Loot", lootItemNumber.ToString()));
        }

        /// <summary>
        /// typically "Loot All" or "Cancel", depending upon whether loot is available
        /// </summary>
        public AionButton Button1
        {
            get { return new AionButton(GetMember("Button1")); }
        }
        #endregion
        #endregion
    }
}