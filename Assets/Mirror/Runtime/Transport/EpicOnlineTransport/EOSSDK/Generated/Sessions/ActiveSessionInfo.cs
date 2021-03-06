// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Top level details about an active session
	/// </summary>
	public class ActiveSessionInfo : ISettable
	{
		/// <summary>
		/// Name of the session
		/// </summary>
		public string SessionName { get; set; }

		/// <summary>
		/// The Product User ID of the local user who created or joined the session
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// Current state of the session
		/// </summary>
		public OnlineSessionState State { get; set; }

		/// <summary>
		/// Session details
		/// </summary>
		public SessionDetailsInfo SessionDetails { get; set; }

		internal void Set(ActiveSessionInfoInternal? other)
		{
			if (other != null)
			{
				SessionName = other.Value.SessionName;
				LocalUserId = other.Value.LocalUserId;
				State = other.Value.State;
				SessionDetails = other.Value.SessionDetails;
			}
		}

		public void Set(object other)
		{
			Set(other as ActiveSessionInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct ActiveSessionInfoInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_SessionName;
		private System.IntPtr m_LocalUserId;
		private OnlineSessionState m_State;
		private System.IntPtr m_SessionDetails;

		public string SessionName
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_SessionName, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_SessionName, value);
			}
		}

		public ProductUserId LocalUserId
		{
			get
			{
				ProductUserId value;
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public OnlineSessionState State
		{
			get
			{
				return m_State;
			}

			set
			{
				m_State = value;
			}
		}

		public SessionDetailsInfo SessionDetails
		{
			get
			{
				SessionDetailsInfo value;
				Helper.TryMarshalGet<SessionDetailsInfoInternal, SessionDetailsInfo>(m_SessionDetails, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet<SessionDetailsInfoInternal, SessionDetailsInfo>(ref m_SessionDetails, value);
			}
		}

		public void Set(ActiveSessionInfo other)
		{
			if (other != null)
			{
				m_ApiVersion = ActiveSession.ActivesessionCopyinfoApiLatest;
				SessionName = other.SessionName;
				LocalUserId = other.LocalUserId;
				State = other.State;
				SessionDetails = other.SessionDetails;
			}
		}

		public void Set(object other)
		{
			Set(other as ActiveSessionInfo);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_SessionName);
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_SessionDetails);
		}
	}
}