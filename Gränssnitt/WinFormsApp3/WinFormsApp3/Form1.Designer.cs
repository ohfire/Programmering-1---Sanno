namespace TodoListApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonMarkComplete = new System.Windows.Forms.Button();
            this.buttonSaveTasks = new System.Windows.Forms.Button();
            this.buttonLoadTasks = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.radioButtonImportant = new System.Windows.Forms.RadioButton();
            this.radioButtonLessImportant = new System.Windows.Forms.RadioButton();
            this.groupBoxCategory.SuspendLayout();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(102, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Att-göra lista";

            // textBoxTask
            this.textBoxTask.Location = new System.Drawing.Point(16, 42);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(256, 20);
            this.textBoxTask.TabIndex = 1;

            // buttonAddTask
            this.buttonAddTask.Location = new System.Drawing.Point(278, 40);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTask.TabIndex = 2;
            this.buttonAddTask.Text = "Lägg till uppgift";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);

            // buttonMarkComplete
            this.buttonMarkComplete.Location = new System.Drawing.Point(16, 270);
            this.buttonMarkComplete.Name = "buttonMarkComplete";
            this.buttonMarkComplete.Size = new System.Drawing.Size(112, 23);
            this.buttonMarkComplete.TabIndex = 3;
            this.buttonMarkComplete.Text = "Markera som klar";
            this.buttonMarkComplete.UseVisualStyleBackColor = true;
            this.buttonMarkComplete.Click += new System.EventHandler(this.buttonMarkComplete_Click);

            // buttonSaveTasks
            this.buttonSaveTasks.Location = new System.Drawing.Point(134, 270);
            this.buttonSaveTasks.Name = "buttonSaveTasks";
            this.buttonSaveTasks.Size = new System.Drawing.Size(100, 23);
            this.buttonSaveTasks.TabIndex = 4;
            this.buttonSaveTasks.Text = "Spara uppgifter";
            this.buttonSaveTasks.UseVisualStyleBackColor = true;
            this.buttonSaveTasks.Click += new System.EventHandler(this.buttonSaveTasks_Click);

            // buttonLoadTasks
            this.buttonLoadTasks.Location = new System.Drawing.Point(240, 270);
            this.buttonLoadTasks.Name = "buttonLoadTasks";
            this.buttonLoadTasks.Size = new System.Drawing.Size(113, 23);
            this.buttonLoadTasks.TabIndex = 5;
            this.buttonLoadTasks.Text = "Ladda uppgifter";
            this.buttonLoadTasks.UseVisualStyleBackColor = true;
            this.buttonLoadTasks.Click += new System.EventHandler(this.buttonLoadTasks_Click);

            // listBoxTasks
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(16, 110);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(337, 134);
            this.listBoxTasks.TabIndex = 6;

            // groupBoxCategory
            this.groupBoxCategory.Controls.Add(this.radioButtonLessImportant);
            this.groupBoxCategory.Controls.Add(this.radioButtonImportant);
            this.groupBoxCategory.Location = new System.Drawing.Point(16, 68);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(337, 36);
            this.groupBoxCategory.TabIndex = 7;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Kategori";

            // radioButtonImportant
            this.radioButtonImportant.AutoSize = true;
            this.radioButtonImportant.Location = new System.Drawing.Point(7, 13);
            this.radioButtonImportant.Name = "radioButtonImportant";
            this.radioButtonImportant.Size = new System.Drawing.Size(57, 17);
            this.radioButtonImportant.TabIndex = 0;
            this.radioButtonImportant.TabStop = true;
            this.radioButtonImportant.Text = "Viktigt";
            this.radioButtonImportant.UseVisualStyleBackColor = true;

            // radioButtonLessImportant
            this.radioButtonLessImportant.AutoSize = true;
            this.radioButtonLessImportant.Location = new System.Drawing.Point(70, 13);
            this.radioButtonLessImportant.Name = "radioButtonLessImportant";
            this.radioButtonLessImportant.Size = new System.Drawing.Size(93, 17);
            this.radioButtonLessImportant.TabIndex = 1;
            this.radioButtonLessImportant.TabStop = true;
            this.radioButtonLessImportant.Text = "Mindre viktigt";
            this.radioButtonLessImportant.UseVisualStyleBackColor = true;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 306);
            this.Controls.Add(this.groupBoxCategory);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.buttonLoadTasks);
            this.Controls.Add(this.buttonSaveTasks);
            this.Controls.Add(this.buttonMarkComplete);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainForm";
            this.Text = "Att-göra lista";
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonMarkComplete;
        private System.Windows.Forms.Button buttonSaveTasks;
        private System.Windows.Forms.Button buttonLoadTasks;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.RadioButton radioButtonImportant;
        private System.Windows.Forms.RadioButton radioButtonLessImportant;
    }
}
