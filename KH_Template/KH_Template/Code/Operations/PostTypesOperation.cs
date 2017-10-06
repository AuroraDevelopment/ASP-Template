using System;
using System.Data;
using System.Collections.Generic;

namespace KH_Template
{
	#region Comments
	/// <summary>
	/// PostTypesOperation Class.
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
	public static class PostTypesOperation
	{
		#region MAP
		/// <summary>
		/// Map PostTypes from data table 
		/// </summary>
		private static List<PostTypes> MapPostTypes(DataTable dt)
		{
			List<PostTypes> Objects = new List<PostTypes>();
			foreach(DataRow dr in dt.Rows)
			{
				PostTypes obj = new PostTypes();
				obj.Type = dr[0].ToString();
				
				Objects.Add(obj);
			}
			return Objects;
		}
		#endregion
		
		#region CRUD Operations
		/// <summary>
		/// Get All PostTypes + where (Conditions) 
		/// </summary>
		public static List<PostTypes> GetAllPostTypes(string Conditions = "")
		{
			List<PostTypes> Objects = new List<PostTypes>();
			string query = "Select * from PostTypes";
			if(Conditions == string.Empty)
			{
				
			}
			else
			{
				string[] conditions = Conditions.Split(';');
				query += " where ";
				for(int i = 0; i < conditions.Length; i++)
				{
					query += " " + conditions[i] + " and ";
				}
				query = query.Remove(query.LastIndexOf(" and "));
			}
			Objects = MapPostTypes(DatabaseModel.ExecuteQuery(query));
			return Objects;
		}

		/// <summary>
		/// Insert a new instance of the PostTypes class to the database.
		/// </summary>
		public static void InsertPostTypes(List<PostTypes> Objects)
		{
			string query = string.Empty;
			foreach(PostTypes obj in Objects)
			{
				query += "Insert into PostTypes values (" +  Utilities.AdjustDataBaseText(obj.Type) + ");";
			}
			DatabaseModel.ExecuteNonQuery(query);
		}
		
		/// <summary>
		/// Insert a new instance of the PostTypes class to the database.
		/// </summary>
		public static void DeletePostTypes(string Conditions)
		{
			string query = string.Empty;
			query += "Delete from PostTypes where "  + Conditions;
			DatabaseModel.ExecuteNonQuery(query);
		}
		
		/// <summary>
		/// Insert a new instance of the PostTypes class to the database.
		/// </summary>
		public static void UpdatePostTypes(string Sets, string Conditions)
		{
			string query = string.Empty;
			query += "Update PostTypes Set " + Sets + " where "  + Conditions;
			DatabaseModel.ExecuteNonQuery(query);
		}
		#endregion

		
	}
}