namespace orbit
{
	class Body
	{
		public static Body Sun = new Body { Name = "Sun", Distance = 0, Mass = 1.98855E30 };
		const double SunRadius = 696342;
		public string Name { get; set; }
		public double Distance { get; set; } // In Km
		public double Mass { get; set; } // In Kg
		public double MassInSuns
		{
			get
			{
				return Mass / Sun.Mass;
			}
		}
		public double DistanceInSunRadii
		{
			get
			{
				return Distance / SunRadius;
			}
		}
		public double CenterOfGravityShift
		{
			get
			{
				return MassInSuns * DistanceInSunRadii;
			}
		}
	}
}
