using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Lesson_02._03._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Загрузить_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFDialog = new OpenFileDialog();
            openFDialog.Filter = "JSON files (*.json)|*.json|XML files (*.xml)|*.xml";
            if (openFDialog.ShowDialog() == DialogResult.OK)
            {

            }
                
        }
    }
}
