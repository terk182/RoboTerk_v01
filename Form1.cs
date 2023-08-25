using RoboTerk_v01.models;
using RoboTerk_v01.services;
using System.IO.Ports;
using System.Net.WebSockets;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RoboTerk_v01
{
    public partial class Form1 : Form
    {
        Kinematics _Kinematics;
        SerialPort serialPort = new SerialPort();
        string recievedData;
        double x  = 180;
        double y  = 0;
        double z  = 0;

        string[] gcode_list;
        double x_count = 180;
        bool check_linit = false;
        int check_linit_count = 0;
        int samping = 7;
        double y_count = 0;
        double z_count = 0;
        double speed_to_home_x = 800;
        double speed_to_home_y = 1200;
        double speed_to_home_z = 800;
        int loop_run = 1;
        List<Gcode> _Gcode_list_cmd = new List<Gcode>();
        List<string> _Gcode_list_check = new List<string>();
        int tk_sl_z = 110;
        int tk_sl_x = 90;
        int tk_sl_y = 0;
        int row_num = 1;
        string check_return_ok = "";
        StringBuilder cmd_save = new StringBuilder();
        string[] cmd_list;
        double step { get; set; } = 1;
        int r = 200;
        int L1 = 135;
        int L2 = 150;

        delegate void SetTextCallback(string text);
        int L1_angle_start = 180;
        int L2_angle_start = 90;
        public Form1()
        {
            _Kinematics = new Kinematics(135, 157, 156, 125, 125, 420, 50);
            InitializeComponent();
        }



        private void bt_connect_Click(object sender, EventArgs e)
        {
            if (bt_connect.Text == "Connect")
            {
                ser_connect();
                bt_connect.BackColor = Color.Green;
                bt_connect.Text = "Disconnect";
                Thread.Sleep(1000);
                reset_cmd();
                Thread.Sleep(1000);
                clear_cmd();
            }
            else
            {
                serialPort.Close();
                bt_connect.BackColor = Color.Gray;
                bt_connect.Text = "Connect";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar_speed.Value = 1200;
            speed_txt.Text = trackBar_speed.Value.ToString();
            x_deg_txt.Text = x.ToString();
            y_deg_txt.Text = y.ToString();
            z_deg_txt.Text = z.ToString();

            x_position_txt.Text = "200";
            y_position_txt.Text = "210";
            z_position_txt.Text = "50";

            link1_deg_txt.Text = x.ToString();
            link2_deg_txt.Text = z.ToString();
            base_deg_txt.Text = y.ToString();
            trackBar_z_sl.Value = tk_sl_z;
            trackBar_x_sl.Value = tk_sl_x;
            trackBar_y_sl.Value = tk_sl_y;

            bt_ik_run.Enabled = false;
            //trackBar_x_sl.Enabled = false;
            //trackBar_y_sl.Enabled = false;
            //trackBar_z_sl.Enabled = false;
            string[] ports = SerialPort.GetPortNames();
            //Console.WriteLine("The following serial ports were found:");            
            foreach (string port in ports)
            {
                //Console.WriteLine(port); // Display each port name to the console.
                //cBoxComPort.Items.Add(port);
                comboBox1.Items.Add(port);
            }
            //textBox1.Text = r.ToString();
            //Link1.Text = L1.ToString();
            //Link2.Text = L2.ToString();
            //l1_angle.Text = L1_angle_start.ToString();
        }

        private void trackBar_speed_Scroll(object sender, EventArgs e)
        {
            speed_txt.Text = trackBar_speed.Value.ToString();
        }

        private void bt_1x_Click(object sender, EventArgs e)
        {
            step = 1;
        }

        private void bt_10x_Click(object sender, EventArgs e)
        {
            step = 10;
        }


        private void ser_connect()
        {
            try
            {
                serialPort.PortName = comboBox1.Text;
                serialPort.BaudRate = 115200;
                serialPort.DataBits = Convert.ToInt32(8);
                serialPort.StopBits = StopBits.One;
                serialPort.Parity = Parity.None;
                serialPort.Open(); // Open port.
                serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataRecieved);
                // serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataRecieved);


                 send("$X");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }

        private void send(String message, bool type = false)
        {
            


            if (type == false)
            {
                try
                {
                    serialPort.Write(message + "\n\r");

                }
                catch
                {

                }

            }
            else
            {

                _Gcode_list_check.Add(message);
                if (_Gcode_list_check.Count == 1)
                {
                    try
                    {
                        send_ik(message);
                        

                    }
                    catch
                    {

                    }


                }
                else
                {
                    if(message.Contains("MS") || message.Contains("P4"))
                    {
                        serialPort.Write(message + "\n\r");
                    }
                    else
                    {
                        sub_command(_Gcode_list_check);
                    }
                   
                }
            }





        }


        private async Task send_ik(String message, bool type = false)
        {
            var new_cmd_value = decode_gocde(message);

            var data = _Kinematics.moveToPos(new_cmd_value.x, new_cmd_value.y, new_cmd_value.z);
            serialPort.Write(String.Format("{0}X{1}Y{2}Z{3}F{4}", new_cmd_value.h, data.theta1, data.baseAngle, data.theta2, new_cmd_value.f) + "\n\r");


        }

        private async Task send_gcode_list(List<Gcode> gcode)
        {



        }



        private void sub_command(List<string> cmd)
        {

            var num = cmd.Count - 1;
            var new_cmd = cmd[num];
            //  output_txt.Text += String.Format("cmd new => {0} \n\r", new_cmd);
            var old_cmd = cmd[num - 1];
            // output_txt.Text += String.Format("cmd old => {0} \n\r", old_cmd);


            sub_gcode_cmd(new_cmd, old_cmd);














        }


        private void sub_gcode_cmd(string new_cmd, string old_cmd)
        {
            var new_cmd_value = decode_gocde(new_cmd);
            var old_cmd_value = decode_gocde(old_cmd);

            var loop = Math.Abs(Math.Abs(new_cmd_value.y) - Math.Abs(old_cmd_value.y)) / samping;
            var direct = new_cmd_value.y - old_cmd_value.y;

            bool di_check = direct > 0? true : false;

            if (direct == 0) {

                send_ik(new_cmd);
                return;
            }
            if (loop < 1)
            {
                try
                {
                    serialPort.Write(new_cmd + "\n\r");
                }
                catch
                {

                }

            }
            else
            {
                StringBuilder txt = new StringBuilder();
                output_txt.Text += "";
               var loop_value = old_cmd_value.y;
                for (int i = 0; i < samping; i++)
                {
                    if (di_check == true)
                    {
                        loop_value = loop_value + loop;
                    }
                    else
                    {
                        loop_value = loop_value - loop;
                    }
                    var data = _Kinematics.moveToPos(new_cmd_value.x, loop_value, new_cmd_value.z);
                    //serialPort.Write(String.Format("{0}X{1}Y{2}Z{3}F{4}", new_cmd_value.h, data.theta1, data.baseAngle, data.theta2, new_cmd_value.f) + "\n\r");
                    txt.Append(String.Format("{0}X{1}Y{2}Z{3}F{4}\n\r", new_cmd_value.h, data.theta1, data.baseAngle, data.theta2, new_cmd_value.f));

        
                    
                }
                serialPort.Write(txt.ToString());

                Thread.Sleep(3000);

                output_txt.Text += txt.ToString();
            }



        }


        public Cartesian decode_gocde(string cmd)
        {
            var cmd_low = cmd.ToUpper();
            var _Cartesian = new Cartesian();
            var row_gcode_h = cmd_low.Split("G");
            var row_gcode_x = cmd_low.Split("X");
            var row_gcode_hy = row_gcode_x[1].Split("Y");
            var row_gcode_hz = row_gcode_hy[1].Split("Z");
            var row_gcode_hf = row_gcode_hz[1].Split("F");
            _Cartesian.h = row_gcode_x[0];
            _Cartesian.x = double.Parse(row_gcode_hy[0]);
            _Cartesian.y = double.Parse(row_gcode_hz[0]);
            _Cartesian.z = double.Parse(row_gcode_hf[0]);
            _Cartesian.f = double.Parse(row_gcode_hf[1]);
            return _Cartesian;
        }
        private void serialPort_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {

            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            check_return_ok = indata;
            SetText(indata);

        }
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            cmd_list = new string[] { text };
            if (output_txt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                output_txt.AppendText(String.Format("Robot Arm {0} => {1} \n\r", DateTime.Now, text));
            }


        }

        private void bt_01x_Click(object sender, EventArgs e)
        {
            step = 0.1;
        }

        private void bt_x_add_Click(object sender, EventArgs e)
        {
            send(String.Format("$J=G91G21X{0}F{1}", step, trackBar_speed.Value));

            x_count += step;
            x_deg_txt.Text = x_count.ToString("00.00");
        }
        private void bt_x_sub_Click(object sender, EventArgs e)
        {
            send(String.Format("$J=G91G21X-{0}F{1}", step, trackBar_speed.Value));


            x_count -= step;
            x_deg_txt.Text = x_count.ToString("00.00");
        }

        private void bt_z_add_Click(object sender, EventArgs e)
        {
            send(String.Format("$J=G91G21Z{0}F{1}", step, trackBar_speed.Value));

            z_count += step;
            z_deg_txt.Text = z_count.ToString("00.00");
        }

        private void bt_z_sub_Click(object sender, EventArgs e)
        {
             send(String.Format("$J=G91G21Z-{0}F{1}", step, trackBar_speed.Value));


            z_count -= step;
            z_deg_txt.Text = z_count.ToString("00.00");
        }

        private void bt_y_add_Click(object sender, EventArgs e)
        {
            send(String.Format("$J=G91G21Y{0}F{1}", step, trackBar_speed.Value));

            y_count += step;
            y_deg_txt.Text = y_count.ToString("00.00");
        }

        private void bt_y_sub_Click(object sender, EventArgs e)
        {
             send(String.Format("$J=G91G21Y-{0}F{1}", step, trackBar_speed.Value));


            y_count -= step;
            y_deg_txt.Text = y_count.ToString("00.00");
        }

        private void bt_gripper_on_Click(object sender, EventArgs e)
        {
            trackBar_gripper_position.Value = 510;
            send(String.Format("M3S{0}", trackBar_gripper_position.Value));
        }

        private void bt_gripper_off_Click(object sender, EventArgs e)
        {
            trackBar_gripper_position.Value = 900;
            send(String.Format("M3S{0}", trackBar_gripper_position.Value));
        }

        private void trackBar_gripper_position_Scroll(object sender, EventArgs e)
        {
            send(String.Format("M3S{0}", trackBar_gripper_position.Value));
        }

        private void bt_save_deg_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "NO";
            dataGridView1.Columns[1].Name = "G-Code";
            dataGridView1.Columns[2].Name = "IK";
            _Gcode_list_cmd.Add(new Gcode
            {
                gcode_cmd = String.Format("G1X{0}Y{1}Z{2}F{3}", x_deg_txt.Text, y_deg_txt.Text, z_deg_txt.Text, trackBar_speed.Value),
                ik = false,
            });

            // 
            string[] row = new string[] { String.Format("{0}", row_num), String.Format("G1X{0},Y{1},Z{2},F{3}", x_deg_txt.Text, y_deg_txt.Text, z_deg_txt.Text, trackBar_speed.Value), "" };
            dataGridView1.Rows.Add(row);
            row_num++;
            //row = new string[] { "2", "Product 2", "2000" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "3", "Product 3", "3000" };
            //dataGridView1.Rows.Add(row);
            //row = new string[] { "4", "Product 4", "4000" };
            //dataGridView1.Rows.Add(row);
        }

        private void bt_add_gripper_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "NO";
            dataGridView1.Columns[1].Name = "G-Code";
            //dataGridView1.Columns[2].Name = "Product Price"; //gcode_list
            _Gcode_list_cmd.Add(new Gcode
            {
                gcode_cmd = String.Format("M3S{0}", trackBar_gripper_position.Value),
                ik = false,

            });

            string[] row = new string[] { String.Format("{0}", row_num), String.Format("M3S{0}", trackBar_gripper_position.Value), "" };
            dataGridView1.Rows.Add(row);
            row_num++;
        }

        private void bt_send_cmd_Click(object sender, EventArgs e)
        {
            send(textBox_cmd.Text);
            textBox_cmd.Text = "";
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            reset_cmd();
            Thread.Sleep(1000);
            clear_cmd();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            clear_cmd();
        }

        private void bt_default_position_Click(object sender, EventArgs e)
        {
            // var ff = send(String.Format("$J=G91G21Y{0}F{1}", 400, speed_to_home_y));
            send("G10P0L20Y0");
            Thread.Sleep(1000);
            send("G10P0L20X180");
            Thread.Sleep(1000);
            send("G10P0L20Z0");
            Thread.Sleep(1000);
            send(String.Format("G0Z-200"));
            timer_check_arm.Enabled = true;
            timer_check_arm.Start();
            timer_check_arm.Interval = 500;
        }



        private void timer_check_home_Tick(object sender, EventArgs e)
        {
            output_txt.BackColor = Color.Yellow;
            string cmd = cmd_list.LastOrDefault();
            if (cmd.Contains("[MSG:Reset to continue]"))
            {
                reset_cmd();
                Thread.Sleep(1000);
                clear_cmd();
                Thread.Sleep(1000);
                send("G10P0L20Y0");
                Thread.Sleep(1000);
                send(String.Format("G0Y-{0}", 155));
                check_linit_count++;
            }

            if (check_linit_count > 1)
            {
                if (cmd.Contains("ok"))
                {
                    timer_check_home.Stop();
                    timer_check_home.Enabled = false;
                    output_txt.BackColor = Color.White;

                    check_linit_count = 0;
                    send("G10P0L20Y0");
                    Thread.Sleep(1000);
                    send("G10P0L20X180");
                    Thread.Sleep(1000);
                    send("G10P0L20Z0");
                    x = 180;
                    y = 0;
                    z = 0;
                    x_deg_txt.Text = x.ToString();
                    y_deg_txt.Text = y.ToString();
                    z_deg_txt.Text = z.ToString();

                    trackBar_x_sl.Enabled = true;
                    trackBar_y_sl.Enabled = true;
                    trackBar_z_sl.Enabled = true;
                    trackBar_z_sl.Maximum = tk_sl_z;
                    trackBar_z_sl.Value = tk_sl_z;
                    trackBar_y_sl.Value = tk_sl_y;
                }
            }


        }

        private void reset_cmd()
        {
            string s = Encoding.ASCII.GetString(new byte[] { 24 });
            serialPort.Write(s);
        }

        private void clear_cmd()
        {
            send("$X");
        }

        private void timer_check_arm_Tick(object sender, EventArgs e)
        {
            output_txt.BackColor = Color.Yellow;
            string cmd = cmd_list.LastOrDefault();
            if (cmd.Contains("[MSG:Reset to continue]"))
            {
                reset_cmd();
                Thread.Sleep(1000);
                clear_cmd();
                Thread.Sleep(1000);
                send("G10P0L20Z0");
                Thread.Sleep(1000);
                send(String.Format("G0Z{0}", 8));
                check_linit_count++;
            }

            if (check_linit_count > 1)
            {
                if (cmd.Contains("ok"))
                {
                    timer_check_arm.Stop();
                    timer_check_arm.Enabled = false;
                    output_txt.BackColor = Color.White;
                    Thread.Sleep(1000);
                    send(String.Format("G0X360"));
                    Thread.Sleep(1000);
                    timer_check_arm2.Enabled = true;
                    timer_check_arm2.Interval = 500;
                    timer_check_arm2.Start();
                    check_linit_count = 0;
                }
            }
        }

        private void timer_check_arm2_Tick(object sender, EventArgs e)
        {
            output_txt.BackColor = Color.Yellow;
            string cmd = cmd_list.LastOrDefault();
            if (cmd.Contains("[MSG:Reset to continue]"))
            {
                reset_cmd();
                Thread.Sleep(1000);
                clear_cmd();
                Thread.Sleep(1000);
                send("G10P0L20X0");
                Thread.Sleep(1000);
                send(String.Format("G0X-{0}", 30));
                check_linit_count++;
            }

            if (check_linit_count > 1)
            {
                if (cmd.Contains("ok"))
                {
                    timer_check_arm2.Stop();
                    timer_check_arm2.Enabled = false;
                    output_txt.BackColor = Color.White;

                    Thread.Sleep(1000);
                    send(String.Format("$J=G91G21Y{0}F{1}", 400, speed_to_home_y));
                    Thread.Sleep(1000);
                    timer_check_home.Enabled = true;
                    timer_check_home.Interval = 500;
                    timer_check_home.Start();
                    check_linit_count = 0;



                }
            }
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            send("G0X180Y0Z0");
            x = 180;
            y = 0;
            z = 0;

            trackBar_y_sl.Value = 0;
            x_deg_txt.Text = x.ToString();
            y_deg_txt.Text = y.ToString();
            z_deg_txt.Text = z.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

            y_count = trackBar_y_sl.Value;
            y_deg_txt.Text = y_count.ToString("00.00");


           send(String.Format("G1Y{0}F{1}", y_deg_txt.Text, trackBar_speed.Value));
        }

        private void trackBar_z_sl_Scroll(object sender, EventArgs e)
        {
            var position = Math.Abs(trackBar_z_sl.Value - tk_sl_z);
            z_count = position;
            z_deg_txt.Text = z_count.ToString("00.00");


            send(String.Format("G1Z{0}F{1}", position, trackBar_speed.Value));


        }

        private void trackBar_x_sl_Scroll(object sender, EventArgs e)
        {
            var position = Math.Abs(trackBar_x_sl.Value - tk_sl_x);
            x_count = Math.Abs(position - 180);
            x_deg_txt.Text = x_count.ToString("00.00");


            send(String.Format("G1X{0}F{1}", x_count, trackBar_speed.Value));
        }

        private async void bt_play_Click(object sender, EventArgs e)
        {
            int loop_run_check = loop_run;
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])//your specific tabname
            {

                for (int i = 0; i < loop_run; i++)
                { 
                    for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
                    {


                        var value1 = dataGridView1.Rows[rows].Cells[1].Value.ToString();
                        var value2 = dataGridView1.Rows[rows].Cells[2].Value.ToString();

                         send(value1, value2 == "IK" ? true : false);
                        var check = check_retun_cmd();
                        if(check == false)
                        {
                            Thread.Sleep(1000);
                        }


                    }
                }
          









                //for (int i = 0; i < loop_run; i++)
                //{
                //    foreach (var item in _Gcode_list_cmd)
                //    {
                //        await send(item.gcode_cmd, item.ik);
                //    }

                //}
                loop_run_check--;
                loop_txt.Text = String.Format("{0}", loop_run_check);
            }
            else
            {
                var txt = Gcode_input.Text;

                string[] stringSeparators = new string[] { "\r\n" };
                string[] lines = txt.Split(stringSeparators, StringSplitOptions.None);
               
                output_txt.Text = "";

                for (int i = 0; i < loop_run; i++)
                {
                    foreach (string s in lines)
                    {
                         send(s, true);

                    }
                    //clear_cmd();
                }
            }

        }


        private bool check_retun_cmd()
        {
            var result = false;
            for(int i = 0;i<1000000;i++)
            if (check_return_ok.Contains("ok"))
                {
                    result = true;
                    break;
                   
                }

            check_return_ok = "";
            return result;
        }
        private void bt_add_delay_Click(object sender, EventArgs e)
        {
            _Gcode_list_cmd.Add(new Gcode
            {
                gcode_cmd = String.Format("G4P{0}", trackBar_delay.Value),
                ik = false
            });



            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "NO";
            dataGridView1.Columns[1].Name = "G-Code";
            string[] row = new string[] { String.Format("{0}", row_num), String.Format("G4P{0}", trackBar_delay.Value), "" };
            dataGridView1.Rows.Add(row);
            row_num++;
        }

        private void bt_check_ik_Click(object sender, EventArgs e)
        {

            double x = double.Parse(x_position_txt.Text);
            double y = double.Parse(y_position_txt.Text);
            double z = double.Parse(z_position_txt.Text);
            var data = _Kinematics.moveToPos(x, y, z);
            base_deg_txt.Text = data.baseAngle.ToString();
            link1_deg_txt.Text = data.theta1.ToString();
            link2_deg_txt.Text = data.theta2.ToString();
            if (base_deg_txt.Text != "NaN" && link1_deg_txt.Text != "NaN" && link2_deg_txt.Text != "NaN")
            {
                y_deg_txt.Text = base_deg_txt.Text;
                x_deg_txt.Text = link1_deg_txt.Text;
                z_deg_txt.Text = link2_deg_txt.Text;

                z_count = data.theta2;
                x_count = data.theta1;
                y_count = data.baseAngle;
                bt_ik_run.Enabled = true;
            }


        }

        private void bt_ik_run_Click(object sender, EventArgs e)
        {
            send_ik(String.Format("G1X{0}Y{1}Z{2}F{3}", x_position_txt.Text, y_position_txt.Text, z_position_txt.Text, trackBar_speed.Value));

            //var data = send(String.Format("G1X{0}Y{1}Z{2}F{3}", x_position_txt.Text, y_position_txt.Text, z_position_txt.Text, trackBar_speed.Value), true);
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            reset_cmd();
        }

        private void bt_Cartesian_save_Click(object sender, EventArgs e)
        {
            _Gcode_list_cmd.Add(new Gcode
            {
                gcode_cmd = String.Format("G1X{0}Y{1}Z{2}F{3}", x_position_txt.Text, y_position_txt.Text, z_position_txt.Text, trackBar_speed.Value),
                ik = true
            });

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "NO";
            dataGridView1.Columns[1].Name = "G-Code";
            dataGridView1.Columns[2].Name = "IK";
            string[] row = new string[] { String.Format("{0}", row_num), String.Format("G1X{0}Y{1}Z{2}F{3}", x_position_txt.Text, y_position_txt.Text, z_position_txt.Text, trackBar_speed.Value), "IK" };
            dataGridView1.Rows.Add(row);
            row_num++;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Loop_add_Click(object sender, EventArgs e)
        {
            loop_run++;
            if (loop_run <= 0)
            {
                loop_run = 1;
            }
            loop_txt.Text = loop_run.ToString();
        }

        private void loop_sub_Click(object sender, EventArgs e)
        {
            loop_run--;
            if (loop_run <= 0)
            {
                loop_run = 1;
            }
            loop_txt.Text = loop_run.ToString();
        }
    }
}