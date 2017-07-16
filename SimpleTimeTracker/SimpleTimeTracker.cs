using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Windows.Forms; 
using SimpleTimeTracker.Models;
using SimpleTimeTracker.Services; 

namespace SimpleTimeTracker
{
    public partial class SimpleTimeTracker : Form
    {
        #region Properties
        private EventEntry currentEventEntry { get; set; }

        #endregion

        public SimpleTimeTracker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bind_lstProjects();
            Bind_gvEvents();
        }

        #region "Button Clicks"

        private void btnCancelAddProject_Click(object sender, EventArgs e)
        {
            PnlAddProjectVissible(false);
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        { 
            ProjectsBLL.AddProject(new Project { Id = Guid.NewGuid(), ProjectName = txtAddProject.Text });
            PnlAddProjectVissible(false);
            Form1_Load(sender, e);
        }
        private void btnNewProject_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                PnlAddProjectVissible(true);
            }
        }

        private void btnAddEventCancel_Click(object sender, EventArgs e)
        {
            PnlAddEventVisible(false);
        }

        private void btnStartEnd_Click(object sender, EventArgs e)
        {
            // Use the same button for Start and End

            var btn = (Button)sender;
            if (btn.Text == "Start")
            {
                PnlAddEventVisible(true);
            }
            else
            {
                btn.Text = "Start";
                btn.BackColor = System.Drawing.Color.PaleGreen;
                lblTime.Text = "00:00:00";
                lblEventName.Text = "";
                timer1.Enabled = false;
                currentEventEntry.EndTime = DateTime.Now;
                currentEventEntry.ElapsedTime = (currentEventEntry.EndTime - currentEventEntry.StartTime).ToString().Substring(0, 8);
                EventsBLL.AddEvent(currentEventEntry);
                Bind_gvEvents();
            }
        }

        private void btnAddEvent_Click_1(object sender, EventArgs e)
        {
            lblEventName.Text = txtEventDescription.Text;

            btnStartEnd.Text = "Stop";
            btnStartEnd.BackColor = System.Drawing.Color.Red;

            currentEventEntry = new EventEntry
            {
                Id = Guid.NewGuid(),
                ProjectId = Guid.Parse(lstProjects.SelectedValue.ToString()),
                Description = txtEventDescription.Text,
                StartTime = DateTime.Now,
            };
            PnlAddEventVisible(false);
            timer1.Enabled = true;

        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        { 
            var seconds = int.Parse(lblTime.Text.Substring(6));
            if (seconds < 59)
            {
                seconds++;
                lblTime.Text = lblTime.Text.Substring(0, 6) + seconds.ToString("00");
            }
            else
            {
                var minutes = int.Parse(lblTime.Text.Substring(3, 2));
                if (minutes < 99)
                {
                    minutes++;
                    lblTime.Text = lblTime.Text.Substring(0, 3) + minutes.ToString("00") + ":00";
                }
                else
                {
                    var hours = int.Parse(lblTime.Text.Substring(0, 2));
                    hours++;
                    lblTime.Text = hours.ToString("00") + ":00:00";
                } 
            }
        } 
        
        private void gvEvents_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var gridView = (DataGridView)sender;
            DialogResult result = MessageBox.Show("Delete Event -- " + gridView.SelectedRows[0].Cells[2].Value, "Delete Event ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var eventId = (Guid)gridView.SelectedRows[0].Cells[0].Value;
                EventsBLL.DeleteEvent(eventId);
                Bind_gvEvents();
            }
        }

        private void lstProjects_SelectedValueChanged(object sender, EventArgs e)
        {
            Bind_gvEvents();
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                DialogResult result = MessageBox.Show("Delete Project " + lstProjects.Text, "Delete Project ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var projectId = (Guid)lstProjects.SelectedValue;
                    ProjectsBLL.DeleteProperty(projectId);
                    Bind_lstProjects();
                }
            }
        }
        #region "Private Helper Functions"
        private void Bind_lstProjects()
        {
            var projects = ProjectsBLL.GetProjects();
            if (projects.Any())
            {
                lstProjects.DataSource = null;
                lstProjects.DataSource = projects;
                lstProjects.DisplayMember = "ProjectName";
                lstProjects.ValueMember = "Id";
                lstProjects.Enabled = true;
                btnStartEnd.Enabled = true;
                txtAddProject.Text = "";
                pnlAddProject.Visible = false;
            }
            else
            {
                lstProjects.Enabled = false;
                btnStartEnd.Enabled = false;
                pnlAddProject.Visible = true;
            }
        }

        private void PnlAddProjectVissible(bool visible)
        {
            txtAddProject.Text = "";
            pnlAddProject.Visible = visible;
        } 

        private void PnlAddEventVisible(bool visible)
        {
            txtEventDescription.Text = "";
            pnlAddEvent.Visible = visible;
        }

        private void Bind_gvEvents()
        {
            if (lstProjects.SelectedValue != null)
            {
                gvEvents.DataSource = null;
                var selectedProject = (Project)lstProjects.SelectedItems[0];
                List<EventEntry> events = EventsBLL.GetEvents(selectedProject.Id);
                gvEvents.DataSource = events;

                // Do not show Guid Id, or bool Finished
                gvEvents.Columns["Id"].Visible = false;
                gvEvents.Columns["ProjectId"].Visible = false;
            }
        }

        #endregion

        
    }
}



