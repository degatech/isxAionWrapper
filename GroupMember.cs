using LavishScriptAPI;

namespace Aion.isxAion
{
    public class GroupMember : Entity
    {
        #region Constructors
        public GroupMember(LavishScriptObject obj) : base(obj)
        {
            
        }
        #endregion

        #region Members
        #region isxAion-20130130.1548
        public float HPAsPercent
        {
            get { return GetMember<float>("HP", "true"); }
        }
        #endregion

        #region isxAion-20130130.1465
        public Buff BuffByAbilityID(int abilityID)
        {
            return GetMember<Buff>("Buff", "id", abilityID.ToString());
        }
        #endregion

        #region isxAion-20130130.0975
        public int MaxMP
        {
            get { return GetMember<int>("MaxMP"); }
        }

        public int MP
        {
            get { return GetMember<int>("MP"); }
        }

        public int MaxFlightTime
        {
            get { return GetMember<int>("MaxFlightTime"); }
        }

        public int FlightTime
        {
            get { return GetMember<int>("FlightTime"); }
        }

        public uint ZoneID
        {
            get { return GetMember<uint>("ZoneID"); }
        }

        public bool InFlight
        {
            get { return GetMember<bool>("InFlight"); }
        }

        public bool OutOfRange
        {
            get { return GetMember<bool>("OutOfRange"); }
        }

        public bool Linkdead
        {
            get { return GetMember<bool>("Linkdead"); }
        }

        public int NumBuffs
        {
            get { return GetMember<int>("NumBuffs"); }
        }

        public Buff Buff(int buffNumber)
        {
            return new Buff(GetMember("Buff", buffNumber.ToString()));
        }
        #endregion
        #endregion
    }
}
