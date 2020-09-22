using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace Web1.Model
{
    public class Sql_import
    {
        public void sql_importing(string connection_string, string command, string machine_name, List<string> machine_list, string column_name)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                SqlDataAdapter da = new SqlDataAdapter(command, connection);
                DataSet ds = new DataSet();
                da.Fill(ds, machine_name);


                foreach (DataRow row in ds.Tables[machine_name].Rows)
                {
                    machine_list.Add(row[column_name].ToString());
                }
                machine_list.RemoveAt(0);

            }
        }
        public void sql_plot(List<string> machine_list0, List<string> machine_list1, List<string> machine_list2, List<string> machine_list3, int x_temp, int[] x_color, int[] x)
        {
            double control = 0;
            double total2;
            double total;

            DateTime now = new DateTime();
            now = DateTime.Now;



            List<DateTime> dates = machine_list0.Select(date => DateTime.Parse(date)).ToList();
            List<int> break_down = machine_list1.Select(s => int.Parse(s)).ToList();
            List<int> planned_stop = machine_list2.Select(s => int.Parse(s)).ToList();
            List<int> change_over = machine_list3.Select(s => int.Parse(s)).ToList();

            using (var e1 = dates.GetEnumerator())
            using (var e2 = break_down.GetEnumerator())
            using (var e3 = planned_stop.GetEnumerator())
            using (var e4 = change_over.GetEnumerator())
            {
               

                while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext())
                {
                    x_temp = 1110;

                    for (int i = 0; i < 480; i++)
                    {
                        now = now.AddMinutes(control);
                        now = now.AddSeconds(-now.Second);
                        now = now.AddMilliseconds(-now.Millisecond);
                        now = now.AddSeconds(e1.Current.Second);
                        now = now.AddMilliseconds(e1.Current.Millisecond);


                        total2 = e1.Current.TimeOfDay.TotalSeconds;
                        total2 = Math.Floor(total2);

                        total = now.TimeOfDay.TotalSeconds;
                        total = Math.Floor(total);

                        if (total == total2)
                        {
                            x[i] = x_temp;
                            if(e2.Current==1)
                            {
                                x_color[i] = 1;
                            }
                            else if(e3.Current ==1)
                            {
                                x_color[i] = 3;
                            }
                            else if(e4.Current ==1)
                            {
                                x_color[i] = 2;
                            }
                            else
                            {
                                x_color[i] = 10;
                            }

                        }

                        now = DateTime.Now;
                        control = control - 1;


                        x_temp = x_temp - 2;
                    }
                    control = 0;
                }




            }
        }
        public void  Shortenstring(int maxLength,List<string> time,string[] shorter_date)
        {
           
            int i = 0;
            
            using (var e1 = time.GetEnumerator())
            {
                while(e1.MoveNext())
                {
                   
                    shorter_date[i]=e1.Current.Substring(0, Math.Min(e1.Current.Length, maxLength));
                    i++;
                }
            }
            time = ((string[])shorter_date).ToList();
        }

        public void export_list(List<string> export_time,List<string> export_breakdown,List<string> export_plannedstop,List<string> export_changeover,string machine)
        {

            string newdate;

            DateTime Right_Now = new DateTime();

            DateTime Shift_1 = new DateTime();
            DateTime Shift_2 = new DateTime();
            DateTime Shift_3 = new DateTime();


            Right_Now = DateTime.Now;
            Right_Now = Right_Now.AddMilliseconds(-Right_Now.Millisecond);
            Right_Now = Right_Now.AddSeconds(-Right_Now.Second);

            Shift_1 = Right_Now;
            Shift_1 = Right_Now.AddMinutes(-Right_Now.Minute);
            Shift_1 = Shift_1.AddHours(-Shift_1.Hour);

            
            Shift_3 = Shift_3.AddHours(22);
            Shift_2 = Shift_1.AddHours(14);
            Shift_1 = Shift_1.AddHours(6);
            

            newdate = Right_Now.ToString();
            

            newdate = newdate.Replace(":", "-");
            newdate = newdate.Replace(" ", "_");

            List<string> Status = new List<string>();

            List<int> break_down = export_breakdown.Select(s => int.Parse(s)).ToList();
            List<int> planned_stop = export_plannedstop.Select(s => int.Parse(s)).ToList();
            List<int> change_over = export_changeover.Select(s => int.Parse(s)).ToList();

            using (var e2 = break_down.GetEnumerator())
            using (var e3 = planned_stop.GetEnumerator())
            using (var e4 = change_over.GetEnumerator())
            {
                while (e2.MoveNext() && e3.MoveNext() && e4.MoveNext())
                {
                    if (e2.Current == 1)
                    {
                        Status.Add("1;");
                    }
                    else if (e3.Current == 1)
                    {
                        Status.Add("2;");
                    }
                    else if (e4.Current == 1)
                    {
                        Status.Add("3;");
                    }
                    else
                    {
                        Status.Add("0;");
                    }
                }





            }

            machine = machine.Remove(0, 4);


            if (Right_Now == Shift_1)
            {
                using (StreamWriter sw = File.CreateText(@"\\synology\002_UTR\REPORTS\INTERNAL\Status Linii\" + machine + @"\1_" + newdate + "_" + machine + ".txt"))
                {
                    for (int i = 0; i < export_time.Count; i++)
                    {
                        sw.WriteLine("{0}" + ";" + "{1}", export_time[i], Status[i]);
                    }
                }
            }
            else if(Right_Now == Shift_2)
            {
                using (StreamWriter sw = File.CreateText(@"\\synology\002_UTR\REPORTS\INTERNAL\Status Linii\" + machine + @"\2_" + newdate + "_" + machine + ".txt"))
                {
                    for (int i = 0; i < export_time.Count; i++)
                    {
                        sw.WriteLine("{0}" + ";" + "{1}", export_time[i], Status[i]);
                    }
                }
            }
            else if(Right_Now == Shift_3)
            {
                using (StreamWriter sw = File.CreateText(@"\\synology\002_UTR\REPORTS\INTERNAL\Status Linii\" + machine + @"\3_" + newdate + "_" + machine + ".txt"))
                {
                    for (int i = 0; i < export_time.Count; i++)
                    {
                        sw.WriteLine("{0}" + ";" + "{1}", export_time[i], Status[i]);
                    }
                }
            }
        }


    }
} 
