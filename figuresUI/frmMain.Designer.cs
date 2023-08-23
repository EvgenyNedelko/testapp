namespace FiguresUI
{
    partial class frmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAddPolygon = new System.Windows.Forms.Button();
            this.btnDeleteObject = new System.Windows.Forms.Button();
            this.btnAddEllipse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lstObjects = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAddPolygon);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteObject);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddEllipse);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtArea);
            this.splitContainer1.Panel1.Controls.Add(this.lstObjects);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseClick);
            this.splitContainer1.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseDown);
            this.splitContainer1.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseMove);
            this.splitContainer1.Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseUp);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAddPolygon
            // 
            this.btnAddPolygon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPolygon.Location = new System.Drawing.Point(3, 380);
            this.btnAddPolygon.Name = "btnAddPolygon";
            this.btnAddPolygon.Size = new System.Drawing.Size(260, 34);
            this.btnAddPolygon.TabIndex = 1;
            this.btnAddPolygon.Text = "Добавить многоугольник";
            this.btnAddPolygon.UseVisualStyleBackColor = true;
            this.btnAddPolygon.Click += new System.EventHandler(this.btnAddPolygon_Click);
            // 
            // btnDeleteObject
            // 
            this.btnDeleteObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteObject.Location = new System.Drawing.Point(3, 226);
            this.btnDeleteObject.Name = "btnDeleteObject";
            this.btnDeleteObject.Size = new System.Drawing.Size(260, 34);
            this.btnDeleteObject.TabIndex = 0;
            this.btnDeleteObject.Text = "Удалить объект";
            this.btnDeleteObject.UseVisualStyleBackColor = true;
            this.btnDeleteObject.Click += new System.EventHandler(this.btnDeleteObject_Click);
            // 
            // btnAddEllipse
            // 
            this.btnAddEllipse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEllipse.Location = new System.Drawing.Point(3, 340);
            this.btnAddEllipse.Name = "btnAddEllipse";
            this.btnAddEllipse.Size = new System.Drawing.Size(260, 34);
            this.btnAddEllipse.TabIndex = 0;
            this.btnAddEllipse.Text = "Добавить эллипс";
            this.btnAddEllipse.UseVisualStyleBackColor = true;
            this.btnAddEllipse.Click += new System.EventHandler(this.btnAddEllipse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Площадь объекта, см^2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список объектов";
            // 
            // txtArea
            // 
            this.txtArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(3, 303);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(260, 31);
            this.txtArea.TabIndex = 1;
            // 
            // lstObjects
            // 
            this.lstObjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstObjects.FormattingEnabled = true;
            this.lstObjects.ItemHeight = 25;
            this.lstObjects.Location = new System.Drawing.Point(3, 41);
            this.lstObjects.Name = "lstObjects";
            this.lstObjects.Size = new System.Drawing.Size(260, 179);
            this.lstObjects.TabIndex = 0;
            this.lstObjects.SelectedIndexChanged += new System.EventHandler(this.lstObjects_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Text = "Тестовое приложение";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.ListBox lstObjects;
        private System.Windows.Forms.Button btnDeleteObject;
        private System.Windows.Forms.Button btnAddPolygon;
        private System.Windows.Forms.Button btnAddEllipse;
    }
}

