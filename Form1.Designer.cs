
namespace _6_op
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.paintBox = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pBrown = new System.Windows.Forms.Panel();
            this.pDeepPink = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pRed = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxShapes = new System.Windows.Forms.GroupBox();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.pIndigo = new System.Windows.Forms.Panel();
            this.pViolet = new System.Windows.Forms.Panel();
            this.pWhite = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).BeginInit();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gBoxShapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // paintBox
            // 
            this.paintBox.BackColor = System.Drawing.Color.White;
            this.paintBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintBox.Location = new System.Drawing.Point(0, 0);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(882, 553);
            this.paintBox.TabIndex = 0;
            this.paintBox.TabStop = false;
            this.paintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.paintBox_Paint);
            this.paintBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintBox_MouseClick);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel.Controls.Add(this.pWhite);
            this.panel.Controls.Add(this.pBrown);
            this.panel.Controls.Add(this.pDeepPink);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.gBoxShapes);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(882, 100);
            this.panel.TabIndex = 1;
            // 
            // pBrown
            // 
            this.pBrown.BackColor = System.Drawing.Color.Brown;
            this.pBrown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBrown.Location = new System.Drawing.Point(580, 50);
            this.pBrown.Name = "pBrown";
            this.pBrown.Size = new System.Drawing.Size(30, 30);
            this.pBrown.TabIndex = 6;
            this.pBrown.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pDeepPink
            // 
            this.pDeepPink.BackColor = System.Drawing.Color.DeepPink;
            this.pDeepPink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pDeepPink.Location = new System.Drawing.Point(530, 50);
            this.pDeepPink.Name = "pDeepPink";
            this.pDeepPink.Size = new System.Drawing.Size(30, 30);
            this.pDeepPink.TabIndex = 5;
            this.pDeepPink.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pRed);
            this.panel1.Location = new System.Drawing.Point(480, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pRed
            // 
            this.pRed.BackColor = System.Drawing.Color.Red;
            this.pRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pRed.Location = new System.Drawing.Point(-2, -2);
            this.pRed.Name = "pRed";
            this.pRed.Size = new System.Drawing.Size(30, 30);
            this.pRed.TabIndex = 4;
            this.pRed.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(475, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поменяйте цвет фигуры";
            // 
            // gBoxShapes
            // 
            this.gBoxShapes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gBoxShapes.Controls.Add(this.rbLine);
            this.gBoxShapes.Controls.Add(this.rbTriangle);
            this.gBoxShapes.Controls.Add(this.rbSquare);
            this.gBoxShapes.Controls.Add(this.rbCircle);
            this.gBoxShapes.Location = new System.Drawing.Point(10, 10);
            this.gBoxShapes.Name = "gBoxShapes";
            this.gBoxShapes.Size = new System.Drawing.Size(250, 80);
            this.gBoxShapes.TabIndex = 0;
            this.gBoxShapes.TabStop = false;
            this.gBoxShapes.Text = "Выберите фигуру";
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(118, 48);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(82, 21);
            this.rbLine.TabIndex = 3;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "отрезок";
            this.rbLine.UseVisualStyleBackColor = true;
            this.rbLine.CheckedChanged += new System.EventHandler(this.rbCircle_CheckedChanged);
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(118, 21);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(110, 21);
            this.rbTriangle.TabIndex = 2;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "треугольник";
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.CheckedChanged += new System.EventHandler(this.rbCircle_CheckedChanged);
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(16, 48);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(82, 21);
            this.rbSquare.TabIndex = 1;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "квадрат";
            this.rbSquare.UseVisualStyleBackColor = true;
            this.rbSquare.CheckedChanged += new System.EventHandler(this.rbCircle_CheckedChanged);
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(16, 21);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(56, 21);
            this.rbCircle.TabIndex = 0;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "круг";
            this.rbCircle.UseVisualStyleBackColor = true;
            this.rbCircle.CheckedChanged += new System.EventHandler(this.rbCircle_CheckedChanged);
            // 
            // pIndigo
            // 
            this.pIndigo.BackColor = System.Drawing.Color.Indigo;
            this.pIndigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pIndigo.Location = new System.Drawing.Point(630, 50);
            this.pIndigo.Name = "pIndigo";
            this.pIndigo.Size = new System.Drawing.Size(30, 30);
            this.pIndigo.TabIndex = 6;
            this.pIndigo.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pViolet
            // 
            this.pViolet.BackColor = System.Drawing.Color.Violet;
            this.pViolet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pViolet.Location = new System.Drawing.Point(680, 50);
            this.pViolet.Name = "pViolet";
            this.pViolet.Size = new System.Drawing.Size(30, 30);
            this.pViolet.TabIndex = 7;
            this.pViolet.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // pWhite
            // 
            this.pWhite.BackColor = System.Drawing.Color.White;
            this.pWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pWhite.Location = new System.Drawing.Point(730, 40);
            this.pWhite.Name = "pWhite";
            this.pWhite.Size = new System.Drawing.Size(40, 40);
            this.pWhite.TabIndex = 8;
            this.pWhite.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.pViolet);
            this.Controls.Add(this.pIndigo);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.paintBox);
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "Paint Shapes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gBoxShapes.ResumeLayout(false);
            this.gBoxShapes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox paintBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox gBoxShapes;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pBrown;
        private System.Windows.Forms.Panel pDeepPink;
        private System.Windows.Forms.Panel pRed;
        private System.Windows.Forms.Panel pIndigo;
        private System.Windows.Forms.Panel pViolet;
        private System.Windows.Forms.Panel pWhite;
    }
}

