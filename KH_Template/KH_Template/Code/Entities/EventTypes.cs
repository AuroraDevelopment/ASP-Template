using System;
using System.Data;

namespace KH_Template
{
	#region Comments
	/// <summary>
	/// EventTypes Class.
	/// </summary>
	/// <remarks>
	/// <h3>Changes</h3>
	/// <list type="table">
	/// 	<listheader>
	/// 		<th>Author</th>
	/// 		<th>Date</th>
	/// 		<th>Details</th>
	/// 	</listheader>
	/// 	<item>
	/// 		<term>Kh</term>
	/// 		<description>9/22/2017</description>
	/// 		<description>Created</description>
	/// 	</item>
	/// </list>
	/// </remarks>
	#endregion

	[Serializable]
	public class EventTypes
	{
		#region Construction
		/// <summary>
		/// Initializes a new (no-args) instance of the EventTypes class.
		/// </summary>
		public EventTypes()
		{
		}

		/// <summary>
		/// Initializes a new instance of the EventTypes class.
		/// </summary>
		public EventTypes(String Type, String Color)
		{
			this.Type = Type;
			this.Color = Color;
		}
		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public virtual String Type { get; set; }

		/// <summary>
		/// Gets or sets the Color value.
		/// </summary>
		public virtual String Color { get; set; }
		#endregion

		#region Overrides
		/// <summary>
		/// Returns the Primary Key of the object.
		/// </summary>
		/// <returns>String</returns>
		public override String ToString()
		{
			return "[EventTypes] " + this.Type.ToString();
		}

		/// <summary>
		/// Returns true if the Ids of the two instances are equal.
		/// </summary>
		/// <param name="ObjectToCompare">The other object instance.</param>
		/// <returns>String</returns>
		public override Boolean Equals(Object ObjectToCompare)
		{
			if(ObjectToCompare == null) return false;
			EventTypes otherObject = ObjectToCompare as EventTypes;
			if (otherObject == null) return false;
			return EventTypes.Equals(this, otherObject);
		}

		/// <summary>
		/// Returns the GetHashCode() method of the Primary Key member.
		/// </summary>
		/// <returns>String</returns>
		public override Int32 GetHashCode()
		{
			return this.Type.GetHashCode();
		}
		#endregion

	
		
	}
}