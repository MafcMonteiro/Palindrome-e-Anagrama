using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anagrama
{
    //  23/06/2015
    //  Time 21:20 UTC -03:00 - Brasilia
    //  Criado por Marcos Monteiro
    //  https://github.com/hopyzin

    

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();       
                        
        }

        public static bool Anagrama(string Palavra1, string Palavra2)
        {             

            Dictionary<char, int> Letra = new Dictionary<char, int>();
                        
            foreach (char c in Palavra1.AsEnumerable<char>())
            {
                if (Letra.ContainsKey(c))
                    Letra[c]++;
                else
                    Letra[c] = 1;
            }

          
            foreach (char c in Palavra2.AsEnumerable<char>())
            {
                if (Letra.ContainsKey(c))
                {
                    Letra[c]--;
                    if (Letra[c] == 0)
                        Letra.Remove(c);
                }               
                else
                    return false;
            }
                        
            return Letra.Values.Count == 0;
        }

        private void btnAnagrama_Click(object sender, EventArgs e)
        {
            bool RetornoAnagrama = Anagrama(tbxAnaPlavra1.Text, tbxAnaPalavra2.Text);

            if (RetornoAnagrama)
            {
                MessageBox.Show("É Anagrama"); 
            }
            else
            {
                MessageBox.Show("Não é Anagrama");
            }
            
        }


        public static bool Palindrome(string Palavra1)
        {
            bool PalavraInv;

            PalavraInv = Palavra1.SequenceEqual(Palavra1.Reverse());

            if (PalavraInv)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btrnPalindrome_Click(object sender, EventArgs e)
        {
            bool RetornoPalindrome = Palindrome(tbxPalindrome.Text);

            if (RetornoPalindrome)
            {
                MessageBox.Show("É um Palindrome");
            }
            else
            {
                MessageBox.Show("Não é um Palindrome");
            }
        }

       
    }
}
