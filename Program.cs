using System;
using System.Linq;

namespace orbit
{
	class Program
	{
		static void Main(string[] args)
		{
			Body[] planets = {
				new Body { Name = "Mercury", Distance = 57909175, Mass = 3.302E23},
				new Body { Name = "Venus", Distance = 108208930, Mass = 4.8690E24},
				new Body { Name = "Earth", Distance = 149597890, Mass = 5.9742E24},
				new Body { Name = "Mars", Distance = 227936640, Mass = 6.419E23},
				new Body { Name = "Jupiter", Distance = 778412010, Mass = 1.8987E27},
				new Body { Name = "Saturn", Distance = 1426725400, Mass = 5.6851E26},
				new Body { Name = "Uranus", Distance = 2870972200, Mass = 8.6849E25},
				new Body { Name = "Neptune", Distance = 4498252900, Mass = 1.0244E26},
			};
			var bodies = new[] { Body.Sun }.Concat(planets);
			var results = bodies.Select(planet => new
			{
				Name = planet.Name,
				Distance = planet.Distance.ToString("E2"),
				Mass = planet.Mass.ToString("E2"),
				DistanceInSunRadii = planet.DistanceInSunRadii.ToString("E2"),
				CenterOfGravityShift = planet.CenterOfGravityShift.ToString("n5")
			});
			foreach (var result in results)
			{
				Console.WriteLine("Name: {0}", result.Name);
				Console.WriteLine("Distance: {0}", result.Distance);
				Console.WriteLine("Mass: {0}", result.Mass);
				Console.WriteLine("Distance in sun radius: {0}", result.DistanceInSunRadii);
				Console.WriteLine("Center of gravity shift: {0}", result.CenterOfGravityShift);
				Console.WriteLine("==================================");
			}
		}
	}
}
