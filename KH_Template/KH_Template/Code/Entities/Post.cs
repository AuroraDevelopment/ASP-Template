using System;
using System.Data;

namespace KH_Template
{
	#region Comments
	/// <summary>
	/// Post Class.
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
	public class Post
	{
		#region Construction
		/// <summary>
		/// Initializes a new (no-args) instance of the Post class.
		/// </summary>
		public Post()
		{
		}

		/// <summary>
		/// Initializes a new instance of the Post class.
		/// </summary>
		public Post(Int32 ID, String Name, String Title, String Detail, String URL, String Type, DateTime Created_On, String Created_By, DateTime Last_Modified_On, String Last_Modified_By)
		{
			this.ID = ID;
			this.Name = Name;
			this.Title = Title;
			this.Detail = Detail;
			this.URL = URL;
			this.Type = Type;
			this.Created_On = Created_On;
			this.Created_By = Created_By;
			this.Last_Modified_On = Last_Modified_On;
			this.Last_Modified_By = Last_Modified_By;
		}
		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public virtual Int32 ID { get; set; }

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public virtual String Name { get; set; }

		/// <summary>
		/// Gets or sets the Title value.
		/// </summary>
		public virtual String Title { get; set; }

		/// <summary>
		/// Gets or sets the Detail value.
		/// </summary>
		public virtual String Detail { get; set; }

		/// <summary>
		/// Gets or sets the URL value.
		/// </summary>
		public virtual String URL { get; set; }

		/// <summary>
		/// Gets or sets the Type value.
		/// </summary>
		public virtual String Type { get; set; }

		/// <summary>
		/// Gets or sets the Created_On value.
		/// </summary>
		public virtual DateTime Created_On { get; set; }

		/// <summary>
		/// Gets or sets the Created_By value.
		/// </summary>
		public virtual String Created_By { get; set; }

		/// <summary>
		/// Gets or sets the Last_Modified_On value.
		/// </summary>
		public virtual DateTime Last_Modified_On { get; set; }

		/// <summary>
		/// Gets or sets the Last_Modified_By value.
		/// </summary>
		public virtual String Last_Modified_By { get; set; }
		#endregion

		#region Overrides
		/// <summary>
		/// Returns the Primary Key of the object.
		/// </summary>
		/// <returns>String</returns>
		public override String ToString()
		{
			return "[Post] " + this.ID.ToString();
		}

		/// <summary>
		/// Returns true if the Ids of the two instances are equal.
		/// </summary>
		/// <param name="ObjectToCompare">The other object instance.</param>
		/// <returns>String</returns>
		public override Boolean Equals(Object ObjectToCompare)
		{
			if(ObjectToCompare == null) return false;
			Post otherObject = ObjectToCompare as Post;
			if (otherObject == null) return false;
			return Post.Equals(this, otherObject);
		}

		/// <summary>
		/// Returns the GetHashCode() method of the Primary Key member.
		/// </summary>
		/// <returns>String</returns>
		public override Int32 GetHashCode()
		{
			return this.ID.GetHashCode();
		}
		#endregion

	
		
	}
}