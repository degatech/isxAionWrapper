using LavishScriptAPI;

namespace Aion.isxAion
{
    public class Character : Entity
	{
		#region Constructors
        public Character(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public Character()
            : base(LavishScript.Objects.GetObject("Me"))
		{
		}
		#endregion

		#region Members
        #region isxAion-20130130.1965
        public Entity Pet
        {
            get { return GetMember<Entity>("Pet"); }
        }
        #endregion

        #region isxAion-20130130.1907
        public Entity Following
        {
            get {return GetMember<Entity>("Following");}
        }

        public uint FollowingID
        {
            get { return GetMember<uint>("Following", "ID"); }
        }
        #endregion

        #region isxAion-20130130.1751
        public bool OnFastTrackServer
        {
            get { return GetMember<bool>("OnFastTrackServer"); }
        }
        #endregion

        #region isxAion-20130130.1548
        public Inventory Inventory()
        {
            return new Inventory(GetMember("Inventory"));
        }

        public InventoryItem Inventory(int slotNumber)
        {
            return new InventoryItem(GetMember("Inventory", slotNumber.ToString()));
        }

        public InventoryItem InventoryByID(int itemID)
        {
            return new InventoryItem(GetMember("Inventory", "id", itemID.ToString()));
        }

        public InventoryItem Inventory(string itemName)
        {
            return new InventoryItem(GetMember("Inventory", itemName));
        }

        public InventoryItem InventoryNameContains(string substring)
        {
            return new InventoryItem(GetMember("Inventory", "NameContains", substring));
        }

        public Inventory Equipment()
        {
            return new Inventory(GetMember("Equipment"));
        }

        public EquipmentItem Equipment(int slotNumber)
        {
            return new EquipmentItem(GetMember("Equipment", slotNumber.ToString()));
        }

        public EquipmentItem EquipmentByID(int itemID)
        {
            return new EquipmentItem(GetMember("Equipment", "id", itemID.ToString()));
        }

        public EquipmentItem Equipment(string itemName)
        {
            return new EquipmentItem(GetMember("Equipment", itemName));
        }

        public EquipmentItem EquipmentNameContains(string substring)
        {
            return new EquipmentItem(GetMember("Equipment", "NameContains", substring));
        }

        public Inventory SpecialCube()
        {
            return new Inventory(GetMember("SpecialCube"));
        }

        public SpecialCubeItem SpecialCube(int slotNumber)
        {
            return new SpecialCubeItem(GetMember("SpecialCube", slotNumber.ToString()));
        }

        public SpecialCubeItem SpecialCubeByID(int itemID)
        {
            return new SpecialCubeItem(GetMember("SpecialCube", "id", itemID.ToString()));
        }

        public SpecialCubeItem SpecialCube(string itemName)
        {
            return new SpecialCubeItem(GetMember("SpecialCube", itemName));
        }

        public SpecialCubeItem SpecialCubeNameContains(string substring)
        {
            return new SpecialCubeItem(GetMember("SpecialCube", "NameContains", substring));
        }

        public Inventory Warehouse()
        {
            return new Inventory(GetMember("Warehouse"));
        }

        public WarehouseItem Warehouse(int slotNumber)
        {
            return new WarehouseItem(GetMember("Warehouse", slotNumber.ToString()));
        }

        public WarehouseItem WarehouseByID(int itemID)
        {
            return new WarehouseItem(GetMember("Warehouse", "id", itemID.ToString()));
        }

        public WarehouseItem Warehouse(string itemName)
        {
            return new WarehouseItem(GetMember("Warehouse", itemName));
        }

        public WarehouseItem WarehouseNameContains(string substring)
        {
            return new WarehouseItem(GetMember("Warehouse", "NameContains", substring));
        }
        #endregion

        #region isxAion-20130130.1548
        public float FlightTimeAsPercent
        {
            get { return GetMember<float>("FlightTime", "true"); }
        }
        #endregion

        #region isxAion-20130130.1159
        /// <summary>
        /// TRUE while the "gathering window" is visible
        /// </summary>
        public bool IsGathering
        {
            get { return GetMember<bool>("IsGathering"); }
        }
        #endregion

        #region isxAion-20130130.0975
        public Group Group()
        {
            return new Group(GetMember("Group"));
        }

        public GroupMember Group(int groupMemberNumber)
        {
            return new GroupMember(GetMember("Group", groupMemberNumber.ToString()));
        }

        public GroupMember Group(string groupMemberName)
        {
            return new GroupMember(GetMember("Group", groupMemberName));
        }
        #endregion

        #region isxAion-20130130.0949
        /// <summary>
        /// When looping through Abilities by index, be sure that you only call character.NumAbilities once and then set it to a local variable.  Using
        /// character.NumAbilities itself, in the looping routine, will cause performance issues.
        /// </summary>
        public int NumAbilities
        {
            get { return GetMember<int>("NumAbilities"); }
        }

        /// <summary>
        /// Retrieving abilities by ID is the most efficient, due to how things are handled.  However, there are no
        /// server calls for retrieving abilities by index or name and the differences in retrieval methods are negligible.
        /// </summary>
        public Ability Ability(int abilityNumber)
        {
            return new Ability(GetMember("Ability", abilityNumber.ToString()));
        }

        public Ability AbilityByID(int abilityID)
        {
            return new Ability(GetMember("Ability", abilityID.ToString()));
        }

        public Ability Ability(string abilityName)
        {
            return new Ability(GetMember("Ability", abilityName));
        }
        #endregion

        #region isxAion-1.5.1.4.0194
        /// <summary>
        /// Seconds you have been casting the current spell/ability
        /// </summary>
        public float CastTimeSoFar
        {
            get
            {
                return GetMember<float>("CastTimeSoFar");
            }
        }
        #endregion
        #region isxAion-1.5.1.4.0074
        public int MP
        {
            get
            {
                return GetMember<int>("MP");
            }
        }

        public int MaxMP
        {
            get
            {
                return GetMember<int>("MaxMP");
            }
        }

        public int DP
        {
            get
            {
                return GetMember<int>("DP");
            }
        }

        public int MaxDP
        {
            get
            {
                return GetMember<int>("MaxDP");
            }
        }

        public int XP
        {
            get
            {
                return GetMember<int>("XP");
            }
        }
        /// <summary>
        /// XP to next level would be Me.MaxXP-Me.XP
        /// </summary>
        public int MaxXP
        {
            get
            {
                return GetMember<int>("MaxXP");
            }
        }

        /// <summary>
        /// in seconds
        /// </summary>
        public float FlightTime
        {
            get
            {
                return GetMember<float>("FlightTime");
            }
        }

        /// <summary>
        /// in seconds
        /// </summary>
        public float MaxFlightTime
        {
            get
            {
                return GetMember<float>("MaxFlightTime");
            }
        }

        public int Kinah
        {
            get
            {
                return GetMember<int>("Kinah");
            }
        }

        public int OpenCubeSlots
        {
            get
            {
                return GetMember<int>("OpenCubeSlots");
            }
        }

        public int UsedCubeSlots
        {
            get
            {
                return GetMember<int>("UsedCubeSlots");
            }
        }

        public int MaxCubeSlots
        {
            get
            {
                return GetMember<int>("MaxCubeSlots");
            }
        }

        public bool IsCasting
        {
            get
            {
                return GetMember<bool>("IsCasting");
            }
        }
        #endregion
        #endregion

		#region Methods
        #region isxAion-20130130.1907
        /// <summary>
        /// It is safe to use this method at any point.  If the character is not currently on 'auto follow' the 
        /// method will do nothing.
        /// </summary>
        public bool StopAutoFollow()
        {
            return ExecuteMethod("StopAutoFollow");
        }
        #endregion

        #region isxAion-20130130.1839
        public bool Quit()
        {
            return ExecuteMethod("Quit");
        }

        public bool Logout()
        {
            return ExecuteMethod("Logout");
        }

        public bool Characters()
        {
            return ExecuteMethod("Characters");
        }
        #endregion

        #region isxAion-20130130.1751
        /// <summary>
        /// This method will avoid the annoying popup window; however, it will still do all of the appropriate checks.  Therefore,  
        /// the script will need to check for failure by accessing entity.IsMentor.
        /// </summary>
        public bool MentorTarget()
        {
            return ExecuteMethod("MentorTarget");
        }

        /// <summary>
        /// This method will silently fail if the character is not currently mentoring.  (i.e., you do not have to check "IsMentor"
        /// before calling this method.)
        /// </summary>
        public bool StopMentoring()
        {
            return ExecuteMethod("StopMentoring");
        }
        #endregion

        #region isxAion-20130130.0912
        /// <summary>
        /// "Follow" will toggle auto-follow on your current target if used with no arguments.  Otherwise, you can provide
        /// the ID# of the player you wish to follow.
        /// </summary>
        public bool Follow()
        {
            return ExecuteMethod("Follow");
        }

        public bool Follow(int playerID)
        {
            return ExecuteMethod("Follow", playerID.ToString());
        }

        public bool InviteToGroup(string name)
        {
            return ExecuteMethod("InviteToGroup", name);
        }

        /// <summary>
        /// This function duplicates the action that occurs when you click on an entity after it has already been targetted.
        /// For non-attackable types, it will move you to the target and interact with it.  For attackable targets, it will
	    /// move you to the target and begin auto-attack.
        /// If the "No Interaction" parameter is used, then for NON-attackable types, you will simply move to the target and stop.
        /// This method currently works for PCs, NPCs, gatherables, lootables, and most all interactable objects that can be 
        /// targeted.
        /// Unlike the in-game mechanics, if you try to "ClickTarget" on a corpse that you cannot loot, or a gatherable that is
        /// above your level, the method will do nothing.
        /// </summary>
        public bool ClickTarget()
        {
            return ExecuteMethod("ClickTarget");
        }

        public bool ClickTargetWithoutInteraction()
        {
            return ExecuteMethod("ClickTarget", "No Interaction");
        }
        #endregion

        #region isxAion-1.5.1.4.0236
        public bool ToggleResting()
        {
            return ExecuteMethod("ToggleResting");
        }

        public bool ToggleCombat()
        {
            return ExecuteMethod("ToggleCombat");
        }

        public bool ChangeWeapon()
        {
            return ExecuteMethod("ChangeWeapon");
        }
        #endregion
        #region isxAion-1.5.1.4.0116
        public bool ClearTarget()
        {
            return ExecuteMethod("ClearTarget");
        }

        /// <summary>
        /// Start Riseing. Or use Rise("tap") to just tap the Raise key
        /// </summary>
        public bool Rise(string tap)
        {
            if (tap == "tap")
                return ExecuteMethod("Rise", "tap");

            return ExecuteMethod("Rise");
        }

        /// <summary>
        /// Start Falling. Or use Fall("tap") to just tap the Fall key
        /// </summary>
        public bool Fall(string tap)
        {
            if (tap == "tap")
                return ExecuteMethod("Fall", "tap");

            return ExecuteMethod("Fall");
        }

        /// <summary>
        /// Move(direction) Continuous Movement in that direction
        /// Move(direction,"tap") one single tap of the "movement key"
        /// 'direction' can be:  Forward, Backward, Left, Right, LeftForward, RightForward, LeftBackward, RightBackward
        /// </summary>
        public bool Move(string direction, string tap)
        {
            if (tap == "tap")
                return ExecuteMethod("Move", direction, "tap");

            return ExecuteMethod("Move", direction);
        }

        /// <summary>
        /// Stop all movement
        /// </summary>
        /// <returns></returns>
        public bool StopMoving()
        {
            return ExecuteMethod("StopMoving");
        }

        /// <summary>
        /// Spread wings and take flight
        /// </summary>
        public bool TakeOff()
        {
            return ExecuteMethod("TakeOff");
        }

        /// <summary>
        /// Stop flying/Put your wings away
        /// </summary>
        public bool Land()
        {
            return ExecuteMethod("Land");
        }
        #endregion
        #endregion
	}

	public class Me : Character
	{
		public Me()
			: base()
		{
		}
	}
}
