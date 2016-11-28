using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace serialization_studying
{
    //Estudando Serializacão
    public partial class Form1 : Form
    {
        BinaryFormatter bf = new BinaryFormatter();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Person pessoa = new Person(txtBoxName.Text, txtBoxLastName.Text, txtBoxNickname.Text, (int) nUpDownAge.Value, txtBoxGender.Text, txtBoxEthnicity.Text);
            Stream file = File.Open("pessoa.txt", FileMode.OpenOrCreate);
            bf.Serialize(file, pessoa);
            file.Close();
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            Stream file = File.Open("pessoa.txt", FileMode.OpenOrCreate);
            Person pessoa = (Person)bf.Deserialize(file);
            file.Close();
            txtBoxName.Text = pessoa.Name;
            txtBoxLastName.Text = pessoa.LastName;
            txtBoxNickname.Text = pessoa.Nickname;
            nUpDownAge.Value = pessoa.Age;
            txtBoxGender.Text = pessoa.Gender;
            txtBoxEthnicity.Text = pessoa.Ethnicity;
        }
    }
}
