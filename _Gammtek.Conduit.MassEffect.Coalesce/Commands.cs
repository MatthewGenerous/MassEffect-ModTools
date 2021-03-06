﻿using System.Windows.Input;

namespace Gammtek.Conduit.MassEffect.Coalesce
{
	public static class Commands
	{
		static Commands()
		{
			// FileBrowse
			Browse = new RoutedUICommand("Browse", "Brwose", typeof(Commands));

			// ConvertTo
			ConvertTo = new RoutedUICommand("Convert", "ConvertTo", typeof(Commands));

			// ConvertToBinary
			ConvertToBinary = new RoutedUICommand("Convert", "ConvertToBinary", typeof(Commands));

			// ConvertToXml
			ConvertToXml = new RoutedUICommand("Convert", "ConvertToXml", typeof(Commands));

			// DirectoryBrowse
			DirectoryBrowse = new RoutedUICommand("Browse", "DiectoryBrowse", typeof(Commands));

			// FileBrowse
			FileBrowse = new RoutedUICommand("Browse", "FileBrwose", typeof(Commands));

			// Exit
			Exit = new RoutedUICommand("Exit", "Exit", typeof (Commands),
				new InputGestureCollection {new KeyGesture(Key.F4, ModifierKeys.Alt)});
		}

		public static RoutedUICommand Browse { get; private set; }

		public static RoutedUICommand ConvertTo { get; private set; }

		public static RoutedUICommand ConvertToBinary { get; private set; }

		public static RoutedUICommand ConvertToXml { get; private set; }

		public static RoutedUICommand DirectoryBrowse { get; private set; }

		public static RoutedUICommand FileBrowse { get; private set; }

		public static RoutedUICommand Exit { get; private set; }
	}
}
