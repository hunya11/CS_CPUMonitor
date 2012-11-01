namespace CS_CPUMonitor {
	partial class Form1 {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.CPU_all = new System.Diagnostics.PerformanceCounter();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.progressBar4 = new System.Windows.Forms.ProgressBar();
			this.progressBar5 = new System.Windows.Forms.ProgressBar();
			this.CPU_1 = new System.Diagnostics.PerformanceCounter();
			this.CPU_2 = new System.Diagnostics.PerformanceCounter();
			this.CPU_3 = new System.Diagnostics.PerformanceCounter();
			this.CPU_4 = new System.Diagnostics.PerformanceCounter();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.progressBar6 = new System.Windows.Forms.ProgressBar();
			this.Mem_Available = new System.Diagnostics.PerformanceCounter();
			this.label6 = new System.Windows.Forms.Label();
			this.Mem_use = new System.Diagnostics.PerformanceCounter();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.CPU_all)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CPU_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CPU_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CPU_3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CPU_4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Mem_Available)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Mem_use)).BeginInit();
			this.SuspendLayout();
			// 
			// CPU_all
			// 
			this.CPU_all.CategoryName = "Processor";
			this.CPU_all.CounterName = "% Processor Time";
			this.CPU_all.InstanceName = "_Total";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 12);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(270, 57);
			this.progressBar1.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(12, 75);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(127, 23);
			this.progressBar2.TabIndex = 1;
			// 
			// progressBar3
			// 
			this.progressBar3.Location = new System.Drawing.Point(155, 75);
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(127, 23);
			this.progressBar3.TabIndex = 2;
			// 
			// progressBar4
			// 
			this.progressBar4.Location = new System.Drawing.Point(12, 104);
			this.progressBar4.Name = "progressBar4";
			this.progressBar4.Size = new System.Drawing.Size(127, 23);
			this.progressBar4.TabIndex = 3;
			// 
			// progressBar5
			// 
			this.progressBar5.Location = new System.Drawing.Point(155, 104);
			this.progressBar5.Name = "progressBar5";
			this.progressBar5.Size = new System.Drawing.Size(127, 23);
			this.progressBar5.TabIndex = 4;
			// 
			// CPU_1
			// 
			this.CPU_1.CategoryName = "Processor";
			this.CPU_1.CounterName = "% Processor Time";
			this.CPU_1.InstanceName = "0";
			// 
			// CPU_2
			// 
			this.CPU_2.CategoryName = "Processor";
			this.CPU_2.CounterName = "% Processor Time";
			this.CPU_2.InstanceName = "1";
			// 
			// CPU_3
			// 
			this.CPU_3.CategoryName = "Processor";
			this.CPU_3.CounterName = "% Processor Time";
			this.CPU_3.InstanceName = "2";
			// 
			// CPU_4
			// 
			this.CPU_4.CategoryName = "Processor";
			this.CPU_4.CounterName = "% Processor Time";
			this.CPU_4.InstanceName = "3";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(118, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "CPU : 000%";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "CPU_1 : 000%";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(187, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "CPU_2 : 000%";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(43, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "CPU_3 : 000%";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(187, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 12);
			this.label5.TabIndex = 9;
			this.label5.Text = "CPU_4 : 000%";
			// 
			// progressBar6
			// 
			this.progressBar6.Location = new System.Drawing.Point(12, 134);
			this.progressBar6.Name = "progressBar6";
			this.progressBar6.Size = new System.Drawing.Size(270, 56);
			this.progressBar6.TabIndex = 10;
			// 
			// Mem_Available
			// 
			this.Mem_Available.CategoryName = "Memory";
			this.Mem_Available.CounterName = "Available KBytes";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(78, 146);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 12);
			this.label6.TabIndex = 11;
			this.label6.Text = "Mem : /";
			// 
			// Mem_use
			// 
			this.Mem_use.CategoryName = "Memory";
			this.Mem_use.CounterName = "% Committed Bytes In Use";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(118, 168);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 12);
			this.label7.TabIndex = 12;
			this.label7.Text = "Mem : 000%";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 202);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.progressBar6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar5);
			this.Controls.Add(this.progressBar4);
			this.Controls.Add(this.progressBar3);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.progressBar1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "CPU Monitor";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.CPU_all)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CPU_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CPU_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CPU_3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CPU_4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Mem_Available)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Mem_use)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Diagnostics.PerformanceCounter CPU_all;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.ProgressBar progressBar3;
		private System.Windows.Forms.ProgressBar progressBar4;
		private System.Windows.Forms.ProgressBar progressBar5;
		private System.Diagnostics.PerformanceCounter CPU_1;
		private System.Diagnostics.PerformanceCounter CPU_2;
		private System.Diagnostics.PerformanceCounter CPU_3;
		private System.Diagnostics.PerformanceCounter CPU_4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ProgressBar progressBar6;
		private System.Diagnostics.PerformanceCounter Mem_Available;
		private System.Windows.Forms.Label label6;
		private System.Diagnostics.PerformanceCounter Mem_use;
		private System.Windows.Forms.Label label7;

	}
}

