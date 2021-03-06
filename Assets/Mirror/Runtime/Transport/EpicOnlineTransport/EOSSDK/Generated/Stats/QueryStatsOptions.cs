// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Stats
{
	/// <summary>
	/// Input parameters for the <see cref="StatsInterface.QueryStats" /> function.
	/// </summary>
	public class QueryStatsOptions
	{
		/// <summary>
		/// The Product User ID of the local user requesting the stats. Set to null for dedicated server.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// If not <see cref="StatsInterface.TimeUndefined" /> then this is the POSIX timestamp for start time (Optional).
		/// </summary>
		public System.DateTimeOffset? StartTime { get; set; }

		/// <summary>
		/// If not <see cref="StatsInterface.TimeUndefined" /> then this is the POSIX timestamp for end time (Optional).
		/// </summary>
		public System.DateTimeOffset? EndTime { get; set; }

		/// <summary>
		/// An array of stat names to query for (Optional).
		/// </summary>
		public string[] StatNames { get; set; }

		/// <summary>
		/// The Product User ID for the user whose stats are being retrieved
		/// </summary>
		public ProductUserId TargetUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryStatsOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private long m_StartTime;
		private long m_EndTime;
		private System.IntPtr m_StatNames;
		private uint m_StatNamesCount;
		private System.IntPtr m_TargetUserId;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public System.DateTimeOffset? StartTime
		{
			set
			{
				Helper.TryMarshalSet(ref m_StartTime, value);
			}
		}

		public System.DateTimeOffset? EndTime
		{
			set
			{
				Helper.TryMarshalSet(ref m_EndTime, value);
			}
		}

		public string[] StatNames
		{
			set
			{
				Helper.TryMarshalSet(ref m_StatNames, value, out m_StatNamesCount, true);
			}
		}

		public ProductUserId TargetUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_TargetUserId, value);
			}
		}

		public void Set(QueryStatsOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = StatsInterface.QuerystatsApiLatest;
				LocalUserId = other.LocalUserId;
				StartTime = other.StartTime;
				EndTime = other.EndTime;
				StatNames = other.StatNames;
				TargetUserId = other.TargetUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryStatsOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_StatNames);
			Helper.TryMarshalDispose(ref m_TargetUserId);
		}
	}
}