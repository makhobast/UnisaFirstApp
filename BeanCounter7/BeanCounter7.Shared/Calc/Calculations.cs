using System;
using System.Collections.Generic;
using System.Text;

namespace BeanCounter7
{
	static class Calculations
	{
		public static double CalculateVolume(double width, double height, double depth)
		{
			return width * height * depth;
		}

		public static int HowManyBeans(double beanVolume, double jarVolume)
		{
			return (int)(jarVolume / beanVolume);
		}
	}
}
