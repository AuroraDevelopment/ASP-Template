using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KH_Template.Forms.Table
{
    public partial class TableForm : System.Web.UI.UserControl
    {
        private string FIELDCONFIG = string.Empty;
        public string Data { set; get; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string script = @"
             $(function () {
            $('#ObjectTableContainer').jtable({
                title: 'The {TABLENAME} List',
                paging: true,
                pageSize: 10,
                actions: {
                    listAction: 'Code/AjaxOperations.aspx/GetObjects',
                    createAction: 'Code/AjaxOperations.aspx/CreateObject',
                    updateAction: '/Form/Table/TableForm.ascx/UpdateObject',
                    deleteAction: '/Form/Table/TableForm.ascx/DeleteObject'
                },
                fields: {
                    {FIELDCONFIG}
                }
            });
            //Load student list from server
            $('#ObjectTableContainer').jtable('load');
            });";

            DataTable dt = DatabaseModel.ExecuteQuery(Data);
            int cc = 0;
            foreach (DataColumn dc in dt.Columns)
            {
                if(cc < 6)
                {
                    cc++;
                    if (dc.DataType.Name == "Int32" && dc.ColumnName == "ID")
                    {
                        FIELDCONFIG += Utilities.tab5 + dc.ColumnName + " : { key: true,create: false,edit: false,list: false },";
                    }
                    else if(dc.ColumnName == "Name")
                    {
                        FIELDCONFIG += Utilities.tab5 + dc.ColumnName + " : { create: false,edit: false,list: false },";
                    }
                    else
                    {
                        switch (dc.DataType.ToString())
                        {
                            case "Int32":
                                FIELDCONFIG += Utilities.tab5 + dc.ColumnName + " : { title: '" + dc.ColumnName + "', type: 'number' },";
                                FIELDCONFIG += Environment.NewLine;
                                break;

                            case "DateTime":
                                FIELDCONFIG += Utilities.tab5 + dc.ColumnName + " : { title: '" + dc.ColumnName + "', type: 'date', displayFormat: 'yy-mm-dd' },";
                                FIELDCONFIG += Environment.NewLine;
                                break;

                            case "String":
                            default:
                                FIELDCONFIG += Utilities.tab5 + dc.ColumnName + " : { title: '" + dc.ColumnName + "' },";
                                FIELDCONFIG += Environment.NewLine;
                                break;
                        }
                    }
                }
                else
                {
                    switch (dc.DataType.ToString())
                    {
                        case "Int32":
                            FIELDCONFIG += Utilities.tab5 + dc.ColumnName + " : { title: '" + dc.ColumnName + "',list:false, type: 'number' },";
                            FIELDCONFIG += Environment.NewLine;
                            break;

                        case "DateTime":
                            FIELDCONFIG += Utilities.tab5 + dc.ColumnName + " : { title: '" + dc.ColumnName + "',list:false, khtype: 'date', displayFormat: 'yy-mm-dd' },";
                            FIELDCONFIG += Environment.NewLine;
                            break;

                        case "String":
                        default:
                            FIELDCONFIG += Utilities.tab5 + dc.ColumnName + " : { title: '" + dc.ColumnName + "', list:false },";
                            FIELDCONFIG += Environment.NewLine;
                            break;
                    }
                }
                
            }

            FIELDCONFIG = FIELDCONFIG.Remove(FIELDCONFIG.LastIndexOf(','), 1);

            script = script.Replace("{FIELDCONFIG}", FIELDCONFIG);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "table", script, true);
            
            //ScriptManager.RegisterClientScriptBlock(this, GetType(), "table", "$('#ObjectTableContainer').jtable('load');", true);*/
            
        }

    }
}