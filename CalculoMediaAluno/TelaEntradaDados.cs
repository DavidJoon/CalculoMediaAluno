using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMediaAluno
{
    public partial class TelaEntradaDados : Form
    {
        public TelaEntradaDados()
        {
            InitializeComponent();
        }
        private decimal MediaAluno(params decimal[] notas)
        {
            decimal soma = 0;
            for(int i = 0; i<= notas.GetLength(0) -1; i++)
            {
                soma += notas[i];
            } return soma / notas.Length;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string nome = textBox1.Text;
            string nascimento = dateTimePicker1.Value.ToString();
            decimal nota1 = numericUpDown1.Value;
            decimal nota2 = numericUpDown2.Value;
            decimal nota3 = numericUpDown3.Value;
            decimal nota4 = numericUpDown4.Value;

            listBox1.Items.Add("Aluno: " + nome);
            listBox1.Items.Add("Data de Nascimento: " + nascimento);
            listBox1.Items.Add("Notas das Atividades");
            listBox1.Items.Add("Atividade 01: " + nota1);
            listBox1.Items.Add("Atividade 02: " + nota2);
            listBox1.Items.Add("Atividade 03: " + nota3);
            listBox1.Items.Add("Atividade 04: " + nota4);
            listBox1.Items.Add("Média Final: " + MediaAluno(nota1, nota2, nota3, nota4));

            decimal media = MediaAluno(nota1, nota2, nota3, nota4);
            decimal valormedia = numericUpDown5.Value;
            if(media >= valormedia)
            {
                MessageBox.Show("Aluno Aprovado!");
            }
            else
            {
                MessageBox.Show("Aluno Reprovado!");
            }
        }
    }
}
