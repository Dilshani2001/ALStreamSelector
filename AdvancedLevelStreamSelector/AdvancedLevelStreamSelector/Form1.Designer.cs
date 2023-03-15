namespace AdvancedLevelStreamSelector
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndexNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbStream = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dbDataSet = new AdvancedLevelStreamSelector.dbDataSet();
            this.pointsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.points_TableTableAdapter = new AdvancedLevelStreamSelector.dbDataSetTableAdapters.Points_TableTableAdapter();
            this.resultDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.result_DetailsTableAdapter = new AdvancedLevelStreamSelector.dbDataSetTableAdapters.Result_DetailsTableAdapter();
            this.schoolDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_DetailsTableAdapter = new AdvancedLevelStreamSelector.dbDataSetTableAdapters.School_DetailsTableAdapter();
            this.streamDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stream_DetailsTableAdapter = new AdvancedLevelStreamSelector.dbDataSetTableAdapters.Stream_DetailsTableAdapter();
            this.streamWeightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stream_WeightsTableAdapter = new AdvancedLevelStreamSelector.dbDataSetTableAdapters.Stream_WeightsTableAdapter();
            this.studentsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_DetailsTableAdapter = new AdvancedLevelStreamSelector.dbDataSetTableAdapters.Students_DetailsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtSelectedStream = new System.Windows.Forms.TextBox();
            this.txtStreamPassMark = new System.Windows.Forms.TextBox();
            this.txtStudentScore = new System.Windows.Forms.TextBox();
            this.txtEligibility = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamWeightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your index number";
            // 
            // txtIndexNo
            // 
            this.txtIndexNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndexNo.Location = new System.Drawing.Point(389, 43);
            this.txtIndexNo.Name = "txtIndexNo";
            this.txtIndexNo.Size = new System.Drawing.Size(340, 26);
            this.txtIndexNo.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(270, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 50);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Check Eligibility";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbStream
            // 
            this.cmbStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStream.FormattingEnabled = true;
            this.cmbStream.Location = new System.Drawing.Point(389, 75);
            this.cmbStream.Name = "cmbStream";
            this.cmbStream.Size = new System.Drawing.Size(340, 28);
            this.cmbStream.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Stream";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Results";
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pointsTableBindingSource
            // 
            this.pointsTableBindingSource.DataMember = "Points Table";
            this.pointsTableBindingSource.DataSource = this.dbDataSet;
            // 
            // points_TableTableAdapter
            // 
            this.points_TableTableAdapter.ClearBeforeFill = true;
            // 
            // resultDetailsBindingSource
            // 
            this.resultDetailsBindingSource.DataMember = "Result Details";
            this.resultDetailsBindingSource.DataSource = this.dbDataSet;
            // 
            // result_DetailsTableAdapter
            // 
            this.result_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // schoolDetailsBindingSource
            // 
            this.schoolDetailsBindingSource.DataMember = "School Details";
            this.schoolDetailsBindingSource.DataSource = this.dbDataSet;
            // 
            // school_DetailsTableAdapter
            // 
            this.school_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // streamDetailsBindingSource
            // 
            this.streamDetailsBindingSource.DataMember = "Stream Details";
            this.streamDetailsBindingSource.DataSource = this.dbDataSet;
            // 
            // stream_DetailsTableAdapter
            // 
            this.stream_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // streamWeightsBindingSource
            // 
            this.streamWeightsBindingSource.DataMember = "Stream Weights";
            this.streamWeightsBindingSource.DataSource = this.dbDataSet;
            // 
            // stream_WeightsTableAdapter
            // 
            this.stream_WeightsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsDetailsBindingSource
            // 
            this.studentsDetailsBindingSource.DataMember = "Students Details";
            this.studentsDetailsBindingSource.DataSource = this.dbDataSet;
            // 
            // students_DetailsTableAdapter
            // 
            this.students_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Eligibility";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Selected Stream";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pass Mark";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Your Score";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Eligibility";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(48, 244);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(313, 199);
            this.txtResult.TabIndex = 12;
            // 
            // txtSelectedStream
            // 
            this.txtSelectedStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedStream.Location = new System.Drawing.Point(535, 280);
            this.txtSelectedStream.Name = "txtSelectedStream";
            this.txtSelectedStream.ReadOnly = true;
            this.txtSelectedStream.Size = new System.Drawing.Size(194, 26);
            this.txtSelectedStream.TabIndex = 13;
            // 
            // txtStreamPassMark
            // 
            this.txtStreamPassMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreamPassMark.Location = new System.Drawing.Point(535, 313);
            this.txtStreamPassMark.Name = "txtStreamPassMark";
            this.txtStreamPassMark.ReadOnly = true;
            this.txtStreamPassMark.Size = new System.Drawing.Size(194, 26);
            this.txtStreamPassMark.TabIndex = 14;
            // 
            // txtStudentScore
            // 
            this.txtStudentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentScore.Location = new System.Drawing.Point(535, 345);
            this.txtStudentScore.Name = "txtStudentScore";
            this.txtStudentScore.ReadOnly = true;
            this.txtStudentScore.Size = new System.Drawing.Size(194, 26);
            this.txtStudentScore.TabIndex = 15;
            // 
            // txtEligibility
            // 
            this.txtEligibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEligibility.Location = new System.Drawing.Point(535, 377);
            this.txtEligibility.Name = "txtEligibility";
            this.txtEligibility.ReadOnly = true;
            this.txtEligibility.Size = new System.Drawing.Size(194, 26);
            this.txtEligibility.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 471);
            this.Controls.Add(this.txtEligibility);
            this.Controls.Add(this.txtStudentScore);
            this.Controls.Add(this.txtStreamPassMark);
            this.Controls.Add(this.txtSelectedStream);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStream);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtIndexNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Advanced Level Stream Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streamWeightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource pointsTableBindingSource;
        private dbDataSetTableAdapters.Points_TableTableAdapter points_TableTableAdapter;
        private System.Windows.Forms.BindingSource resultDetailsBindingSource;
        private dbDataSetTableAdapters.Result_DetailsTableAdapter result_DetailsTableAdapter;
        private System.Windows.Forms.BindingSource schoolDetailsBindingSource;
        private dbDataSetTableAdapters.School_DetailsTableAdapter school_DetailsTableAdapter;
        private System.Windows.Forms.BindingSource streamDetailsBindingSource;
        private dbDataSetTableAdapters.Stream_DetailsTableAdapter stream_DetailsTableAdapter;
        private System.Windows.Forms.BindingSource streamWeightsBindingSource;
        private dbDataSetTableAdapters.Stream_WeightsTableAdapter stream_WeightsTableAdapter;
        private System.Windows.Forms.BindingSource studentsDetailsBindingSource;
        private dbDataSetTableAdapters.Students_DetailsTableAdapter students_DetailsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndexNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbStream;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtSelectedStream;
        private System.Windows.Forms.TextBox txtStreamPassMark;
        private System.Windows.Forms.TextBox txtStudentScore;
        private System.Windows.Forms.TextBox txtEligibility;
    }
}

