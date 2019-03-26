namespace WindowsFormsApplication2
{
    partial class Form3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._Data123___CopyDataSet6 = new WindowsFormsApplication2._Data123___CopyDataSet6();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTableAdapter = new WindowsFormsApplication2._Data123___CopyDataSet6TableAdapters.TaskTableAdapter();
            this._Data123___CopyDataSet7 = new WindowsFormsApplication2._Data123___CopyDataSet7();
            this.taskBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.taskTableAdapter1 = new WindowsFormsApplication2._Data123___CopyDataSet7TableAdapters.TaskTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._Data123___CopyDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Data123___CopyDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.taskBindingSource1;
            this.comboBox1.DisplayMember = "TaskName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(366, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "TaskName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 213);
            this.textBox1.TabIndex = 2;
            // 
            // _Data123___CopyDataSet6
            // 
            this._Data123___CopyDataSet6.DataSetName = "_Data123___CopyDataSet6";
            this._Data123___CopyDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this._Data123___CopyDataSet6;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // _Data123___CopyDataSet7
            // 
            this._Data123___CopyDataSet7.DataSetName = "_Data123___CopyDataSet7";
            this._Data123___CopyDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskBindingSource1
            // 
            this.taskBindingSource1.DataMember = "Task";
            this.taskBindingSource1.DataSource = this._Data123___CopyDataSet7;
            // 
            // taskTableAdapter1
            // 
            this.taskTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 322);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Data123___CopyDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Data123___CopyDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private _Data123___CopyDataSet6 _Data123___CopyDataSet6;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private _Data123___CopyDataSet6TableAdapters.TaskTableAdapter taskTableAdapter;
        private _Data123___CopyDataSet7 _Data123___CopyDataSet7;
        private System.Windows.Forms.BindingSource taskBindingSource1;
        private _Data123___CopyDataSet7TableAdapters.TaskTableAdapter taskTableAdapter1;
    }
}