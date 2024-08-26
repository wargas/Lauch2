namespace Lauch2
{
    partial class NewProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProcess));
            groupBox1 = new GroupBox();
            buttonDir = new Button();
            buttonFile = new Button();
            textBoxArguments = new TextBox();
            textBoxDir = new TextBox();
            textBoxFilename = new TextBox();
            groupBox2 = new GroupBox();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            openFileDialog = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDir);
            groupBox1.Controls.Add(buttonFile);
            groupBox1.Controls.Add(textBoxArguments);
            groupBox1.Controls.Add(textBoxDir);
            groupBox1.Controls.Add(textBoxFilename);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 261);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // buttonDir
            // 
            buttonDir.Location = new Point(367, 51);
            buttonDir.Name = "buttonDir";
            buttonDir.Size = new Size(39, 26);
            buttonDir.TabIndex = 1;
            buttonDir.Text = "...";
            buttonDir.UseVisualStyleBackColor = true;
            buttonDir.Click += buttonDir_Click;
            // 
            // buttonFile
            // 
            buttonFile.Location = new Point(367, 19);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(39, 26);
            buttonFile.TabIndex = 1;
            buttonFile.Text = "...";
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // textBoxArguments
            // 
            textBoxArguments.Location = new Point(12, 85);
            textBoxArguments.Name = "textBoxArguments";
            textBoxArguments.PlaceholderText = "Argumentos";
            textBoxArguments.Size = new Size(394, 25);
            textBoxArguments.TabIndex = 0;
            // 
            // textBoxDir
            // 
            textBoxDir.Location = new Point(12, 52);
            textBoxDir.Name = "textBoxDir";
            textBoxDir.PlaceholderText = "Pasta de Trabalho";
            textBoxDir.Size = new Size(349, 25);
            textBoxDir.TabIndex = 0;
            // 
            // textBoxFilename
            // 
            textBoxFilename.Location = new Point(12, 19);
            textBoxFilename.Name = "textBoxFilename";
            textBoxFilename.PlaceholderText = "Executável";
            textBoxFilename.Size = new Size(349, 25);
            textBoxFilename.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonSalvar);
            groupBox2.Controls.Add(buttonCancelar);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 3, 6, 7);
            groupBox2.Size = new Size(418, 57);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Dock = DockStyle.Right;
            buttonSalvar.Location = new Point(337, 21);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 29);
            buttonSalvar.TabIndex = 0;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Dock = DockStyle.Left;
            buttonCancelar.Location = new Point(6, 21);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 29);
            buttonCancelar.TabIndex = 0;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // NewProcess
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 187);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(434, 226);
            MinimumSize = new Size(434, 226);
            Name = "NewProcess";
            Text = "Novo Proceesso";
            Load += NewProcess_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonDir;
        private Button buttonFile;
        private TextBox textBoxArguments;
        private TextBox textBoxDir;
        private TextBox textBoxFilename;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private FolderBrowserDialog folderBrowserDialog;
        private OpenFileDialog openFileDialog;
    }
}