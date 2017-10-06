using System;
using System.Data;
using System.Collections.Generic;

namespace KH_Template
{
	#region Comments
	/// <summary>
	/// EventTypesOperation Class.
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
	public static class EventTypesOperation
	{
		#region MAP
		/// <summary>
		/// Map EventTypes from data table 
		/// </summary>
		private static List<EventTypes> MapEventTypes(DataTable dt)
		{
			List<EventTypes> Objects = new List<EventTypes>();
			foreach(DataRow dr in dt.Rows)
			{
				EventTypes obj = new EventTypes();
				obj.Type = dr[0].ToString();
				obj.Color = dr[1].ToString();
				
				Objects.Add(obj);
			}
			return Objects;
		}
		#endregion
		
		#region CRUD Operations
		/// <summary>
		/// Get All EventTypes + where (Conditions) 
		/// </summary>
		public static List<EventTypes> GetAllEventTypes(string Conditions = "")
		{
			List<EventTypes> Objects = new List<EventTypes>();
			string query = "Select * from EventTypes";
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
			Objects = MapEventTypes(DatabaseModel.ExecuteQuery(query));
			return Objects;
		}

		/// <summary>
		/// Insert a new instance of the EventTypes class to the database.
		/// </summary>
		public static void InsertEventTypes(List<EventTypes> Objects)
		{
			string query = string.Empty;
			foreach(EventTypes obj in Objects)
			{
				query += "Insert into EventTypes values (" +  Utilities.AdjustDataBaseText(obj.Type) + ',' + Utilities.AdjustDataBaseText(obj.Color) + ");";
			}
			DatabaseModel.ExecuteNonQuery(query);
		}
		
		/// <summary>
		/// Insert a new instance of the EventTypes class to the database.
		/// </summary>
		public static void DeleteEventTypes(string Conditions)
		{
			string query = string.Empty;
			query += "Delete from EventTypes where "  + Conditions;
			DatabaseModel.ExecuteNonQuery(query);
		}
		
		/// <summary>
		/// Insert a new instance of the EventTypes class to the database.
		/// </summary>
		public static void UpdateEventTypes(string Sets, string Conditions)
		{
			string query = string.Empty;
			query += "Update EventTypes Set " + Sets + " where "  + Conditions;
			DatabaseModel.ExecuteNonQuery(query);
		}
		#endregion

		
	}
}