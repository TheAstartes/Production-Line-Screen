using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Web1.Model;



namespace Web1
{


    public class HomeController : Controller
    {
        

        // GET: /<controller>/
        public IActionResult Index()
        {

            var instance = new Sql_import();


             string connection_string = //Connection String Needed
            

            List<string> MachineStatus0 = new List<string>();
            List<string> MachineStatus1 = new List<string>();
            List<string> MachineStatus2 = new List<string>();
            List<string> MachineStatus3 = new List<string>();
            List<string> MachineStatus4 = new List<string>();
            List<string> MachineStatus5 = new List<string>();
            List<string> MachineStatus6 = new List<string>();
            List<string> MachineStatus7 = new List<string>();
            List<string> MachineStatus8 = new List<string>();
            List<string> MachineStatus9 = new List<string>();
            List<string> MachineStatus10 = new List<string>();
            List<string> MachineStatus11 = new List<string>();
            List<string> MachineStatus12 = new List<string>();

            List<string> MachineTime0 = new List<string>();
            List<string> MachineTime1 = new List<string>();
            List<string> MachineTime2 = new List<string>();
            List<string> MachineTime3 = new List<string>();
            List<string> MachineTime4 = new List<string>();
            List<string> MachineTime5 = new List<string>();
            List<string> MachineTime6 = new List<string>();
            List<string> MachineTime7 = new List<string>();
            List<string> MachineTime8 = new List<string>();
            List<string> MachineTime9 = new List<string>();
            List<string> MachineTime10 = new List<string>();
            List<string> MachineTime11 = new List<string>();
            List<string> MachineTime12 = new List<string>();

            List<string> MachinePlannedStop0 = new List<string>();
            List<string> MachinePlannedStop1 = new List<string>();
            List<string> MachinePLannedStop2 = new List<string>();
            List<string> MachinePLannedStop3 = new List<string>();
            List<string> MachinePLannedStop4 = new List<string>();
            List<string> MachinePLannedStop5 = new List<string>();
            List<string> MachinePLannedStop6 = new List<string>();
            List<string> MachinePLannedStop7 = new List<string>();
            List<string> MachinePLannedStop8 = new List<string>();
            List<string> MachinePLannedStop9 = new List<string>();
            List<string> MachinePLannedStop10 = new List<string>();
            List<string> MachinePLannedStop11 = new List<string>();
            List<string> MachinePLannedStop12 = new List<string>();


            List<string> MachineChangeOver0 = new List<string>();
            List<string> MachineChangeOver1 = new List<string>();
            List<string> MachineChangeOver2 = new List<string>();
            List<string> MachineChangeOver3 = new List<string>();
            List<string> MachineChangeOver4 = new List<string>();
            List<string> MachineChangeOver5 = new List<string>();
            List<string> MachineChangeOver6 = new List<string>();
            List<string> MachineChangeOver7 = new List<string>();
            List<string> MachineChangeOver8 = new List<string>();
            List<string> MachineChangeOver9 = new List<string>();
            List<string> MachineChangeOver10 = new List<string>();
            List<string> MachineChangeOver11 = new List<string>();
            List<string> MachineChangeOver12 = new List<string>();



            string[] short_time = new string[1000];




            string[] import = new string[13] { "SELECT System_status FROM dbo.Machine1", "SELECT System_status FROM dbo.Machine2", "SELECT System_status FROM dbo.Machine3",
            "SELECT System_status FROM dbo.Machine4",
            "SELECT System_status FROM dbo.Machine5",
        "SELECT System_status FROM dbo.Machine6","SELECT System_status FROM dbo.Machine7","SELECT System_status FROM dbo.Machine9","SELECT System_status dbo.Machine8",
            "SELECT System_status FROM dbo.Machine10",
        "SELECT System_status FROM dbo.Machine11","SELECT System_status FROM dbo.Machine12","SELECT System_status FROM dbo.Machine13"};


            string[] import_time = new string[13] { "SELECT System_time FROM dbo.Machine1", "SELECT System_time FROM dbo.Machine2", "SELECT System_time FROM dbo.Machine3",
            "SELECT System_time FROM dbo.Machine4",
        "SELECT System_time FROM dbo.Machine5","SELECT System_time FROM dbo.Machine6","SELECT System_time FROM dbo.Machine7",
            "SELECT System_time FROM dbo.Machine8","SELECT System_time dbo.Machine8",
        "SELECT System_time FROM dbo.Machine10","SELECT System_time FROM dbo.Machine11","SELECT System_time FROM dbo.Machine12","SELECT System_time FROM dbo.Machine13",};


            string[] machines = new string[13] {"dbo.Machine1","dbo.Machine2","dbo.Machine3","dbo.Machine4","dbo.Machine5","dbo.Machine6","dbo.Machine7","dbo.Machine9","dbo.Machine14",
        "dbo.Machine10","dbo.Machine11","dbo.Machine12","dbo.Machine13"};



            string[] break_down_machines = new string[13] { "SELECT State_break_down  FROM dbo.Machine1","SELECT State_break_down  FROM dbo.Machine2",
        "SELECT State_break_down  FROM dbo.Machine3","SELECT State_break_down  FROM dbo.Machine4","SELECT State_break_down  FROM dbo.Machine5",
        "SELECT State_break_down  FROM dbo.Machine6","SELECT State_break_down  FROM dbo.Machine7","SELECT State_break_down  FROM dbo.Machine9",
        "SELECT State_break_down  FROM dbo.GM_Ish","SELECT State_break_down  FROM dbo.GM_Tsh","SELECT State_break_down  FROM dbo.Machine11",
        "SELECT State_break_down  FROM dbo.Machine12","SELECT State_break_down  FROM dbo.Machine13"};

            string[] change_over_machines = new string[13] { "SELECT State_Change_over  FROM dbo.Machine1"," SELECT State_Change_over  FROM dbo.Machine2",
        "SELECT State_Change_over  FROM dbo.Machine3","SELECT State_Change_over  FROM dbo.Machine4","SELECT State_Change_over  FROM dbo.Machine5",
        "SELECT State_Change_over  FROM dbo.Machine6","SELECT State_Change_over  FROM dbo.Machine7","SELECT State_Change_over  FROM dbo.Machine9",
        "SELECT State_Change_over  FROM dbo.GM_Ish","SELECT State_Change_over  FROM dbo.GM_Tsh","SELECT State_Change_over  FROM dbo.Machine11",
        "SELECT State_Change_over  FROM dbo.Machine12","SELECT State_Change_over  FROM dbo.Machine13"};

            string[] planned_stop_machines = new string[13] { "SELECT State_Planned_stop  FROM dbo.Machine1"," SELECT State_Planned_stop  FROM dbo.Machine2",
        "SELECT State_Planned_stop  FROM dbo.Machine3","SELECT State_Planned_stop  FROM dbo.Machine4","SELECT State_Planned_stop  FROM dbo.Machine5",
        "SELECT State_Planned_stop  FROM dbo.Machine6","SELECT State_Planned_stop  FROM dbo.Machine7","SELECT State_Planned_stop  FROM dbo.Machine9",
        "SELECT State_Planned_stop  FROM dbo.GM_Ish","SELECT State_Planned_stop  FROM dbo.GM_Tsh","SELECT State_Planned_stop  FROM dbo.Machine11",
        "SELECT State_Planned_stop  FROM dbo.Machine12","SELECT State_Planned_stop  FROM dbo.Machine13"};

            string[] timestamp = new string[13] { "SELECT TimeStamp from dbo.Machine1","SELECT TimeStamp from dbo.Machine2","SELECT TimeStamp from dbo.Machine3","SELECT TimeStamp FROM dbo.Machine4",
           "SELECT TimeStamp  FROM dbo.Machine5",
        "SELECT TimeStamp  FROM dbo.Machine6","SELECT TimeStamp  FROM dbo.Machine7","SELECT TimeStamp  FROM dbo.Machine9",
        "SELECT TimeStamp  FROM dbo.GM_Ish","SELECT TimeStamp  FROM dbo.GM_Tsh","SELECT TimeStamp  FROM dbo.Machine11",
        "SELECT TimeStamp  FROM dbo.Machine12","SELECT TimeStamp  FROM dbo.Machine13" };



             void import_sql_values(int i)
            {
                switch (i)
                {
                    case 0:
                        {
                            instance.sql_importing(connection_string,break_down_machines[i], machines[i], MachineStatus0, "State_break_down");
                            instance.sql_importing(connection_string, planned_stop_machines[i], machines[i], MachinePlannedStop0, "State_planned_stop");
                            instance.sql_importing(connection_string, change_over_machines[i], machines[i], MachineChangeOver0, "State_change_over");
                            instance.sql_importing(connection_string, timestamp[i], machines[i], MachineTime0, "TimeStamp");
                            instance.Shortenstring(16, MachineTime1,short_time);
                            instance.export_list(MachineTime0,MachineStatus0,MachinePlannedStop0,MachineChangeOver0,machines[i]);

                        }
                        break;
                    case 1:
                        {
                            instance.sql_importing(connection_string, break_down_machines[i], machines[i], MachineStatus1, "State_break_down");
                            instance.sql_importing(connection_string, planned_stop_machines[i], machines[i], MachinePlannedStop1, "State_planned_stop");
                            instance.sql_importing(connection_string, change_over_machines[i], machines[i], MachineChangeOver1, "State_change_over");
                            instance.sql_importing(connection_string, timestamp[i], machines[i], MachineTime1, "TimeStamp");
                            instance.Shortenstring(16, MachineTime1, short_time);
                            instance.export_list(MachineTime1, MachineStatus1,MachinePlannedStop1, MachineChangeOver1, machines[i]);

                        }
                        break;
                    case 2:
                        {
                            instance.sql_importing(connection_string, break_down_machines[i], machines[i], MachineStatus2, "State_break_down");
                            instance.sql_importing(connection_string, planned_stop_machines[i], machines[i], MachinePLannedStop2, "State_planned_stop");
                            instance.sql_importing(connection_string, change_over_machines[i], machines[i], MachineChangeOver2, "State_change_over");
                            instance.sql_importing(connection_string, timestamp[i], machines[i], MachineTime2, "TimeStamp");                        
                            instance.Shortenstring(16, MachineTime2, short_time);
                            instance.export_list(MachineTime2, MachineStatus2, MachinePLannedStop2, MachineChangeOver2, machines[i]);
                        }
                        break;
                    case 3:
                        {
                            instance.sql_importing(connection_string, break_down_machines[i], machines[i], MachineStatus3, "State_break_down");
                            instance.sql_importing(connection_string, planned_stop_machines[i], machines[i], MachinePLannedStop3, "State_planned_stop");
                            instance.sql_importing(connection_string, change_over_machines[i], machines[i], MachineChangeOver3, "State_change_over");
                            instance.sql_importing(connection_string, timestamp[i], machines[i], MachineTime3, "TimeStamp");
                            instance.Shortenstring(16, MachineTime3, short_time);
                            instance.export_list(MachineTime3, MachineStatus3, MachinePLannedStop3, MachineChangeOver3, machines[i]);
                        }
                        break;
                    case 4:
                        {
                            instance.sql_importing(connection_string, break_down_machines[i], machines[i], MachineStatus4, "State_break_down");
                            instance.sql_importing(connection_string, planned_stop_machines[i], machines[i], MachinePLannedStop4, "State_planned_stop");
                            instance.sql_importing(connection_string, change_over_machines[i], machines[i], MachineChangeOver4, "State_change_over");
                            instance.sql_importing(connection_string, timestamp[i], machines[i], MachineTime4, "TimeStamp");
                            instance.Shortenstring(16, MachineTime4, short_time);
                            instance.export_list(MachineTime4, MachineStatus4, MachinePLannedStop4, MachineChangeOver4, machines[i]);
                        }
                        break;
                    case 5:
                        {
                            instance.sql_importing(connection_string, break_down_machines[i], machines[i], MachineStatus5, "State_break_down");
                            instance.sql_importing(connection_string, planned_stop_machines[i], machines[i], MachinePLannedStop5, "State_planned_stop");
                            instance.sql_importing(connection_string, change_over_machines[i], machines[i], MachineChangeOver5, "State_change_over");
                            instance.sql_importing(connection_string, timestamp[i], machines[i], MachineTime5, "TimeStamp");
                            instance.Shortenstring(16, MachineTime5, short_time);
                            instance.export_list(MachineTime5, MachineStatus5, MachinePLannedStop5, MachineChangeOver5, machines[i]);
                        }
                        break;
                    case 6:
                        {
                            instance.sql_importing(connection_string, break_down_machines[i], machines[i], MachineStatus6, "State_break_down");
                            instance.sql_importing(connection_string, planned_stop_machines[i], machines[i], MachinePLannedStop6, "State_planned_stop");
                            instance.sql_importing(connection_string, change_over_machines[i], machines[i], MachineChangeOver6, "State_change_over");
                            instance.sql_importing(connection_string, timestamp[i], machines[i], MachineTime6, "TimeStamp");
                            instance.Shortenstring(16, MachineTime6, short_time);
                            instance.export_list(MachineTime6, MachineStatus6, MachinePLannedStop6, MachineChangeOver6, machines[i]);
                        }
                        break;
                    case 7:
                        {
                            instance.sql_importing(connection_string, break_down_machines[i], machines[i], MachineStatus7, "State_break_down");
                            instance.sql_importing(connection_string, planned_stop_machines[i], machines[i], MachinePLannedStop7, "State_planned_stop");
                            instance.sql_importing(connection_string, change_over_machines[i], machines[i], MachineChangeOver7, "State_change_over");
                            instance.sql_importing(connection_string, timestamp[i], machines[i], MachineTime7, "TimeStamp");
                            instance.Shortenstring(16, MachineTime7, short_time);
                            instance.export_list(MachineTime7, MachineStatus7, MachinePLannedStop7, MachineChangeOver7, machines[i]);
                        }
                        break;
                    case 8:
                        {
                            instance.sql_importing(connection_string, break_down_machines[i], machines[i], MachineStatus8, "State_break_down");
                            instance.sql_importing(connection_string, planned_stop_machines[i], machines[i], MachinePLannedStop8, "State_planned_stop");
                            instance.sql_importing(connection_string, change_over_machines[i], machines[i], MachineChangeOver8, "State_change_over");
                            instance.sql_importing(connection_string, timestamp[i], machines[i], MachineTime8, "TimeStamp");
                            instance.Shortenstring(16, MachineTime8, short_time);
                            instance.export_list(MachineTime8, MachineStatus8, MachinePLannedStop8, MachineChangeOver8, machines[i]);
                        }
                        break;
                    case 9:
                        {
                            instance.sql_importing(connection_string, break_down_machines[i], machines[i], MachineStatus9, "State_break_down");
                            instance.sql_importing(connection_string, planned_stop_machines[i], machines[i], MachinePLannedStop9, "State_planned_stop");
                            instance.sql_importing(connection_string, change_over_machines[i], machines[i], MachineChangeOver9, "State_change_over");
                            instance.sql_importing(connection_string, timestamp[i], machines[i], MachineTime9, "TimeStamp");
                            instance.Shortenstring(16, MachineTime9, short_time);
                            instance.export_list(MachineTime9, MachineStatus9, MachinePLannedStop9, MachineChangeOver9, machines[i]);
                        }
                        break;
                    case 10:
                        {
                            instance.sql_importing(connection_string, break_down_machines[i], machines[i], MachineStatus10, "State_break_down");
                            instance.sql_importing(connection_string, planned_stop_machines[i], machines[i], MachinePLannedStop10, "State_planned_stop");
                            instance.sql_importing(connection_string, change_over_machines[i], machines[i], MachineChangeOver10, "State_change_over");
                            instance.sql_importing(connection_string, timestamp[i], machines[i], MachineTime10, "TimeStamp");
                            instance.Shortenstring(16, MachineTime10, short_time);
                            instance.export_list(MachineTime10, MachineStatus10, MachinePLannedStop10, MachineChangeOver10, machines[i]);
                        }
                        break;
                    case 11:
                        {
                            instance.sql_importing(connection_string, break_down_machines[i], machines[i], MachineStatus11, "State_break_down");
                            instance.sql_importing(connection_string, planned_stop_machines[i], machines[i], MachinePLannedStop11, "State_planned_stop");
                            instance.sql_importing(connection_string, change_over_machines[i], machines[i], MachineChangeOver11, "State_change_over");
                            instance.sql_importing(connection_string, timestamp[i], machines[i], MachineTime11, "TimeStamp");
                            instance.Shortenstring(16, MachineTime11, short_time);
                            instance.export_list(MachineTime11, MachineStatus11, MachinePLannedStop11, MachineChangeOver11, machines[i]);
                        }
                        break;
                    case 12:
                        {
                            instance.sql_importing(connection_string, break_down_machines[i], machines[i], MachineStatus12, "State_break_down");
                            instance.sql_importing(connection_string, planned_stop_machines[i], machines[i], MachinePLannedStop12, "State_planned_stop");
                            instance.sql_importing(connection_string, change_over_machines[i], machines[i], MachineChangeOver12, "State_change_over");
                            instance.sql_importing(connection_string, timestamp[i], machines[i], MachineTime12, "TimeStamp");
                            instance.Shortenstring(16, MachineTime12, short_time);
                            instance.export_list(MachineTime12, MachineStatus12, MachinePLannedStop12, MachineChangeOver12, machines[i]);
                        }
                        break;
                }
            }


          
            DateTime now = new DateTime();
            now = DateTime.Now;

            int[] x_color = new int[480];
            int[] x = new int[480];
            int[] x_color2 = new int[480];
            int[] x2 = new int[480];
            int[] x_color3 = new int[480];
            int[] x3 = new int[480];
            int[] x_color4 = new int[480];
            int[] x4 = new int[480];
            int[] x_color5 = new int[480];
            int[] x5 = new int[480];
            int[] x_color6 = new int[480];
            int[] x6 = new int[480];
            int[] x_color7 = new int[480];
            int[] x7 = new int[480];
            int[] x_color8 = new int[480];
            int[] x8 = new int[480];
            int[] x_color9 = new int[480];
            int[] x9 = new int[480];
            int[] x_color10 = new int[480];
            int[] x10 = new int[480];
            int[] x_color11 = new int[480];
            int[] x11 = new int[480];
            int[] x_color12 = new int[480];
            int[] x12 = new int[480];
            int x_temp = 1350;
            int[] x_color13 = new int[480];
            int[] x13 = new int[480];

          
         

            void plot_sql_values(int k)
            {
                switch(k)
                {
                    case 0:
                        {
                            instance.sql_plot(MachineTime0, MachineStatus0, MachinePlannedStop0, MachineChangeOver0, x_temp, x_color, x);
                        }
                        break;
                    case 1:
                        {
                            instance.sql_plot(MachineTime1, MachineStatus1, MachinePlannedStop1, MachineChangeOver1, x_temp, x_color2, x2);
                        }
                        break;
                    case 2:
                        {
                            instance.sql_plot(MachineTime2, MachineStatus2, MachinePLannedStop2, MachineChangeOver2, x_temp, x_color3, x3);
                        }
                        break;
                    case 3:
                        {
                            instance.sql_plot(MachineTime3, MachineStatus3, MachinePLannedStop3, MachineChangeOver3, x_temp, x_color4, x4);
                        }
                        break;
                    case 4:
                        {
                            instance.sql_plot(MachineTime4, MachineStatus4, MachinePLannedStop4, MachineChangeOver4, x_temp, x_color5, x5);
                        }
                        break;
                    case 5:
                        {
                               instance.sql_plot(MachineTime5, MachineStatus5, MachinePLannedStop5, MachineChangeOver5, x_temp, x_color6, x6);
                        }
                        break;
                    case 6:
                        {
                            instance.sql_plot(MachineTime6, MachineStatus6, MachinePLannedStop6, MachineChangeOver6, x_temp, x_color7, x7);
                        }
                        break;
                    case 7:
                        {
                            MachineTime7.RemoveAt(0);
                           instance.sql_plot(MachineTime7, MachineStatus7, MachinePLannedStop7, MachineChangeOver7, x_temp, x_color8, x8);
                        }
                        break;
                    case 8:
                        {
                           instance.sql_plot(MachineTime8, MachineStatus8, MachinePLannedStop8, MachineChangeOver8, x_temp, x_color9, x9);
                        }
                        break;
                    case 9:
                        {
                            MachineTime9.RemoveAt(0);
                            instance.sql_plot(MachineTime9, MachineStatus9, MachinePLannedStop9, MachineChangeOver9, x_temp, x_color10, x10);
                        }
                        break;
                    case 10:
                        {
                            MachineTime10.RemoveAt(0);
                            MachineTime10.RemoveAt(0);
                            MachineTime10.RemoveAt(0);
                            instance.sql_plot(MachineTime10, MachineStatus10, MachinePLannedStop10, MachineChangeOver10, x_temp, x_color11, x11);
                        }
                        break;
                    case 11:
                        {
                            MachineTime11.RemoveAt(0);
                            MachineTime11.RemoveAt(0);
                            MachineTime11.RemoveAt(0);
                            MachineTime11.RemoveAt(0);
                            MachineTime11.RemoveAt(0);
                            MachineTime11.RemoveAt(0);
                            MachineTime11.RemoveAt(0);
                            MachineTime11.RemoveAt(0);
                            MachineTime11.RemoveAt(0);
                            instance.sql_plot(MachineTime11, MachineStatus11, MachinePLannedStop11, MachineChangeOver11, x_temp, x_color12, x12);
                        }
                        break;
                    case 12:
                        {
                            MachineStatus12.RemoveAt(0);
                            instance.sql_plot(MachineTime12, MachineStatus12, MachinePLannedStop12, MachineChangeOver12, x_temp, x_color13, x13);
                        }
                        break;


                }
            }

       


            for (int i = 0; i <=2; i++)
            {
                import_sql_values(i);
                plot_sql_values(i);

            }


            


            var model = new HomeVM
            {
                position_x = x,
                color_x = x_color,
                position_x2 = x2,
                color_x2 = x_color2,
                position_x3 = x3,
                color_x3 = x_color3,
                position_x4 = x4,
                color_x4 = x_color4,
                position_x5 = x5,
                color_x5 = x_color5,
                position_x6 = x6,
                color_x6 = x_color6,
                position_x7 = x7,
                color_x7 = x_color7,
                position_x8 = x8,
                color_x8 = x_color8,
                position_x9 = x9,
                color_x9 = x_color9,
                position_x10 = x10,
                color_x10 = x_color10,
                position_x11 = x11,
                color_x11 = x_color11,
                position_x12 = x12,
                color_x12 = x_color12,
                position_x13 = x13,
                color_x13 = x_color13,



            };





            return View(model);
        }
    }
}