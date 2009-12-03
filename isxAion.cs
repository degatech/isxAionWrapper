using System;
using System.Collections.Generic;
using System.Text;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
    public class ISXAion : LavishScriptPersistentObject
	{
		#region Constructors
        public ISXAion(LavishScriptPersistentObject Obj)
			: base(Obj)
		{
		}

		public ISXAion()
            : base(LavishScript.Objects.GetPersistentObject("ISXAion"))
		{
		}
		#endregion

		#region Members
		public string Version
		{
			get
			{
				return GetMember<string>("Version");
			}
		}

		/// <summary>
		/// Note: All scripts should check to make sure that this is true before running.
		/// </summary>
		public bool IsReady
		{
			get
			{
				return GetMember<bool>("IsReady");
			}
		}

		/// <summary>
		/// Returns true if the extension is currently in the authentication/patching phase of loading
		/// </summary>
		public bool IsLoading
		{
			get
			{
				return GetMember<bool>("IsLoading");
			}
		}

        public int NumRadars
        {
            get
            {
                return GetMember<int>("NumRadars");
            }
        }

		#endregion

		#region Methods
		#endregion
	}
}
