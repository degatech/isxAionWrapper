﻿using LavishScriptAPI;

namespace Aion.isxAion
{
    public class CraftingWindow : AionWindow
    {
        #region Constructors
        public CraftingWindow(LavishScriptObject Obj) : base(Obj)
        {
        }

        public CraftingWindow()
            : base(LavishScript.Objects.GetObject("CraftingWindow"))
		{
		}
        #endregion

        #region Members
        #region isxAion-20130626.0193
        public AionButton CraftAll
        {
            get { return new AionButton(GetMember("Craftall")); }
        }

        public ListItem Product
        {
            get { return new ListItem(GetMember("Product")); }
        }

        /// <summary>
        /// index is 1-8
        /// </summary>
        public ListItem RequiredMaterial(int index)
        {
            return new ListItem(GetMember("RequiredMaterial", index.ToString()));
        }

        public AionWidget WorkOrderList
        {
            get { return new AionWidget(GetMember("WorkOrderList")); }
        }
        #endregion
        #endregion
    }
}