﻿namespace ElectronicObserver.Window {
	partial class FormArsenal {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.TableArsenal = new System.Windows.Forms.TableLayoutPanel();
			this.ToolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// TableArsenal
			// 
			this.TableArsenal.AutoSize = true;
			this.TableArsenal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableArsenal.ColumnCount = 2;
			this.TableArsenal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableArsenal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableArsenal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableArsenal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableArsenal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableArsenal.Location = new System.Drawing.Point(0, 0);
			this.TableArsenal.Name = "TableArsenal";
			this.TableArsenal.RowCount = 1;
			this.TableArsenal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
			this.TableArsenal.Size = new System.Drawing.Size(0, 21);
			this.TableArsenal.TabIndex = 3;
			this.TableArsenal.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableArsenal_CellPaint);
			// 
			// ToolTipInfo
			// 
			this.ToolTipInfo.AutoPopDelay = 30000;
			this.ToolTipInfo.InitialDelay = 500;
			this.ToolTipInfo.ReshowDelay = 100;
			this.ToolTipInfo.ShowAlways = true;
			// 
			// FormArsenal
			// 
			this.AutoHidePortion = 150D;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(300, 200);
			this.Controls.Add(this.TableArsenal);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.HideOnClose = true;
			this.Name = "FormArsenal";
			this.Text = "工廠";
			this.Load += new System.EventHandler(this.FormArsenal_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TableArsenal;
		private System.Windows.Forms.ToolTip ToolTipInfo;
	}
}