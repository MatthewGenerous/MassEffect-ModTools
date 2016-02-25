﻿using System;
using Gammtek.Conduit.CommandLine.Core;

namespace Gammtek.Conduit.CommandLine
{
	/// <summary>
	///     Models name information, used in <see cref="CommandLine.Error" /> instances.
	/// </summary>
	public sealed class NameInfo : IEquatable<NameInfo>
	{
		/// <summary>
		///     Represents an empty name information. Used when <see cref="CommandLine.Error" /> are tied to values,
		///     rather than options.
		/// </summary>
		public static readonly NameInfo EmptyName = new NameInfo(string.Empty, string.Empty);

		internal NameInfo(string shortName, string longName)
		{
			if (shortName == null)
			{
				throw new ArgumentNullException("shortName");
			}

			if (longName == null)
			{
				throw new ArgumentNullException("longName");
			}

			LongName = longName;
			ShortName = shortName;
		}

		/// <summary>
		///     Gets the long name of the name information.
		/// </summary>
		public string LongName { get; private set; }

		/// <summary>
		///     Gets a formatted text with unified name information.
		/// </summary>
		public string NameText
		{
			get
			{
				return ShortName.Length > 0 && LongName.Length > 0
					? ShortName + ", " + LongName
					: ShortName.Length > 0
						? ShortName
						: LongName;
			}
		}

		/// <summary>
		///     Gets the short name of the name information.
		/// </summary>
		public string ShortName { get; private set; }

		/// <summary>
		///     Determines whether the specified <see cref="System.Object" /> is equal to the current <see cref="System.Object" />.
		/// </summary>
		/// <param name="obj">The <see cref="System.Object" /> to compare with the current <see cref="System.Object" />.</param>
		/// <returns>
		///     <value>true</value>
		///     if the specified <see cref="System.Object" /> is equal to the current <see cref="System.Object" />; otherwise,
		///     <value>false</value>
		///     .
		/// </returns>
		public override bool Equals(object obj)
		{
			var other = obj as NameInfo;

			return other != null && Equals(other);
		}

		/// <summary>
		///     Serves as a hash function for a particular type.
		/// </summary>
		/// <remarks>A hash code for the current <see cref="System.Object" />.</remarks>
		public override int GetHashCode()
		{
			return ShortName.GetHashCode() ^ LongName.GetHashCode();
		}

		internal static NameInfo FromOptionSpecification(OptionSpecification specification)
		{
			return new NameInfo(specification.LongName, specification.ShortName);
		}

		internal static NameInfo FromSpecification(Specification specification)
		{
			switch (specification.Tag)
			{
				case SpecificationType.Option:
				{
					return FromOptionSpecification((OptionSpecification) specification);
				}
				default:
				{
					return EmptyName;
				}
			}
		}

		/// <summary>
		///     Returns a value that indicates whether the current instance and a specified <see cref="CommandLine.NameInfo" /> have the same value.
		/// </summary>
		/// <param name="other">The <see cref="CommandLine.NameInfo" /> instance to compare.</param>
		/// <returns>
		///     <value>true</value>
		///     if this instance of <see cref="CommandLine.NameInfo" /> and <paramref name="other" /> have the same value; otherwise,
		///     <value>false</value>
		///     .
		/// </returns>
		public bool Equals(NameInfo other)
		{
			if (other == null)
			{
				return false;
			}

			return ShortName.Equals(other.ShortName) && LongName.Equals(other.LongName);
		}
	}
}