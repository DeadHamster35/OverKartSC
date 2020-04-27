using System;
using System.Windows;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using OverKartSC_Library;

namespace OverKartSC
{
    public partial class StatsEditor : Form
    {
        public StatsEditor()
        {
            InitializeComponent();
        }

        FileStream fStream = new FileStream("null", FileMode.OpenOrCreate);
        MemoryStream mStream = new MemoryStream();
        BinaryReader bReader = new BinaryReader(Stream.Null);
        BinaryWriter bWriter = new BinaryWriter(Stream.Null);

        OpenFileDialog openDialog = new OpenFileDialog();
        SaveFileDialog saveDialog = new SaveFileDialog();


        string filePath = String.Empty;
        string savePath = String.Empty;

        byte[] fileData = new byte[0];

        OKSCLibrary okLibrary = new OKSCLibrary();
        OKSCLibrary.Character[] characterData = new OKSCLibrary.Character[0];


        int[] speedLoss = new int[8];




        private void loadClick(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openDialog.FileName;

                fileData = File.ReadAllBytes(filePath);


                okLibrary.loadStats(ref characterData, ref speedLoss, fileData);

                saveBtn.Enabled = true;
                cSelect.Enabled = true;
                cSelect.SelectedIndex = 0;

            }
        }

        private void updateStats()
        {
            int outValue = new int();
            int.TryParse(topspeed.Text, out outValue);
            characterData[cSelect.SelectedIndex].topSpeed = outValue;

            int.TryParse(sl1.Text, out speedLoss[0]);
            int.TryParse(sl2.Text, out speedLoss[1]);
            int.TryParse(sl3.Text, out speedLoss[2]);
            int.TryParse(sl4.Text, out speedLoss[3]);
            int.TryParse(sl5.Text, out speedLoss[4]);
            int.TryParse(sl6.Text, out speedLoss[5]);
            int.TryParse(sl7.Text, out speedLoss[6]);
            int.TryParse(sl8.Text, out speedLoss[7]);

            int.TryParse(w1.Text, out characterData[cSelect.SelectedIndex].weight[0]);
            int.TryParse(w2.Text, out characterData[cSelect.SelectedIndex].weight[1]);
            int.TryParse(w3.Text, out characterData[cSelect.SelectedIndex].weight[2]);
            int.TryParse(w4.Text, out characterData[cSelect.SelectedIndex].weight[3]);
            int.TryParse(w5.Text, out characterData[cSelect.SelectedIndex].weight[4]);
            int.TryParse(w6.Text, out characterData[cSelect.SelectedIndex].weight[5]);

            int.TryParse(h1.Text, out characterData[cSelect.SelectedIndex].handlingStats[0]);
            int.TryParse(h2.Text, out characterData[cSelect.SelectedIndex].handlingStats[1]);
            int.TryParse(h3.Text, out characterData[cSelect.SelectedIndex].handlingStats[2]);
            int.TryParse(h4.Text, out characterData[cSelect.SelectedIndex].handlingStats[3]);
            int.TryParse(h5.Text, out characterData[cSelect.SelectedIndex].handlingStats[4]);
            int.TryParse(h6.Text, out characterData[cSelect.SelectedIndex].handlingStats[5]);
            int.TryParse(h7.Text, out characterData[cSelect.SelectedIndex].handlingStats[6]);
            int.TryParse(h8.Text, out characterData[cSelect.SelectedIndex].handlingStats[7]);
            int.TryParse(h9.Text, out characterData[cSelect.SelectedIndex].handlingStats[8]);
            int.TryParse(h10.Text, out characterData[cSelect.SelectedIndex].handlingStats[9]);
            int.TryParse(h11.Text, out characterData[cSelect.SelectedIndex].handlingStats[10]);
            int.TryParse(h12.Text, out characterData[cSelect.SelectedIndex].handlingStats[11]);
            int.TryParse(h13.Text, out characterData[cSelect.SelectedIndex].handlingStats[12]);
            int.TryParse(h14.Text, out characterData[cSelect.SelectedIndex].handlingStats[13]);
            int.TryParse(h15.Text, out characterData[cSelect.SelectedIndex].handlingStats[14]);
            int.TryParse(h16.Text, out characterData[cSelect.SelectedIndex].handlingStats[15]);

            int.TryParse(a1.Text, out characterData[cSelect.SelectedIndex].accelerationStats[0]);
            int.TryParse(a2.Text, out characterData[cSelect.SelectedIndex].accelerationStats[1]);
            int.TryParse(a3.Text, out characterData[cSelect.SelectedIndex].accelerationStats[2]);
            int.TryParse(a4.Text, out characterData[cSelect.SelectedIndex].accelerationStats[3]);
            int.TryParse(a5.Text, out characterData[cSelect.SelectedIndex].accelerationStats[4]);
            int.TryParse(a6.Text, out characterData[cSelect.SelectedIndex].accelerationStats[5]);
            int.TryParse(a7.Text, out characterData[cSelect.SelectedIndex].accelerationStats[6]);
            int.TryParse(a8.Text, out characterData[cSelect.SelectedIndex].accelerationStats[7]);
            int.TryParse(a9.Text, out characterData[cSelect.SelectedIndex].accelerationStats[8]);
            int.TryParse(a10.Text, out characterData[cSelect.SelectedIndex].accelerationStats[9]);
            int.TryParse(a11.Text, out characterData[cSelect.SelectedIndex].accelerationStats[10]);
            int.TryParse(a12.Text, out characterData[cSelect.SelectedIndex].accelerationStats[11]);
            int.TryParse(a13.Text, out characterData[cSelect.SelectedIndex].accelerationStats[12]);
            int.TryParse(a14.Text, out characterData[cSelect.SelectedIndex].accelerationStats[13]);
            int.TryParse(a15.Text, out characterData[cSelect.SelectedIndex].accelerationStats[14]);
            int.TryParse(a16.Text, out characterData[cSelect.SelectedIndex].accelerationStats[15]);

        }

        private void cSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            topspeed.Text = characterData[cSelect.SelectedIndex].topSpeed.ToString();

            sl1.Text = speedLoss[0].ToString();
            sl2.Text = speedLoss[1].ToString();
            sl3.Text = speedLoss[2].ToString();
            sl4.Text = speedLoss[3].ToString();
            sl5.Text = speedLoss[4].ToString();
            sl6.Text = speedLoss[5].ToString();
            sl7.Text = speedLoss[6].ToString();
            sl8.Text = speedLoss[7].ToString();

            w1.Text = characterData[cSelect.SelectedIndex].weight[0].ToString();
            w2.Text = characterData[cSelect.SelectedIndex].weight[1].ToString();
            w3.Text = characterData[cSelect.SelectedIndex].weight[2].ToString();
            w4.Text = characterData[cSelect.SelectedIndex].weight[3].ToString();
            w5.Text = characterData[cSelect.SelectedIndex].weight[4].ToString();
            w6.Text = characterData[cSelect.SelectedIndex].weight[5].ToString();

            h1.Text = characterData[cSelect.SelectedIndex].handlingStats[0].ToString();
            h2.Text = characterData[cSelect.SelectedIndex].handlingStats[1].ToString();
            h3.Text = characterData[cSelect.SelectedIndex].handlingStats[2].ToString();
            h4.Text = characterData[cSelect.SelectedIndex].handlingStats[3].ToString();
            h5.Text = characterData[cSelect.SelectedIndex].handlingStats[4].ToString();
            h6.Text = characterData[cSelect.SelectedIndex].handlingStats[5].ToString();
            h7.Text = characterData[cSelect.SelectedIndex].handlingStats[6].ToString();
            h8.Text = characterData[cSelect.SelectedIndex].handlingStats[7].ToString();
            h9.Text = characterData[cSelect.SelectedIndex].handlingStats[8].ToString();
            h10.Text = characterData[cSelect.SelectedIndex].handlingStats[9].ToString();
            h11.Text = characterData[cSelect.SelectedIndex].handlingStats[10].ToString();
            h12.Text = characterData[cSelect.SelectedIndex].handlingStats[11].ToString();
            h13.Text = characterData[cSelect.SelectedIndex].handlingStats[12].ToString();
            h14.Text = characterData[cSelect.SelectedIndex].handlingStats[13].ToString();
            h15.Text = characterData[cSelect.SelectedIndex].handlingStats[14].ToString();
            h16.Text = characterData[cSelect.SelectedIndex].handlingStats[15].ToString();

            a1.Text = characterData[cSelect.SelectedIndex].accelerationStats[0].ToString();
            a2.Text = characterData[cSelect.SelectedIndex].accelerationStats[1].ToString();
            a3.Text = characterData[cSelect.SelectedIndex].accelerationStats[2].ToString();
            a4.Text = characterData[cSelect.SelectedIndex].accelerationStats[3].ToString();
            a5.Text = characterData[cSelect.SelectedIndex].accelerationStats[4].ToString();
            a6.Text = characterData[cSelect.SelectedIndex].accelerationStats[5].ToString();
            a7.Text = characterData[cSelect.SelectedIndex].accelerationStats[6].ToString();
            a8.Text = characterData[cSelect.SelectedIndex].accelerationStats[7].ToString();
            a9.Text = characterData[cSelect.SelectedIndex].accelerationStats[8].ToString();
            a10.Text = characterData[cSelect.SelectedIndex].accelerationStats[9].ToString();
            a11.Text = characterData[cSelect.SelectedIndex].accelerationStats[10].ToString();
            a12.Text = characterData[cSelect.SelectedIndex].accelerationStats[11].ToString();
            a13.Text = characterData[cSelect.SelectedIndex].accelerationStats[12].ToString();
            a14.Text = characterData[cSelect.SelectedIndex].accelerationStats[13].ToString();
            a15.Text = characterData[cSelect.SelectedIndex].accelerationStats[14].ToString();
            a16.Text = characterData[cSelect.SelectedIndex].accelerationStats[15].ToString();



        }

        private void saveClick(object sender, EventArgs e)
        {

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                savePath = saveDialog.FileName;


                byte[] outputROM = okLibrary.saveStats(fileData, characterData, speedLoss);

                File.WriteAllBytes(savePath, outputROM);
                MessageBox.Show("Finished");

            }
        }

        private void update(object sender, KeyEventArgs e)
        {
            updateStats();
        }

    }
}

