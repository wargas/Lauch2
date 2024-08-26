namespace Lauch2
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            buttonStop = new Button();
            buttonDelete = new Button();
            buttonNew = new Button();
            buttonStart = new Button();
            statusStrip1 = new StatusStrip();
            groupBox2 = new GroupBox();
            listViewProcess = new ListView();
            timer = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonStop);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonNew);
            groupBox1.Controls.Add(buttonStart);
            groupBox1.Controls.Add(statusStrip1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 338);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 0, 3, 0);
            groupBox1.Size = new Size(800, 96);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // buttonStop
            // 
            buttonStop.Enabled = false;
            buttonStop.Location = new Point(96, 31);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(75, 34);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "Parar";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(632, 31);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 34);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Excluir";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(713, 31);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(75, 34);
            buttonNew.TabIndex = 1;
            buttonNew.Text = "Novo";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonStart
            // 
            buttonStart.Enabled = false;
            buttonStart.Location = new Point(15, 31);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 34);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Iniciar";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(3, 74);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(794, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listViewProcess);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 338);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = " ";
            // 
            // listViewProcess
            // 
            listViewProcess.Dock = DockStyle.Fill;
            listViewProcess.GridLines = true;
            listViewProcess.Location = new Point(3, 21);
            listViewProcess.Name = "listViewProcess";
            listViewProcess.Size = new Size(794, 314);
            listViewProcess.TabIndex = 0;
            listViewProcess.UseCompatibleStateImageBehavior = false;
            listViewProcess.SelectedIndexChanged += listViewProcess_SelectedIndexChanged;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 434);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(816, 473);
            MinimumSize = new Size(816, 473);
            Name = "Form1";
            Text = "Processos";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private StatusStrip statusStrip1;
        private Button buttonStop;
        private Button buttonDelete;
        private Button buttonNew;
        private Button buttonStart;
        private GroupBox groupBox2;
        private ListView listViewProcess;
        private System.Windows.Forms.Timer timer;
    }
}
