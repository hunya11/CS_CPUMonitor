using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS_CPUMonitor {
	public partial class Form1 : Form {
		private int num_cpu_use;
		private int num_mem_use;
		private int num_mem_use_per;
		private int num_mem_available;
		private int num_mem_max;

		public Form1() {
			InitializeComponent();
			num_cpu_use = 0;
			num_mem_use = 0;
			num_mem_use_per = 0;
			num_mem_available = 0;
			num_mem_max = 1884596;
		}

		private void timer1_Tick(object sender, EventArgs e) {
			OutPutCPU();
			OutPutMEM();
		}

		/// <summary>
		/// 画面上にメモリの使用率を表示
		/// </summary>
		private void OutPutMEM() {
			num_mem_available = (int)this.Mem_Available.NextValue();
			num_mem_use_per = (int)this.Mem_use.NextValue();
			num_mem_use = num_mem_max - num_mem_available;
			float x = this.Mem_Available.NextValue();
			float y = this.Mem_use.NextValue();
			float z = num_mem_max - x;
			this.progressBar6.Value = num_mem_use_per;
			this.label6.Text = "Mem[Kb] : " + num_mem_use + "/" + num_mem_max;
			//this.label7.Text = "Mem : " + num_mem_use_per + "%";
			this.label7.Text = "Mem : " + z / num_mem_max * 100 + "%";
		}

		/// <summary>
		/// 画面上にCPUの使用率を表示
		/// </summary>
		private void OutPutCPU() {
			num_cpu_use = (int)this.CPU_all.NextValue();
			this.progressBar1.Value = (int)num_cpu_use;
			this.label1.Text = "CPU : " + num_cpu_use + "%";
			num_cpu_use = (int)this.CPU_1.NextValue();
			this.progressBar2.Value = num_cpu_use;
			this.label2.Text = "CPU_1 : " + num_cpu_use + "%";
			num_cpu_use = (int)this.CPU_2.NextValue();
			this.progressBar3.Value = num_cpu_use;
			this.label3.Text = "CPU_2 : " + num_cpu_use + "%";
			num_cpu_use = (int)this.CPU_3.NextValue();
			this.progressBar4.Value = num_cpu_use;
			this.label4.Text = "CPU_3 : " + num_cpu_use + "%";
			num_cpu_use = (int)this.CPU_4.NextValue();
			this.progressBar5.Value = num_cpu_use;
			this.label5.Text = "CPU_4 : " + num_cpu_use + "%";
		}
	}
}