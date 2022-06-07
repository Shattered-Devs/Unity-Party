// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Achievements
{
	/// <summary>
	/// Input parameters for the <see cref="AchievementsInterface.CopyUnlockedAchievementByAchievementId" /> function.
	/// </summary>
	public class CopyUnlockedAchievementByAchievementIdOptions
	{
		/// <summary>
		/// The Product User ID for the user who is copying the unlocked achievement
		/// </summary>
		public ProductUserId UserId { get; set; }

		/// <summary>
		/// AchievementId of the unlocked achievement to retrieve from the cache
		/// </summary>
		public string AchievementId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CopyUnlockedAchievementByAchievementIdOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_UserId;
		private System.IntPtr m_AchievementId;

		public ProductUserId UserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_UserId, value);
			}
		}

		public string AchievementId
		{
			set
			{
				Helper.TryMarshalSet(ref m_AchievementId, value);
			}
		}

		public void Set(CopyUnlockedAchievementByAchievementIdOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = AchievementsInterface.CopyunlockedachievementbyachievementidApiLatest;
				UserId = other.UserId;
				AchievementId = other.AchievementId;
			}
		}

		public void Set(object other)
		{
			Set(other as CopyUnlockedAchievementByAchievementIdOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_UserId);
			Helper.TryMarshalDispose(ref m_AchievementId);
		}
	}
}