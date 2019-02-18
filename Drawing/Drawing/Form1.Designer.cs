namespace Drawing
{
    partial class Form1
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pointB = new System.Windows.Forms.Button();
            this.lineB = new System.Windows.Forms.Button();
            this.rectangleB = new System.Windows.Forms.Button();
            this.triangleB = new System.Windows.Forms.Button();
            this.circleB = new System.Windows.Forms.Button();
            this.colorB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.saveB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(-1, 1);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(985, 527);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            // 
            // pointB
            // 
            this.pointB.Location = new System.Drawing.Point(990, 1);
            this.pointB.Name = "pointB";
            this.pointB.Size = new System.Drawing.Size(148, 57);
            this.pointB.TabIndex = 1;
            this.pointB.Text = "Point";
            this.pointB.UseVisualStyleBackColor = true;
            this.pointB.Click += new System.EventHandler(this.pointB_Click);
            // 
            // lineB
            // 
            this.lineB.Location = new System.Drawing.Point(990, 64);
            this.lineB.Name = "lineB";
            this.lineB.Size = new System.Drawing.Size(148, 57);
            this.lineB.TabIndex = 2;
            this.lineB.Text = "Line";
            this.lineB.UseVisualStyleBackColor = true;
            this.lineB.Click += new System.EventHandler(this.lineB_Click);
            // 
            // rectangleB
            // 
            this.rectangleB.Location = new System.Drawing.Point(990, 127);
            this.rectangleB.Name = "rectangleB";
            this.rectangleB.Size = new System.Drawing.Size(148, 57);
            this.rectangleB.TabIndex = 3;
            this.rectangleB.Text = "Rectangle";
            this.rectangleB.UseVisualStyleBackColor = true;
            this.rectangleB.Click += new System.EventHandler(this.rectangleB_Click);
            // 
            // triangleB
            // 
            this.triangleB.Location = new System.Drawing.Point(990, 190);
            this.triangleB.Name = "triangleB";
            this.triangleB.Size = new System.Drawing.Size(148, 57);
            this.triangleB.TabIndex = 4;
            this.triangleB.Text = "Triangle";
            this.triangleB.UseVisualStyleBackColor = true;
            this.triangleB.Click += new System.EventHandler(this.triangleB_Click);
            // 
            // circleB
            // 
            this.circleB.Location = new System.Drawing.Point(990, 253);
            this.circleB.Name = "circleB";
            this.circleB.Size = new System.Drawing.Size(148, 57);
            this.circleB.TabIndex = 5;
            this.circleB.Text = "Circle";
            this.circleB.UseVisualStyleBackColor = true;
            this.circleB.Click += new System.EventHandler(this.circleB_Click);
            // 
            // colorB
            // 
            this.colorB.Location = new System.Drawing.Point(990, 316);
            this.colorB.Name = "colorB";
            this.colorB.Size = new System.Drawing.Size(148, 57);
            this.colorB.TabIndex = 6;
            this.colorB.Text = "Choose color";
            this.colorB.UseVisualStyleBackColor = true;
            this.colorB.Click += new System.EventHandler(this.colorB_Click);
            // 
            // exitB
            // 
            this.exitB.Location = new System.Drawing.Point(990, 481);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(148, 40);
            this.exitB.TabIndex = 7;
            this.exitB.Text = "Exit";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(990, 438);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(148, 40);
            this.saveB.TabIndex = 8;
            this.saveB.Text = "Save picture";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(990, 394);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(148, 40);
            this.clearB.TabIndex = 9;
            this.clearB.Text = "Clear canvas";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 523);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.colorB);
            this.Controls.Add(this.circleB);
            this.Controls.Add(this.triangleB);
            this.Controls.Add(this.rectangleB);
            this.Controls.Add(this.lineB);
            this.Controls.Add(this.pointB);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "MS Paint -4.20";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button pointB;
        private System.Windows.Forms.Button lineB;
        private System.Windows.Forms.Button rectangleB;
        private System.Windows.Forms.Button triangleB;
        private System.Windows.Forms.Button circleB;
        private System.Windows.Forms.Button colorB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button clearB;
    }
}

