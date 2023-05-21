
namespace MandelbrotSet
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.display = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDimension = new System.Windows.Forms.ComboBox();
            this.pictureBoxZoom = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(22, 10);
            this.display.Margin = new System.Windows.Forms.Padding(2);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(929, 630);
            this.display.TabIndex = 0;
            this.display.TabStop = false;
            this.display.MouseDown += new System.Windows.Forms.MouseEventHandler(this.display_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1052, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter number of iterations:";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Black & White",
            "Colorful"});
            this.comboBoxColor.Location = new System.Drawing.Point(1088, 93);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(131, 28);
            this.comboBoxColor.TabIndex = 5;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1081, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose coloring style:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1093, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 26);
            this.textBox1.TabIndex = 9;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.Font = new System.Drawing.Font("MingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(979, 234);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(110, 47);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(979, 287);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(110, 36);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(841, 640);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 36);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save image";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1048, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Choose dimension number:";
            // 
            // comboBoxDimension
            // 
            this.comboBoxDimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDimension.FormattingEnabled = true;
            this.comboBoxDimension.Items.AddRange(new object[] {
            "2D",
            "3D"});
            this.comboBoxDimension.Location = new System.Drawing.Point(1088, 169);
            this.comboBoxDimension.Name = "comboBoxDimension";
            this.comboBoxDimension.Size = new System.Drawing.Size(131, 28);
            this.comboBoxDimension.TabIndex = 14;
            this.comboBoxDimension.SelectedIndexChanged += new System.EventHandler(this.comboBoxDimension_SelectedIndexChanged);
            // 
            // pictureBoxZoom
            // 
            this.pictureBoxZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxZoom.Location = new System.Drawing.Point(956, 396);
            this.pictureBoxZoom.Name = "pictureBoxZoom";
            this.pictureBoxZoom.Size = new System.Drawing.Size(263, 244);
            this.pictureBoxZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxZoom.TabIndex = 16;
            this.pictureBoxZoom.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1041, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Zoom In by clicking";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 677);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxZoom);
            this.Controls.Add(this.comboBoxDimension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form";
            this.Text = "Mandelbrot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBoxColor;
        public System.Windows.Forms.PictureBox display;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBoxDimension;
        private System.Windows.Forms.PictureBox pictureBoxZoom;
        private System.Windows.Forms.Label label4;
    }
}

