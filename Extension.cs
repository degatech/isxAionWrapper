namespace Aion.isxAion
{
	public class Extension
	{
		public Extension()
		{
		}

		public static Aion Aion()
		{
			return new Aion();
		}

		public static Character Me
		{
			get
			{
				return new Me();
			}
		}

	    public static Radar Radar()
	    {
	        return new Radar(1);
	    }

        public static Radar Radar(int index)
        {
            return new Radar(index);
        }

        public static Radar Radar(string name)
        {
            return new Radar(name);
        }

        public static Entity Entity(int ID)
		{
			return new Entity(ID);
		}

        public static Entity Entity(params string[] Args)
		{
			return new Entity(Args);
		}

        /// <summary>
        /// The "isxAion" TLO is now named "ISXAion"
        /// isxAion-1.0.5.11.0601
        /// </summary>
        public static ISXAion isxAion
		{
			get
			{
				return new ISXAion();
			}
		}

        public static QuestionWindow QuestionWindow
	    {
	        get {return new QuestionWindow();}
	    }

        public static LootWindow LootWindow
	    {
	        get {return new LootWindow();}
	    }

        public static ChainSkillWindow ChainSkillWindow
	    {
	        get {return new ChainSkillWindow();}
	    }

        public static LoginWindow LoginWindow
	    {
	        get {return new LoginWindow();}
	    }

        public static EULAWindow EULAWindow
	    {
	        get {return new EULAWindow();}
	    }

        public static CharSelectWindow CharSelectWindow
	    {
	        get {return new CharSelectWindow();}
	    }

        public static PinWindow PINWindow
	    {
	        get {return new PinWindow();}
	    }

        public static ConversationWindow ConversationWindow
	    {
	        get {return new ConversationWindow();}
	    }

        public static TeleportWindow TeleportWindow
	    {
	        get {return new TeleportWindow();}
	    }

        public static CraftingWindow CraftingWindow
	    {
	        get {return new CraftingWindow();}
	    }

        public static SelfRessurectionWindow SelfRessurectionWindow
	    {
	        get {return new SelfRessurectionWindow();}
	    }

        public static RessurectionFromOthersWindow RessurectionFromOthersWindow
	    {
	        get {return new RessurectionFromOthersWindow();}
	    }
	}
}