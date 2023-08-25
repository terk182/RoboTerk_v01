namespace RoboTerk_v01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            panel1 = new Panel();
            label13 = new Label();
            loop_txt = new Label();
            loop_sub = new Button();
            Loop_add = new Button();
            bt_play = new Button();
            bt_stop = new Button();
            comboBox1 = new ComboBox();
            bt_connect = new Button();
            angle = new GroupBox();
            bt_y_add = new Button();
            bt_y_sub = new Button();
            trackBar_x_sl = new TrackBar();
            bt_x_sub = new Button();
            bt_x_add = new Button();
            trackBar_z_sl = new TrackBar();
            groupBox1 = new GroupBox();
            bt_gripper_on = new Button();
            bt_add_gripper = new Button();
            label11 = new Label();
            bt_gripper_off = new Button();
            trackBar_gripper_position = new TrackBar();
            bt_save_deg = new Button();
            bt_z_sub = new Button();
            bt_z_add = new Button();
            y_deg_txt = new TextBox();
            x_deg_txt = new TextBox();
            z_deg_txt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            trackBar_y_sl = new TrackBar();
            groupBox2 = new GroupBox();
            bt_default_position = new Button();
            bt_01x = new Button();
            bt_10x = new Button();
            bt_1x = new Button();
            bt_clear = new Button();
            bt_reset = new Button();
            bt_home = new Button();
            groupBox3 = new GroupBox();
            bt_ik_run = new Button();
            bt_check_ik = new Button();
            bt_Cartesian_save = new Button();
            groupBox6 = new GroupBox();
            base_deg_txt = new TextBox();
            link1_deg_txt = new TextBox();
            link2_deg_txt = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox5 = new GroupBox();
            label4 = new Label();
            label6 = new Label();
            z_position_txt = new TextBox();
            x_position_txt = new TextBox();
            y_position_txt = new TextBox();
            label5 = new Label();
            groupBox4 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            table_export = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            checkBox1 = new CheckBox();
            Gcode_input = new TextBox();
            panel2 = new Panel();
            command = new GroupBox();
            bt_send_cmd = new Button();
            textBox_cmd = new TextBox();
            label10 = new Label();
            speed_txt = new TextBox();
            trackBar_speed = new TrackBar();
            output_txt = new TextBox();
            groupBox7 = new GroupBox();
            groupBox8 = new GroupBox();
            textBox3 = new TextBox();
            bt_add_delay = new Button();
            trackBar_delay = new TrackBar();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            timer_check_home = new System.Windows.Forms.Timer(components);
            timer_check_arm = new System.Windows.Forms.Timer(components);
            timer_check_arm2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            angle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_x_sl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_z_sl).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_gripper_position).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_y_sl).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            command.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_speed).BeginInit();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_delay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 997);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1268, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(label13);
            panel1.Controls.Add(loop_txt);
            panel1.Controls.Add(loop_sub);
            panel1.Controls.Add(Loop_add);
            panel1.Controls.Add(bt_play);
            panel1.Controls.Add(bt_stop);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(bt_connect);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 52);
            panel1.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(863, 12);
            label13.Name = "label13";
            label13.Size = new Size(53, 28);
            label13.TabIndex = 7;
            label13.Text = "loop";
            // 
            // loop_txt
            // 
            loop_txt.AutoSize = true;
            loop_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loop_txt.ForeColor = SystemColors.ButtonHighlight;
            loop_txt.Location = new Point(967, 13);
            loop_txt.Name = "loop_txt";
            loop_txt.Size = new Size(23, 28);
            loop_txt.TabIndex = 6;
            loop_txt.Text = "1";
            loop_txt.Click += label12_Click;
            // 
            // loop_sub
            // 
            loop_sub.Location = new Point(1066, 13);
            loop_sub.Name = "loop_sub";
            loop_sub.Size = new Size(41, 29);
            loop_sub.TabIndex = 5;
            loop_sub.Text = "-";
            loop_sub.UseVisualStyleBackColor = true;
            loop_sub.Click += loop_sub_Click;
            // 
            // Loop_add
            // 
            Loop_add.Location = new Point(1018, 13);
            Loop_add.Name = "Loop_add";
            Loop_add.Size = new Size(42, 29);
            Loop_add.TabIndex = 4;
            Loop_add.Text = "+";
            Loop_add.UseVisualStyleBackColor = true;
            Loop_add.Click += Loop_add_Click;
            // 
            // bt_play
            // 
            bt_play.BackColor = Color.MediumSpringGreen;
            bt_play.Location = new Point(1128, 12);
            bt_play.Name = "bt_play";
            bt_play.Size = new Size(94, 29);
            bt_play.TabIndex = 3;
            bt_play.Text = "Play";
            bt_play.UseVisualStyleBackColor = false;
            bt_play.Click += bt_play_Click;
            // 
            // bt_stop
            // 
            bt_stop.BackColor = Color.Red;
            bt_stop.Location = new Point(713, 12);
            bt_stop.Name = "bt_stop";
            bt_stop.Size = new Size(94, 29);
            bt_stop.TabIndex = 2;
            bt_stop.Text = "stop";
            bt_stop.UseVisualStyleBackColor = false;
            bt_stop.Click += bt_stop_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 28);
            comboBox1.TabIndex = 1;
            // 
            // bt_connect
            // 
            bt_connect.Location = new Point(265, 10);
            bt_connect.Name = "bt_connect";
            bt_connect.Size = new Size(126, 33);
            bt_connect.TabIndex = 0;
            bt_connect.Text = "Connect";
            bt_connect.UseVisualStyleBackColor = true;
            bt_connect.Click += bt_connect_Click;
            // 
            // angle
            // 
            angle.Controls.Add(bt_y_add);
            angle.Controls.Add(bt_y_sub);
            angle.Controls.Add(trackBar_x_sl);
            angle.Controls.Add(bt_x_sub);
            angle.Controls.Add(bt_x_add);
            angle.Controls.Add(trackBar_z_sl);
            angle.Controls.Add(groupBox1);
            angle.Controls.Add(bt_save_deg);
            angle.Controls.Add(bt_z_sub);
            angle.Controls.Add(bt_z_add);
            angle.Controls.Add(y_deg_txt);
            angle.Controls.Add(x_deg_txt);
            angle.Controls.Add(z_deg_txt);
            angle.Controls.Add(label3);
            angle.Controls.Add(label2);
            angle.Controls.Add(label1);
            angle.Controls.Add(trackBar_y_sl);
            angle.Location = new Point(12, 143);
            angle.Name = "angle";
            angle.Size = new Size(281, 586);
            angle.TabIndex = 2;
            angle.TabStop = false;
            angle.Text = "angle";
            // 
            // bt_y_add
            // 
            bt_y_add.Location = new Point(28, 254);
            bt_y_add.Name = "bt_y_add";
            bt_y_add.Size = new Size(94, 29);
            bt_y_add.TabIndex = 10;
            bt_y_add.Text = "+Y(ขวา)";
            bt_y_add.UseVisualStyleBackColor = true;
            bt_y_add.Click += bt_y_add_Click;
            // 
            // bt_y_sub
            // 
            bt_y_sub.Location = new Point(147, 254);
            bt_y_sub.Name = "bt_y_sub";
            bt_y_sub.Size = new Size(94, 29);
            bt_y_sub.TabIndex = 11;
            bt_y_sub.Text = "-Y(ซ้าย)";
            bt_y_sub.UseVisualStyleBackColor = true;
            bt_y_sub.Click += bt_y_sub_Click;
            // 
            // trackBar_x_sl
            // 
            trackBar_x_sl.Location = new Point(16, 222);
            trackBar_x_sl.Maximum = 90;
            trackBar_x_sl.Name = "trackBar_x_sl";
            trackBar_x_sl.Size = new Size(242, 56);
            trackBar_x_sl.TabIndex = 18;
            trackBar_x_sl.TickStyle = TickStyle.None;
            trackBar_x_sl.Scroll += trackBar_x_sl_Scroll;
            // 
            // bt_x_sub
            // 
            bt_x_sub.Location = new Point(147, 187);
            bt_x_sub.Name = "bt_x_sub";
            bt_x_sub.Size = new Size(94, 29);
            bt_x_sub.TabIndex = 9;
            bt_x_sub.Text = "-X(L1 ลง)";
            bt_x_sub.UseVisualStyleBackColor = true;
            bt_x_sub.Click += bt_x_sub_Click;
            // 
            // bt_x_add
            // 
            bt_x_add.Location = new Point(28, 187);
            bt_x_add.Name = "bt_x_add";
            bt_x_add.Size = new Size(94, 29);
            bt_x_add.TabIndex = 8;
            bt_x_add.Text = "+X(L1 ขึ้น)";
            bt_x_add.UseVisualStyleBackColor = true;
            bt_x_add.Click += bt_x_add_Click;
            // 
            // trackBar_z_sl
            // 
            trackBar_z_sl.Location = new Point(16, 154);
            trackBar_z_sl.Maximum = 110;
            trackBar_z_sl.Name = "trackBar_z_sl";
            trackBar_z_sl.Size = new Size(242, 56);
            trackBar_z_sl.TabIndex = 17;
            trackBar_z_sl.TickStyle = TickStyle.None;
            trackBar_z_sl.Scroll += trackBar_z_sl_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_gripper_on);
            groupBox1.Controls.Add(bt_add_gripper);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(bt_gripper_off);
            groupBox1.Controls.Add(trackBar_gripper_position);
            groupBox1.Location = new Point(22, 336);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(242, 160);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "griper";
            // 
            // bt_gripper_on
            // 
            bt_gripper_on.Location = new Point(6, 26);
            bt_gripper_on.Name = "bt_gripper_on";
            bt_gripper_on.Size = new Size(94, 29);
            bt_gripper_on.TabIndex = 13;
            bt_gripper_on.Text = "NO";
            bt_gripper_on.UseVisualStyleBackColor = true;
            bt_gripper_on.Click += bt_gripper_on_Click;
            // 
            // bt_add_gripper
            // 
            bt_add_gripper.Location = new Point(65, 125);
            bt_add_gripper.Name = "bt_add_gripper";
            bt_add_gripper.Size = new Size(94, 29);
            bt_add_gripper.TabIndex = 16;
            bt_add_gripper.Text = "add";
            bt_add_gripper.UseVisualStyleBackColor = true;
            bt_add_gripper.Click += bt_add_gripper_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 60);
            label11.Name = "label11";
            label11.Size = new Size(117, 20);
            label11.TabIndex = 15;
            label11.Text = "Gripper position";
            // 
            // bt_gripper_off
            // 
            bt_gripper_off.Location = new Point(137, 26);
            bt_gripper_off.Name = "bt_gripper_off";
            bt_gripper_off.Size = new Size(94, 29);
            bt_gripper_off.TabIndex = 14;
            bt_gripper_off.Text = "OFF";
            bt_gripper_off.UseVisualStyleBackColor = true;
            bt_gripper_off.Click += bt_gripper_off_Click;
            // 
            // trackBar_gripper_position
            // 
            trackBar_gripper_position.Location = new Point(6, 83);
            trackBar_gripper_position.Maximum = 1000;
            trackBar_gripper_position.Name = "trackBar_gripper_position";
            trackBar_gripper_position.Size = new Size(230, 56);
            trackBar_gripper_position.TabIndex = 12;
            trackBar_gripper_position.Scroll += trackBar_gripper_position_Scroll;
            // 
            // bt_save_deg
            // 
            bt_save_deg.BackColor = Color.SeaGreen;
            bt_save_deg.Location = new Point(22, 518);
            bt_save_deg.Name = "bt_save_deg";
            bt_save_deg.Size = new Size(248, 50);
            bt_save_deg.TabIndex = 15;
            bt_save_deg.Text = "SAVE";
            bt_save_deg.UseVisualStyleBackColor = false;
            bt_save_deg.Click += bt_save_deg_Click;
            // 
            // bt_z_sub
            // 
            bt_z_sub.Location = new Point(147, 119);
            bt_z_sub.Name = "bt_z_sub";
            bt_z_sub.Size = new Size(94, 29);
            bt_z_sub.TabIndex = 7;
            bt_z_sub.Text = "-Z(L2 ขึ้น)";
            bt_z_sub.UseVisualStyleBackColor = true;
            bt_z_sub.Click += bt_z_sub_Click;
            // 
            // bt_z_add
            // 
            bt_z_add.Location = new Point(28, 119);
            bt_z_add.Name = "bt_z_add";
            bt_z_add.Size = new Size(94, 29);
            bt_z_add.TabIndex = 6;
            bt_z_add.Text = "+Z(L2 ลง)";
            bt_z_add.UseVisualStyleBackColor = true;
            bt_z_add.Click += bt_z_add_Click;
            // 
            // y_deg_txt
            // 
            y_deg_txt.Location = new Point(87, 86);
            y_deg_txt.Name = "y_deg_txt";
            y_deg_txt.Size = new Size(125, 27);
            y_deg_txt.TabIndex = 5;
            // 
            // x_deg_txt
            // 
            x_deg_txt.Location = new Point(87, 56);
            x_deg_txt.Name = "x_deg_txt";
            x_deg_txt.Size = new Size(125, 27);
            x_deg_txt.TabIndex = 4;
            // 
            // z_deg_txt
            // 
            z_deg_txt.Location = new Point(87, 26);
            z_deg_txt.Name = "z_deg_txt";
            z_deg_txt.Size = new Size(125, 27);
            z_deg_txt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 88);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Y (deg)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 58);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "X (deg)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 29);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Z (deg)";
            // 
            // trackBar_y_sl
            // 
            trackBar_y_sl.Location = new Point(22, 296);
            trackBar_y_sl.Maximum = 160;
            trackBar_y_sl.Minimum = -160;
            trackBar_y_sl.Name = "trackBar_y_sl";
            trackBar_y_sl.Size = new Size(236, 56);
            trackBar_y_sl.TabIndex = 19;
            trackBar_y_sl.TickStyle = TickStyle.None;
            trackBar_y_sl.Scroll += trackBar3_Scroll;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_default_position);
            groupBox2.Controls.Add(bt_01x);
            groupBox2.Controls.Add(bt_10x);
            groupBox2.Controls.Add(bt_1x);
            groupBox2.Controls.Add(bt_clear);
            groupBox2.Controls.Add(bt_reset);
            groupBox2.Controls.Add(bt_home);
            groupBox2.Location = new Point(299, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(199, 586);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "function";
            // 
            // bt_default_position
            // 
            bt_default_position.Location = new Point(10, 24);
            bt_default_position.Name = "bt_default_position";
            bt_default_position.Size = new Size(183, 42);
            bt_default_position.TabIndex = 19;
            bt_default_position.Text = "default position";
            bt_default_position.UseVisualStyleBackColor = true;
            bt_default_position.Click += bt_default_position_Click;
            // 
            // bt_01x
            // 
            bt_01x.Location = new Point(10, 286);
            bt_01x.Name = "bt_01x";
            bt_01x.Size = new Size(183, 61);
            bt_01x.TabIndex = 18;
            bt_01x.Text = "0.1X";
            bt_01x.UseVisualStyleBackColor = true;
            bt_01x.Click += bt_01x_Click;
            // 
            // bt_10x
            // 
            bt_10x.Location = new Point(10, 420);
            bt_10x.Name = "bt_10x";
            bt_10x.Size = new Size(183, 56);
            bt_10x.TabIndex = 17;
            bt_10x.Text = "10 X";
            bt_10x.UseVisualStyleBackColor = true;
            bt_10x.Click += bt_10x_Click;
            // 
            // bt_1x
            // 
            bt_1x.Location = new Point(10, 354);
            bt_1x.Name = "bt_1x";
            bt_1x.Size = new Size(183, 60);
            bt_1x.TabIndex = 16;
            bt_1x.Text = "1 X";
            bt_1x.UseVisualStyleBackColor = true;
            bt_1x.Click += bt_1x_Click;
            // 
            // bt_clear
            // 
            bt_clear.Location = new Point(10, 187);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(183, 43);
            bt_clear.TabIndex = 2;
            bt_clear.Text = "CLEAR";
            bt_clear.UseVisualStyleBackColor = true;
            bt_clear.Click += bt_clear_Click;
            // 
            // bt_reset
            // 
            bt_reset.Location = new Point(10, 130);
            bt_reset.Name = "bt_reset";
            bt_reset.Size = new Size(183, 43);
            bt_reset.TabIndex = 1;
            bt_reset.Text = "RESET";
            bt_reset.UseVisualStyleBackColor = true;
            bt_reset.Click += bt_reset_Click;
            // 
            // bt_home
            // 
            bt_home.Location = new Point(10, 76);
            bt_home.Name = "bt_home";
            bt_home.Size = new Size(183, 42);
            bt_home.TabIndex = 0;
            bt_home.Text = "HOME";
            bt_home.UseVisualStyleBackColor = true;
            bt_home.Click += bt_home_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bt_ik_run);
            groupBox3.Controls.Add(bt_check_ik);
            groupBox3.Controls.Add(bt_Cartesian_save);
            groupBox3.Controls.Add(groupBox6);
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Location = new Point(504, 143);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(260, 586);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cartesian";
            // 
            // bt_ik_run
            // 
            bt_ik_run.Location = new Point(24, 255);
            bt_ik_run.Name = "bt_ik_run";
            bt_ik_run.Size = new Size(216, 45);
            bt_ik_run.TabIndex = 10;
            bt_ik_run.Text = "Run";
            bt_ik_run.UseVisualStyleBackColor = true;
            bt_ik_run.Click += bt_ik_run_Click;
            // 
            // bt_check_ik
            // 
            bt_check_ik.Location = new Point(24, 206);
            bt_check_ik.Name = "bt_check_ik";
            bt_check_ik.Size = new Size(216, 43);
            bt_check_ik.TabIndex = 9;
            bt_check_ik.Text = "Check IK";
            bt_check_ik.UseVisualStyleBackColor = true;
            bt_check_ik.Click += bt_check_ik_Click;
            // 
            // bt_Cartesian_save
            // 
            bt_Cartesian_save.BackColor = Color.SeaGreen;
            bt_Cartesian_save.Location = new Point(24, 518);
            bt_Cartesian_save.Name = "bt_Cartesian_save";
            bt_Cartesian_save.Size = new Size(216, 50);
            bt_Cartesian_save.TabIndex = 8;
            bt_Cartesian_save.Text = "SAVE";
            bt_Cartesian_save.UseVisualStyleBackColor = false;
            bt_Cartesian_save.Click += bt_Cartesian_save_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(base_deg_txt);
            groupBox6.Controls.Add(link1_deg_txt);
            groupBox6.Controls.Add(link2_deg_txt);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(label7);
            groupBox6.Location = new Point(24, 315);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(216, 160);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "angle";
            // 
            // base_deg_txt
            // 
            base_deg_txt.Location = new Point(88, 123);
            base_deg_txt.Name = "base_deg_txt";
            base_deg_txt.Size = new Size(108, 27);
            base_deg_txt.TabIndex = 5;
            // 
            // link1_deg_txt
            // 
            link1_deg_txt.Location = new Point(88, 79);
            link1_deg_txt.Name = "link1_deg_txt";
            link1_deg_txt.Size = new Size(108, 27);
            link1_deg_txt.TabIndex = 4;
            // 
            // link2_deg_txt
            // 
            link2_deg_txt.Location = new Point(88, 39);
            link2_deg_txt.Name = "link2_deg_txt";
            link2_deg_txt.Size = new Size(108, 27);
            link2_deg_txt.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 125);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 2;
            label9.Text = "base(deg)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 82);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 1;
            label8.Text = "link1(deg)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 42);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 0;
            label7.Text = "link2(deg)";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(z_position_txt);
            groupBox5.Controls.Add(x_position_txt);
            groupBox5.Controls.Add(y_position_txt);
            groupBox5.Controls.Add(label5);
            groupBox5.Location = new Point(24, 29);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(216, 162);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 36);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 0;
            label4.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 118);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 2;
            label6.Text = "Z";
            // 
            // z_position_txt
            // 
            z_position_txt.Location = new Point(71, 111);
            z_position_txt.Name = "z_position_txt";
            z_position_txt.Size = new Size(125, 27);
            z_position_txt.TabIndex = 5;
            // 
            // x_position_txt
            // 
            x_position_txt.Location = new Point(71, 33);
            x_position_txt.Name = "x_position_txt";
            x_position_txt.Size = new Size(125, 27);
            x_position_txt.TabIndex = 3;
            // 
            // y_position_txt
            // 
            y_position_txt.Location = new Point(71, 72);
            y_position_txt.Name = "y_position_txt";
            y_position_txt.Size = new Size(125, 27);
            y_position_txt.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 75);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 1;
            label5.Text = "Y";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tabControl1);
            groupBox4.Location = new Point(770, 143);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(484, 699);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(15, 29);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(449, 584);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(table_export);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(441, 551);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "table";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // table_export
            // 
            table_export.Location = new Point(341, 481);
            table_export.Name = "table_export";
            table_export.Size = new Size(94, 29);
            table_export.TabIndex = 1;
            table_export.Text = "export";
            table_export.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(432, 464);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(checkBox1);
            tabPage2.Controls.Add(Gcode_input);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(441, 551);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "code";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 7);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(151, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "inverse kinematics";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Gcode_input
            // 
            Gcode_input.Location = new Point(6, 46);
            Gcode_input.Multiline = true;
            Gcode_input.Name = "Gcode_input";
            Gcode_input.Size = new Size(429, 470);
            Gcode_input.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(command);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(speed_txt);
            panel2.Controls.Add(trackBar_speed);
            panel2.Location = new Point(12, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1242, 67);
            panel2.TabIndex = 6;
            // 
            // command
            // 
            command.Controls.Add(bt_send_cmd);
            command.Controls.Add(textBox_cmd);
            command.ForeColor = SystemColors.ButtonHighlight;
            command.Location = new Point(632, 3);
            command.Name = "command";
            command.Size = new Size(610, 61);
            command.TabIndex = 3;
            command.TabStop = false;
            command.Text = "command";
            // 
            // bt_send_cmd
            // 
            bt_send_cmd.ForeColor = SystemColors.ActiveCaptionText;
            bt_send_cmd.Location = new Point(515, 24);
            bt_send_cmd.Name = "bt_send_cmd";
            bt_send_cmd.Size = new Size(89, 29);
            bt_send_cmd.TabIndex = 4;
            bt_send_cmd.Text = "send";
            bt_send_cmd.UseVisualStyleBackColor = true;
            bt_send_cmd.Click += bt_send_cmd_Click;
            // 
            // textBox_cmd
            // 
            textBox_cmd.Location = new Point(17, 26);
            textBox_cmd.Name = "textBox_cmd";
            textBox_cmd.Size = new Size(492, 27);
            textBox_cmd.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 6);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 2;
            label10.Text = "Speed";
            // 
            // speed_txt
            // 
            speed_txt.Location = new Point(22, 29);
            speed_txt.Name = "speed_txt";
            speed_txt.Size = new Size(109, 27);
            speed_txt.TabIndex = 1;
            // 
            // trackBar_speed
            // 
            trackBar_speed.Location = new Point(159, 11);
            trackBar_speed.Maximum = 1500;
            trackBar_speed.Minimum = 600;
            trackBar_speed.Name = "trackBar_speed";
            trackBar_speed.Size = new Size(418, 56);
            trackBar_speed.TabIndex = 0;
            trackBar_speed.Value = 600;
            trackBar_speed.Scroll += trackBar_speed_Scroll;
            // 
            // output_txt
            // 
            output_txt.Location = new Point(15, 26);
            output_txt.Multiline = true;
            output_txt.Name = "output_txt";
            output_txt.Size = new Size(1216, 84);
            output_txt.TabIndex = 7;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(output_txt);
            groupBox7.Location = new Point(12, 848);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(1242, 132);
            groupBox7.TabIndex = 8;
            groupBox7.TabStop = false;
            groupBox7.Text = "groupBox7";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(textBox3);
            groupBox8.Controls.Add(bt_add_delay);
            groupBox8.Controls.Add(trackBar_delay);
            groupBox8.Location = new Point(12, 735);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(752, 107);
            groupBox8.TabIndex = 9;
            groupBox8.TabStop = false;
            groupBox8.Text = "delay";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(93, 27);
            textBox3.TabIndex = 2;
            // 
            // bt_add_delay
            // 
            bt_add_delay.Location = new Point(618, 35);
            bt_add_delay.Name = "bt_add_delay";
            bt_add_delay.Size = new Size(114, 41);
            bt_add_delay.TabIndex = 1;
            bt_add_delay.Text = "add delay";
            bt_add_delay.UseVisualStyleBackColor = true;
            bt_add_delay.Click += bt_add_delay_Click;
            // 
            // trackBar_delay
            // 
            trackBar_delay.Location = new Point(102, 35);
            trackBar_delay.Name = "trackBar_delay";
            trackBar_delay.Size = new Size(496, 56);
            trackBar_delay.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(1278, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 440);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(1278, 479);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(440, 440);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // timer_check_home
            // 
            timer_check_home.Tick += timer_check_home_Tick;
            // 
            // timer_check_arm
            // 
            timer_check_arm.Tick += timer_check_arm_Tick;
            // 
            // timer_check_arm2
            // 
            timer_check_arm2.Tick += timer_check_arm2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1268, 1019);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(panel2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(angle);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Name = "Form1";
            Text = "RoboTerk Conterol  v001";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            angle.ResumeLayout(false);
            angle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_x_sl).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_z_sl).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_gripper_position).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_y_sl).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            command.ResumeLayout(false);
            command.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_speed).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_delay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private Panel panel1;
        private ComboBox comboBox1;
        private Button bt_connect;
        private GroupBox angle;
        private Button bt_play;
        private Button bt_stop;
        private Button bt_save_deg;
        private Button bt_gripper_off;
        private Button bt_gripper_on;
        private TrackBar trackBar_gripper_position;
        private Button bt_y_sub;
        private Button bt_y_add;
        private Button bt_x_sub;
        private Button bt_x_add;
        private Button bt_z_sub;
        private Button bt_z_add;
        private TextBox y_deg_txt;
        private TextBox x_deg_txt;
        private TextBox z_deg_txt;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button bt_clear;
        private Button bt_reset;
        private Button bt_home;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private Label label4;
        private TextBox z_position_txt;
        private TextBox y_position_txt;
        private TextBox x_position_txt;
        private Label label6;
        private Label label5;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox speed_txt;
        private TrackBar trackBar_speed;
        private Button bt_Cartesian_save;
        private GroupBox groupBox6;
        private TextBox base_deg_txt;
        private TextBox link1_deg_txt;
        private TextBox link2_deg_txt;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button bt_10x;
        private Button bt_1x;
        private Label label10;
        private GroupBox groupBox1;
        private Label label11;
        private Button bt_check_ik;
        private TextBox output_txt;
        private GroupBox groupBox7;
        private Button bt_01x;
        private Button bt_add_gripper;
        private GroupBox groupBox8;
        protected Button bt_add_delay;
        private TrackBar trackBar_delay;
        private Button bt_default_position;
        private GroupBox command;
        private Button bt_send_cmd;
        private TextBox textBox_cmd;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox Gcode_input;
        private Button table_export;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer_check_home;
        private System.Windows.Forms.Timer timer_check_arm;
        private System.Windows.Forms.Timer timer_check_arm2;
        private TrackBar trackBar_z_sl;
        private TrackBar trackBar_y_sl;
        private TrackBar trackBar_x_sl;
        private Button bt_ik_run;
        private CheckBox checkBox1;
        private Label loop_txt;
        private Button loop_sub;
        private Button Loop_add;
        private Label label13;
    }
}