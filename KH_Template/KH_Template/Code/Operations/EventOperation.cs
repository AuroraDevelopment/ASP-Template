using System;
using System.Data;
using System.Collections.Generic;

namespace KH_Template
{
	#region Comments
	/// <summary>
	/// EventOperation Class.
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
	public static class EventOperation
	{
		#region MAP
		/// <summary>
		/// Map Event from data table 
		/// </summary>
		private static List<Event> MapEvent(DataTable dt)
		{
			List<Event> Objects = new List<Event>();
			foreach(DataRow dr in dt.Rows)
			{
				Event obj = new Event();
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
				obj.StartDate = DateTime.Parse(dr[10].ToString());
				obj.EndDate = DateTime.Parse(dr[11].ToString());
				obj.AllDay = int.Parse(dr[12].ToString());
				
				Objects.Add(obj);
			}
			return Objects;
		}
		#endregion
		
		#region CRUD Operations
		/// <summary>
		/// Get All Event + where (Conditions) 
		/// </summary>
		public static List<Event> GetAllEvent(string Conditions = "")
		{
			List<Event> Objects = new List<Event>();
			string query = "Select * from Event";
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
			Objects = MapEvent(DatabaseModel.ExecuteQuery(query));
			return Objects;
		}

		/// <summary>
		/// Insert a new instance of the Event class to the database.
		/// </summary>
		public static void InsertEvent(List<Event> Objects)
		{
			string query = string.Empty;
			foreach(Event obj in Objects)
			{
				query += "Insert into Event values (" +  Utilities.AdjustDataBaseText(obj.Name) + ',' + Utilities.AdjustDataBaseText(obj.Title) + ',' + Utilities.AdjustDataBaseText(obj.Detail) + ',' + Utilities.AdjustDataBaseText(obj.URL) + ',' + Utilities.AdjustDataBaseText(obj.Type) + ',' +Utilities.AdjustDataBaseText(obj.Created_On.ToString()) + ',' + Utilities.AdjustDataBaseText(obj.Created_By) + ',' +Utilities.AdjustDataBaseText(obj.Last_Modified_On.ToString()) + ',' + Utilities.AdjustDataBaseText(obj.Last_Modified_By) + ',' +Utilities.AdjustDataBaseText(obj.StartDate.ToString()) + ',' +Utilities.AdjustDataBaseText(obj.EndDate.ToString()) + ',' +obj.AllDay + ");";
			}
			DatabaseModel.ExecuteNonQuery(query);
		}
		
		/// <summary>
		/// Insert a new instance of the Event class to the database.
		/// </summary>
		public static void DeleteEvent(string Conditions)
		{
			string query = string.Empty;
			query += "Delete from Event where "  + Conditions;
			DatabaseModel.ExecuteNonQuery(query);
		}
		
		/// <summary>
		/// Insert a new instance of the Event class to the database.
		/// </summary>
		public static void UpdateEvent(string Sets, string Conditions)
		{
			string query = string.Empty;
			query += "Update Event Set " + Sets + " where "  + Conditions;
			DatabaseModel.ExecuteNonQuery(query);
		}
		#endregion

		
	}
}