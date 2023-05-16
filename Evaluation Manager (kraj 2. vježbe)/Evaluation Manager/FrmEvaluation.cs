using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager {
    public partial class FrmEvaluation : Form {
        private Student student;
        public FrmEvaluation(Student selectedStudent) { 
            InitializeComponent();
            student = selectedStudent;

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void FrmEvaluation_Load(object sender, EventArgs e) {
            SetFoormText();
            var activities = ActivityRepository.GetActivities();
            cboActivities.DataSurce = activities;


        }
        private void SetFormText() {
            Text = student.FirstName + "" + student.LastName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

            var currentActivity = comboBox1.SelectedItem as Activitiy;
            txt ActivityDescription.Text = currentActivity.Description;
            txtMinForGrade.Text = currentActivity.MinPointsForGrade + "/" + currentActivity.MaxPoints;
            txtMinForSignature.Text = currentActivity.MinPointsFrSignature + "/" + currentActivity.MaxPoints;
            numPoints.Minimum = 0;
            numPoints.Maximum = currentActivity.MaxPoints;


        }

       
    }
}
