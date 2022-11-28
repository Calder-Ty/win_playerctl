// Copyright (c) Tyler Calder, 2022

// See https://aka.ms/new-console-template for more information
using System;
using Windows.Media.Control;

class PlayerCTL
{
	static void Main(string[] args)
	{
		var sessionManager = GlobalSystemMediaTransportControlsSessionManager.RequestAsync().GetAwaiter().GetResult();
		var currentSession = sessionManager.GetCurrentSession();
		var mediaProperties = currentSession.TryGetMediaPropertiesAsync().GetAwaiter().GetResult();
		if (args.Length != 2{
			Console.WriteLine($"Playing {mediaProperties.Title} by {mediaProperties.Artist}") ;
			return;
		}
		if ( args[1] == "title" ) {
			Console.WriteLine($"{mediaProperties.Title}") ;
			return;
		} else if (args[1] == "artist") {
			Console.WriteLine($"{mediaProperties.Artist}");
			return;
		}
	}
}

