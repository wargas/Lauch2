using System.Diagnostics;

namespace Lauch2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateListView();
            FillListView();
            timer.Start();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (listViewProcess.SelectedItems.Count < 1)
            {
                return;

            }
            var item = listViewProcess.SelectedItems[0];
            var fields = item.SubItems;


            Process process = new Process();

            process.StartInfo.FileName = fields[1].Text;
            process.StartInfo.Arguments = fields[3].Text;
            process.StartInfo.WorkingDirectory = fields[2].Text;

            process.StartInfo.CreateNoWindow = true;

            process.StartInfo.RedirectStandardOutput = true;

            process.EnableRaisingEvents = true;
            process.StartInfo.UseShellExecute = false;

            process.Start();


            ProcessItem.UpdateId(item.SubItems[0].Text, process.Id);

            FillListView();

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (listViewProcess.SelectedItems.Count < 1)
            {
                return;

            }
            var item = listViewProcess.SelectedItems[0];

            var fields = item.SubItems;
            Process runingProcess = null;
            try
            {
                runingProcess = Process.GetProcessById(int.Parse(fields[4].Text));

                runingProcess.Kill();
                ProcessItem.UpdateId(fields[0].Text, 0);
                FillListView();
            }
            catch { }


        }


        private void GenerateListView()
        {
            listViewProcess.View = View.Details;
            listViewProcess.Columns.Add("", 0);
            listViewProcess.Columns.Add("Arquivo", 220);
            listViewProcess.Columns.Add("Pasta", 180);
            listViewProcess.Columns.Add("Argumentos", 180);
            listViewProcess.Columns.Add("ID", 60);
            listViewProcess.Columns.Add("Status", 100);

            listViewProcess.FullRowSelect = true;

        }

        private void FillListView()
        {
            var items = ProcessItem.getAll();

            listViewProcess.Items.Clear();


            foreach (var item in items)
            {
                var lvItem = new ListViewItem([
                    item.ID.ToString(),
                    item.Filename,
                    item.workDir,
                    item.Arguments,
                    item.ProcessID.ToString(),
                    "PARADO"
                ]);

                lvItem.Tag = item;
                listViewProcess.Items.Add(lvItem);
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            NewProcess form = new NewProcess();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Salvo com sucesso");
                FillListView();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillListView();
        }

        private void listViewProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateButtonsStatus();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewProcess.Items.Count; i++)
            {
                var tag = listViewProcess.Items[i].Tag;

                if (tag == null)
                {
                    continue;
                }


                ProcessItem item = (ProcessItem)tag;
                Process? runningProcess = getProcessById(item.ProcessID);


                if (runningProcess != null && item.ProcessID != 0)
                {
                    if (listViewProcess.Items[i].SubItems[5].Text != "RODANDO")
                    {
                        listViewProcess.Items[i].SubItems[5].Text = "RODANDO";
                    }
                }
                else
                {
                    if (listViewProcess.Items[i].SubItems[5].Text != "PARADO")
                    {
                        listViewProcess.Items[i].SubItems[5].Text = "PARADO";
                    }
                    ProcessItem.UpdateId(item.ID.ToString(), 0);
                }
            }
            updateButtonsStatus();
        }

        private ProcessItem getSelected()
        {
            if (listViewProcess.SelectedItems.Count == 0)
            {
                return new ProcessItem();
            }

            var selected = listViewProcess.SelectedItems[0];
            var tag = selected.Tag;

            if (tag == null)
            {
                return new ProcessItem();
            }

            ProcessItem processItem = (ProcessItem)tag;

            return processItem;
        }

        private Process? getProcessById(int process_id)
        {
            try
            {
                return Process.GetProcessById(process_id);
            }
            catch
            {
                return null;
            }
        }

        private void updateButtonsStatus()
        {
            if (listViewProcess.SelectedItems.Count > 0)
            {
                var selected = getSelected();

                buttonStart.Enabled = selected.ProcessID > 0 ? false : true;
                buttonStop.Enabled = selected.ProcessID > 0 ? true : false;
                buttonDelete.Enabled = true;
            }
            else
            {
                buttonStart.Enabled = false;
                buttonStop.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            
                ProcessItem processItem = getSelected();
                if (processItem == null)
                {
                    return;
                }

                try
                {

                    Process? process = getProcessById(processItem.ProcessID);

                    if (process != null)
                    {
                        process?.Kill();
                    }
                }
                catch (Exception ex)
                {
                    ///
                }

                ProcessItem.DeleteById(processItem.ID);

                FillListView();
           
        }
    }
}
