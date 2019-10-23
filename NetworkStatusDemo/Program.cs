//************************************************************************************************
// Copyright © 2010 Steven M. Cohn. All Rights Reserved.
//
//************************************************************************************************

namespace NetworkStatusDemo
{
	using System;
	using iTuner;


	/// <summary>
	/// Demonstrate the use of the NetworkStatus class.
	/// </summary>

	class Program
	{
		static void Main (string[] args)
		{
			Console.WriteLine();

			ReportAvailability();

			NetworkStatus.AvailabilityChanged +=
				new NetworkStatusChangedHandler(DoAvailabilityChanged);

			Console.WriteLine("... Press Enter to quit");
			Console.WriteLine();
			Console.ReadLine();
		}


		/// <summary>
		/// Event handler used to capture availability changes.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		static void DoAvailabilityChanged (
			object sender, NetworkStatusChangedArgs e)
		{
			ReportAvailability();
		}


		/// <summary>
		/// Report the current network availability.
		/// </summary>

		private static void ReportAvailability ()
		{
			if (NetworkStatus.IsAvailable)
			{
				Console.WriteLine("... Network is available");
			}
			else
			{
				Console.WriteLine("... Network is not available");
			}
		}
	}
}
