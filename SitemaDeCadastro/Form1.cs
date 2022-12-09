using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SitemaDeCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas = new List<Pessoa>();  

        
        public Form1()
        {
            InitializeComponent();
            Status.SelectedIndex= 0;
           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            int index = -1;

            if (NameTxt.Text == "")
            {
                MessageBox.Show("Preencha o nome");
                NameTxt.Focus();
                return;
            }
            if (PhoneTxt.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o numero corretamente");
                PhoneTxt.Focus();
                return;
            }

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.nome == NameTxt.Text)
                {
                    index = pessoas.IndexOf(pessoa); 
                }
            }
            
            
            Pessoa p = new Pessoa();
            p.nome = NameTxt.Text;
            p.dataNascimento = DateTxt.Text;
            p.numero = PhoneTxt.Text;
            p.estadoC = Status.SelectedIndex;
            p.filhos = ChildrenCheck.Checked;
            p.carro = CarCheck.Checked;
            p.casa = HouseCheck.Checked;

            if (RadioM.Checked)
            {
                p.sexo = 'M';
            }
            else if (RadioF.Checked)
            {
                p.sexo = 'F';
            }
            else
            {
                p.sexo = 'O';
            }

            if (index < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }
            
            Listar();
            
            btnClear_Click(btnClear, e);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (Listas_Nomes.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione alguem");
            }
            else
            {
                int index = Listas_Nomes.SelectedIndex;
                pessoas.RemoveAt(index);
                Listar();

            }
        }

        private void Listar()
        {
            Listas_Nomes.Items.Clear();

            foreach (Pessoa p in pessoas)
            {
                
                Listas_Nomes.Items.Add(p.nome);
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            NameTxt.Text = "";
            DateTxt.Text = "";
            PhoneTxt.Text = "";
            Status.SelectedIndex = 0;
            ChildrenCheck.Checked = false;
            CarCheck.Checked = false;
            HouseCheck.Checked = false;

        }

        private void Listas_Nomes_DoubleClick(object sender, EventArgs e)
        {
            int index = Listas_Nomes.SelectedIndex;

            Pessoa a = pessoas[index];

            NameTxt.Text = a.nome;
            DateTxt.Text = a.dataNascimento;
            PhoneTxt.Text = a.numero;
            Status.SelectedIndex = a.estadoC;
            _ = a.filhos ? ChildrenCheck.Checked = true : ChildrenCheck.Checked = false;
            _ = a.carro ? CarCheck.Checked = true : CarCheck.Checked = false;
            _ = a.casa ? HouseCheck.Checked = true : HouseCheck.Checked = false;
            switch (a.sexo)
            {
                case 'M':
                    RadioM.Checked = true;
                    break;
                case 'F':
                    RadioF.Checked = true;
                    break;
                default:
                    RadioO.Checked = true;
                    break;
            }
        }
    }
}
