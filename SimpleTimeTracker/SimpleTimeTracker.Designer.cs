namespace SimpleTimeTracker
{
    partial class SimpleTimeTracker
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
            this.pnlTopMain = new System.Windows.Forms.Panel();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnStartEnd = new System.Windows.Forms.Button();
            this.gvEvents = new System.Windows.Forms.DataGridView();
            this.pnlAddProject = new System.Windows.Forms.Panel();
            this.btnCancelAddProject = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddProject = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlAddEvent = new System.Windows.Forms.Panel();
            this.txtEventDescription = new System.Windows.Forms.TextBox();
            this.btnAddEventCancel = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlTopMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEvents)).BeginInit();
            this.pnlAddProject.SuspendLayout();
            this.pnlAddEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopMain
            // 
            this.pnlTopMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlTopMain.Controls.Add(this.btnDeleteProject);
            this.pnlTopMain.Controls.Add(this.lblEventName);
            this.pnlTopMain.Controls.Add(this.lblTime);
            this.pnlTopMain.Controls.Add(this.label4);
            this.pnlTopMain.Controls.Add(this.lstProjects);
            this.pnlTopMain.Controls.Add(this.btnNewProject);
            this.pnlTopMain.Controls.Add(this.btnStartEnd);
            this.pnlTopMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMain.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMain.Name = "pnlTopMain";
            this.pnlTopMain.Size = new System.Drawing.Size(611, 205);
            this.pnlTopMain.TabIndex = 0;
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProject.Location = new System.Drawing.Point(457, 12);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(133, 42);
            this.btnDeleteProject.TabIndex = 9;
            this.btnDeleteProject.Text = "Delete Project";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.Blue;
            this.lblEventName.Location = new System.Drawing.Point(41, 161);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(0, 20);
            this.lblEventName.TabIndex = 8;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(171, 122);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(71, 20);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Elapsed Time";
            // 
            // lstProjects
            // 
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.Location = new System.Drawing.Point(301, 60);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(289, 121);
            this.lstProjects.TabIndex = 3;
            this.lstProjects.SelectedValueChanged += new System.EventHandler(this.lstProjects_SelectedValueChanged);
            // 
            // btnNewProject
            // 
            this.btnNewProject.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProject.Location = new System.Drawing.Point(301, 12);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(133, 42);
            this.btnNewProject.TabIndex = 1;
            this.btnNewProject.Text = "New Project";
            this.btnNewProject.UseVisualStyleBackColor = false;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // btnStartEnd
            // 
            this.btnStartEnd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStartEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartEnd.Location = new System.Drawing.Point(45, 43);
            this.btnStartEnd.Name = "btnStartEnd";
            this.btnStartEnd.Size = new System.Drawing.Size(164, 50);
            this.btnStartEnd.TabIndex = 0;
            this.btnStartEnd.Text = "Start";
            this.btnStartEnd.UseVisualStyleBackColor = false;
            this.btnStartEnd.Click += new System.EventHandler(this.btnStartEnd_Click);
            // 
            // gvEvents
            // 
            this.gvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvEvents.Location = new System.Drawing.Point(0, 205);
            this.gvEvents.Name = "gvEvents";
            this.gvEvents.Size = new System.Drawing.Size(611, 484);
            this.gvEvents.TabIndex = 1;
            this.gvEvents.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvEvents_RowHeaderMouseClick);
            // 
            // pnlAddProject
            // 
            this.pnlAddProject.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlAddProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddProject.Controls.Add(this.btnCancelAddProject);
            this.pnlAddProject.Controls.Add(this.btnAddProject);
            this.pnlAddProject.Controls.Add(this.label3);
            this.pnlAddProject.Controls.Add(this.txtAddProject);
            this.pnlAddProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddProject.Location = new System.Drawing.Point(0, 205);
            this.pnlAddProject.Name = "pnlAddProject";
            this.pnlAddProject.Size = new System.Drawing.Size(611, 50);
            this.pnlAddProject.TabIndex = 2;
            this.pnlAddProject.Visible = false;
            // 
            // btnCancelAddProject
            // 
            this.btnCancelAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddProject.Location = new System.Drawing.Point(501, 6);
            this.btnCancelAddProject.Name = "btnCancelAddProject";
            this.btnCancelAddProject.Size = new System.Drawing.Size(89, 38);
            this.btnCancelAddProject.TabIndex = 3;
            this.btnCancelAddProject.Text = "Cancel";
            this.btnCancelAddProject.UseVisualStyleBackColor = true;
            this.btnCancelAddProject.Click += new System.EventHandler(this.btnCancelAddProject_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.Location = new System.Drawing.Point(393, 6);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(89, 38);
            this.btnAddProject.TabIndex = 2;
            this.btnAddProject.Text = "Add";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "New Project Name";
            // 
            // txtAddProject
            // 
            this.txtAddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddProject.Location = new System.Drawing.Point(185, 15);
            this.txtAddProject.Name = "txtAddProject";
            this.txtAddProject.Size = new System.Drawing.Size(166, 26);
            this.txtAddProject.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlAddEvent
            // 
            this.pnlAddEvent.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlAddEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddEvent.Controls.Add(this.txtEventDescription);
            this.pnlAddEvent.Controls.Add(this.btnAddEventCancel);
            this.pnlAddEvent.Controls.Add(this.btnAddEvent);
            this.pnlAddEvent.Controls.Add(this.label5);
            this.pnlAddEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddEvent.Location = new System.Drawing.Point(0, 255);
            this.pnlAddEvent.Name = "pnlAddEvent";
            this.pnlAddEvent.Size = new System.Drawing.Size(611, 54);
            this.pnlAddEvent.TabIndex = 3;
            this.pnlAddEvent.Visible = false;
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventDescription.Location = new System.Drawing.Point(185, 12);
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(166, 26);
            this.txtEventDescription.TabIndex = 4;
            // 
            // btnAddEventCancel
            // 
            this.btnAddEventCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEventCancel.Location = new System.Drawing.Point(501, 6);
            this.btnAddEventCancel.Name = "btnAddEventCancel";
            this.btnAddEventCancel.Size = new System.Drawing.Size(89, 38);
            this.btnAddEventCancel.TabIndex = 3;
            this.btnAddEventCancel.Text = "Cancel";
            this.btnAddEventCancel.UseVisualStyleBackColor = true;
            this.btnAddEventCancel.Click += new System.EventHandler(this.btnAddEventCancel_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(393, 6);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(89, 38);
            this.btnAddEvent.TabIndex = 2;
            this.btnAddEvent.Text = "Add";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "New Event Name";
            // 
            // SimpleTimeTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 689);
            this.Controls.Add(this.pnlAddEvent);
            this.Controls.Add(this.pnlAddProject);
            this.Controls.Add(this.gvEvents);
            this.Controls.Add(this.pnlTopMain);
            this.Name = "SimpleTimeTracker";
            this.Text = "Simple Time Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTopMain.ResumeLayout(false);
            this.pnlTopMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEvents)).EndInit();
            this.pnlAddProject.ResumeLayout(false);
            this.pnlAddProject.PerformLayout();
            this.pnlAddEvent.ResumeLayout(false);
            this.pnlAddEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopMain;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button btnStartEnd;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.Panel pnlAddProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddProject;
        private System.Windows.Forms.Button btnCancelAddProject;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlAddEvent;
        private System.Windows.Forms.Button btnAddEventCancel;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEventDescription;
        public System.Windows.Forms.DataGridView gvEvents;
        protected System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Button btnDeleteProject;
    }
}

