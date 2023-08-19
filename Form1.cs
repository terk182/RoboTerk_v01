using RoboTerk_v01.services;
using System.IO.Ports;
using static System.Windows.Forms.LinkLabel;

namespace RoboTerk_v01
{
    public partial class Form1 : Form
    {
        Kinematics _Kinematics;
        SerialPort serialPort = new SerialPort();
        string recievedData;
        double x { get; set; } = 0;
        double y { get; set; } = 0;
        double z { get; set; } = 0;

        string[] gcode_list;
        double x_count = 0;

        double y_count = 0;
        double z_count = 0;


        int row_num = 1;


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
                bt_connect.BackColor = Color.Green;
                bt_connect.Text = "Disconnect";
            }
            else
            {
                bt_connect.BackColor = Color.Gray;
                bt_connect.Text = "Connect";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar_speed.Value = 800;
            speed_txt.Text = trackBar_speed.Value.ToString();
            x_deg_txt.Text = x.ToString();
            y_deg_txt.Text = y.ToString();
            z_deg_txt.Text = z.ToString();

            x_position_txt.Text = x.ToString();
            y_position_txt.Text = y.ToString();
            z_position_txt.Text = z.ToString();

            link1_deg_txt.Text = x.ToString();
            link2_deg_txt.Text = z.ToString();
            base_deg_txt.Text = y.ToString();



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


                var data = send("$X");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }

        private async Task send(String message)
        {
            recievedData = "";
            serialPort.Write(message + "\n\r");



            //while (!recievedData.Contains("\n\r"))
            //{

            //    //PROCESS ANSWERS HERE
            //    recievedData = serialPort.ReadExisting();
            //    output_txt.Text = recievedData;
            //    if (recievedData == "ok")
            //    {
            //        break;
            //    }


            //}
            //return recievedData;
        }

        private void serialPort_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {

            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            SetText(indata);

        }
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (output_txt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                output_txt.Text = text;
            }
        }

        private void bt_01x_Click(object sender, EventArgs e)
        {
            step = 0.1;
        }

        private void bt_x_add_Click(object sender, EventArgs e)
        {
            var data = send(String.Format("$J=G91G21X{0}F{1}", step, trackBar_speed.Value));

            x_count += step;
            x_deg_txt.Text = x_count.ToString("00.00");
        }
        private void bt_x_sub_Click(object sender, EventArgs e)
        {
            var data = send(String.Format("$J=G91G21X-{0}F{1}", step, trackBar_speed.Value));


            x_count -= step;
            x_deg_txt.Text = x_count.ToString("00.00");
        }

        private void bt_z_add_Click(object sender, EventArgs e)
        {
            var data = send(String.Format("$J=G91G21Z{0}F{1}", step, trackBar_speed.Value));

            z_count += step;
            z_deg_txt.Text = z_count.ToString("00.00");
        }

        private void bt_z_sub_Click(object sender, EventArgs e)
        {
            var data = send(String.Format("$J=G91G21Z-{0}F{1}", step, trackBar_speed.Value));


            z_count -= step;
            z_deg_txt.Text = z_count.ToString("00.00");
        }

        private void bt_y_add_Click(object sender, EventArgs e)
        {
            var data = send(String.Format("$J=G91G21Y{0}F{1}", step, trackBar_speed.Value));

            y_count += step;
            y_deg_txt.Text = y_count.ToString("00.00");
        }

        private void bt_y_sub_Click(object sender, EventArgs e)
        {
            var data = send(String.Format("$J=G91G21Y-{0}F{1}", step, trackBar_speed.Value));


            y_count -= step;
            y_deg_txt.Text = y_count.ToString("00.00");
        }

        private void bt_gripper_on_Click(object sender, EventArgs e)
        {
            var data = send("M3S400");
        }

        private void bt_gripper_off_Click(object sender, EventArgs e)
        {
            var data = send("M3S990");
        }

        private void trackBar_gripper_position_Scroll(object sender, EventArgs e)
        {
            var data = send(String.Format("M3S{0}", trackBar_gripper_position.Value));
        }

        private void bt_save_deg_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "NO";
            dataGridView1.Columns[1].Name = "G-Code";
            //dataGridView1.Columns[2].Name = "Product Price"; //gcode_list
            gcode_list = new string[] { String.Format("{0}", row_num), String.Format("$J=G91G21X{0}Y{1}Z{2}F{3}", x_deg_txt.Text, y_deg_txt.Text, z_deg_txt.Text, trackBar_speed.Value) };
            string[] row = new string[] { String.Format("{0}", row_num), String.Format("X{0},Y{1},Z{2},Speed{3}", x_deg_txt.Text, y_deg_txt.Text, z_deg_txt.Text, trackBar_speed.Value) };
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
            gcode_list = new string[] { String.Format("{0}", row_num), String.Format("$J=M3S{0}", trackBar_gripper_position.Value) };
            string[] row = new string[] { String.Format("{0}", row_num), String.Format("Gripper Position{0}", trackBar_gripper_position.Value) };
            dataGridView1.Rows.Add(row);
            row_num++;
        }
    }
}