using System;
using System.Data;
using System.Collections.Generic;

namespace KH_Template
{
	#region Comments
	/// <summary>
	/// PostOperation Class.
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
	public static class PostOperation
	{
		#region MAP
		/// <summary>
		/// Map Post from data table 
		/// </summary>
		private static List<Post> MapPost(DataTable dt)
		{
			List<Post> Objects = new List<Post>();
			foreach(DataRow dr in dt.Rows)
			{
				Post obj = new Post();
				obj.ID = int.Parse(dr[0].ToString());
				obj.Name = dr[1].ToString();
				obj.Title = dr[2].ToString();
				obj.Detail = dr[3].ToString();
				obj.URL = dr[4].ToString();
				obj.Type = dr[5].ToString();
				obj.Created_On = DateTime.Parse(dr[6].ToString());
				obj.Created_By = dr[7].ToString();
				obj.Last_Modified_On = DateTime.Parse(dr[8].ToString());
				obj.Last_Modified_By = dr[9].ToString();
				
				Objects.Add(obj);
			}
			return Objects;
		}
		#endregion
		
		#region CRUD Operations
		/// <summary>
		/// Get All Post + where (Conditions) 
		/// </summary>
		public static List<Post> GetAllPost(string Conditions = "")
		{
			List<Post> Objects = new List<Post>();
			string query = "Select * from Post";
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
			Objects = MapPost(DatabaseModel.ExecuteQuery(query));
			return Objects;
		}

		/// <summary>
		/// Insert a new instance of the Post class to the database.
		/// </summary>
		public static void InsertPost(List<Post> Objects)
		{
			string query = string.Empty;
			foreach(Post obj in Objects)
			{
				query += "Insert into Post values (" +  Utilities.AdjustDataBaseText(obj.Name) + ',' + Utilities.AdjustDataBaseText(obj.Title) + ',' + Utilities.AdjustDataBaseText(obj.Detail) + ',' + Utilities.AdjustDataBaseText(obj.URL) + ',' + Utilities.AdjustDataBaseText(obj.Type) + ',' +Utilities.AdjustDataBaseText(obj.Created_On.ToString()) + ',' + Utilities.AdjustDataBaseText(obj.Created_By) + ',' +Utilities.AdjustDataBaseText(obj.Last_Modified_On.ToString()) + ',' + Utilities.AdjustDataBaseText(obj.Last_Modified_By) + ");";
			}
			DatabaseModel.ExecuteNonQuery(query);
		}
		
		/// <summary>
		/// Insert a new instance of the Post class to the database.
		/// </summary>
		public static void DeletePost(string Conditions)
		{
			string query = string.Empty;
			query += "Delete from Post where "  + Conditions;
			DatabaseModel.ExecuteNonQuery(query);
		}
		
		/// <summary>
		/// Insert a new instance of the Post class to the database.
		/// </summary>
		public static void UpdatePost(string Sets, string Conditions)
		{
			string query = string.Empty;
			query += "Update Post Set " + Sets + " where "  + Conditions;
			DatabaseModel.ExecuteNonQuery(query);
		}
		#endregion

		
	}
}